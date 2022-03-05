using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace LocationEditor
{
    public partial class MainForm : Form
    {
        // localization
        readonly Dictionary<TypeOfSceneObject, string> so_localization = DescriptionUtils.GetDescEnum<TypeOfSceneObject>();
        readonly Dictionary<TypeOfGroupCharacter, string> ch_localization = DescriptionUtils.GetDescEnum<TypeOfGroupCharacter>();
        readonly Dictionary<CharacterSkinStyle, string> chsk_localization = DescriptionUtils.GetDescEnum<CharacterSkinStyle>();

        static readonly Dictionary<TypeOfGroupCharacter, List<CharacterSkinStyle>> GroupStyleMap = new Dictionary<TypeOfGroupCharacter, List<CharacterSkinStyle>>
        {
            {
                TypeOfGroupCharacter.Adults,
                new List<CharacterSkinStyle>
                {
                    CharacterSkinStyle.invalid,

                    CharacterSkinStyle.Farmer,
                    CharacterSkinStyle.Casual,
                    CharacterSkinStyle.Business,
                    CharacterSkinStyle.Cityzen,
                    CharacterSkinStyle.Tourist,
                    CharacterSkinStyle.Beach,
                }
            },
            {
                TypeOfGroupCharacter.Celebrity,
                new List<CharacterSkinStyle>
                {
                    CharacterSkinStyle.invalid,
                }
            },
            {
                TypeOfGroupCharacter.Dog,
                new List<CharacterSkinStyle>
                {
                    CharacterSkinStyle.invalid
                }
            },
            {
                TypeOfGroupCharacter.Elderly,
                new List<CharacterSkinStyle>
                {
                    CharacterSkinStyle.invalid,
                }
            },
            {
                TypeOfGroupCharacter.Kids,
                new List<CharacterSkinStyle>
                {
                    CharacterSkinStyle.invalid,
                }
            },
            {
                TypeOfGroupCharacter.Mother_with_a_Child,
                new List<CharacterSkinStyle>
                {
                    CharacterSkinStyle.invalid,
                }
            },
            {
                TypeOfGroupCharacter.Teenagers,
                new List<CharacterSkinStyle>
                {
                    CharacterSkinStyle.invalid,

                    CharacterSkinStyle.Casual,
                    CharacterSkinStyle.Cityzen,
                }
            },
            {
                TypeOfGroupCharacter.Thieves,
                new List<CharacterSkinStyle>
                {
                    CharacterSkinStyle.invalid,
                }
            },
            {
                TypeOfGroupCharacter.Troublemakers,
                new List<CharacterSkinStyle>
                {
                    CharacterSkinStyle.invalid,
                }
            }
        };

        public LocationsData CurData = new LocationsData();
        private AvailableObjectsForm avForm;
        public AvailableObjectsInLocation avObjs = new AvailableObjectsInLocation();

        // current location info
        TypeOfLocation location = TypeOfLocation.invalid;
        int level = 1;
        TypeOfSpecEvent spec_event = TypeOfSpecEvent.invalid;

        //точка перемещения
        Point DownPoint;

        //нажата ли кнопка мыши
        bool IsDragMode;
        // текущая кнопка-перс
        Button cur_btn;
        //Button focused_btn;

        CharacterData cur_character;
        bool is_edit_product = false;
        bool is_edit_action= false;
        readonly FolderBrowserDialog fbd = new FolderBrowserDialog();
        readonly OpenFileDialog ofd = new OpenFileDialog();

        public MainForm()
        {
            InitializeComponent();

            LocationEditor.LocationsDataPath = Properties.Settings.Default["locationsDirectoryName"].ToString();

            if (!Directory.Exists(LocationEditor.LocationsDataPath))
            {
                fbd.SelectedPath = Directory.GetCurrentDirectory();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    UpdateWorkingDirectory(fbd.SelectedPath);
                }
            }

            UpdateStatus();

            LocationEditor.AvailableObjectsFilePath = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    ConfigurationManager.AppSettings.Get("dataDirectoryName"),
                    ConfigurationManager.AppSettings.Get("fileName"));

            if (!File.Exists(LocationEditor.AvailableObjectsFilePath))
            {
                ofd.InitialDirectory = Directory.GetCurrentDirectory();
                ofd.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;
                ofd.FileName = ConfigurationManager.AppSettings.Get("fileName");

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LocationEditor.AvailableObjectsFilePath = ofd.FileName;
                }
            }

            LoadAvData(LocationEditor.AvailableObjectsFilePath);

            FillEnumCb<TypeOfLocation>(Location_cb);
            Location_cb.SelectedValue = TypeOfLocation.HarrysFarm;
            FillIntCb(Level_cb, 16);
            Level_cb.SelectedValue = 1;
            FillEnumCb<TypeOfSpecEvent>(Event_cb);
            Event_cb.SelectedValue = TypeOfSpecEvent.invalid;
            FillEnumCb<TypeOfGroupCharacter>(Character_cb);
            FillEnumCb<CharacterSkinStyle>(CbCharStyle);

            FillLocationsData(LocationEditor.LocationsDataPath);
        }
        void UpdateWorkingDirectory(string path)
        {
            LocationEditor.LocationsDataPath = fbd.SelectedPath;
            Properties.Settings.Default["locationsDirectoryName"] = LocationEditor.LocationsDataPath.ToString();
            Properties.Settings.Default.Save();
        }
        void UpdateStatus()
        {
            statusLabel1.Text = string.Format("Working directory: {0}", LocationEditor.LocationsDataPath);
        }
        public void FillLocationsData(string path)
        {
            CurData.locations.Clear();

            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] folders = dir.GetDirectories();
            foreach (DirectoryInfo folder in folders)
            {
                TypeOfLocation loc = (TypeOfLocation)Enum.Parse(typeof(TypeOfLocation), folder.Name);
                List<LevelData> locationLevels = new List<LevelData>();
                locationLevels.AddRange(LoadLocation(folder.FullName));
                CurData.locations.Add(loc, locationLevels);
            }
        }
        public void LoadAvData(string path)
        {
            if (File.Exists(path))
            {
                string result = File.ReadAllText(path);
                List<object> lst = (List<object>)MiniJSON.JsonDecode(result);
                avObjs.dictionary = AvailableObjectsInLocation.FromJson(lst);
            }
        }
        private List<LevelData> LoadLocation(string path)
        {
            List<LevelData> levels = new List<LevelData>();

            List<FileInfo> files = new List<FileInfo>();
            files.AddRange(new DirectoryInfo(path).GetFiles());

            foreach (FileInfo file in files)
            {
                if (!file.Extension.Equals(".meta") && !file.Name.Contains("_tutorial"))
                {
                    try
                    {
                        LevelData level = LoadLevel(file.FullName);
                        levels.Add(level);
                        levels.Sort();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(string.Format("Error in file '{0}': {1}", file.Name, ex.Message));
                        MessageBox.Show(ex.Message, string.Format("Ошибка в файле: '{0}", file.Name), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return levels;
        }
        private LevelData LoadLevel(string path)
        {
            string result = File.ReadAllText(path);
            Dictionary<string, object> dic = (Dictionary<string, object>)MiniJSON.JsonDecode(result);
            LevelData level = LevelData.FromJson(dic);
            return level;
        }
        public static void FillIntCb(ComboBox cb, int count)
        {
            var dataSource = new Dictionary<int,string>();
            for (int i = 1; i < count; ++i)
                dataSource.Add(i, i.ToString());

            cb.DataSource = dataSource.ToList();
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
        }
        public static void FillEnumCb<T>(ComboBox cb)
        {
            var dataSource = DescriptionUtils.GetDescEnum<T>();
            cb.DataSource = dataSource.ToList();
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
        }
        public void FillAvObjs(ComboBox cb)
        {
            Dictionary<TypeOfSceneObject, string> dataSource = new Dictionary<TypeOfSceneObject, string>();
            foreach (var item in avObjs.dictionary[location])
                if (item.level <= level)
                    dataSource.Add(item.sceneObject, so_localization[item.sceneObject]);

            cb.DataSource = dataSource.ToList();
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
        }
        public DialogResult CheckLocation()
        {
            DialogResult result = DialogResult.OK;
            if (!CurData.locations.ContainsKey(location))
            {
                result = MessageBox.Show("Локация не найдена! Добавить локацию?", "Ошибка!", MessageBoxButtons.YesNo);
            }
            return result;
        }
        public DialogResult CheckLevel()
        {
            if (CurData.locations.ContainsKey(location))
            {
                foreach (var loc in CurData.locations[location])
                    if (loc.level == level)
                        return DialogResult.OK;

                return MessageBox.Show("Уровень не найден! Добавить уровень?", "Ошибка!", MessageBoxButtons.YesNo);
            }

            return DialogResult.OK;
        }
        private void LoadLevelBtn_Click(object sender, EventArgs e)
        {
            DestroyBtns();

            if (CheckLocation() == DialogResult.Yes)
                CurData.locations.Add(location, new List<LevelData>());

            if (CheckLevel() == DialogResult.Yes)
                CurData.locations[location].Add(new LevelData(location, level));

            if (CurData != null && location != TypeOfLocation.invalid && level != 0 && CurData.locations.Count != 0 && CurData.locations[location].Count != 0)
            {
                LevelData lvl = CurData.GetLevel(location, level);
                Time_tb.Text = lvl.time.ToString();
                CatTime_tb.Text = lvl.catWaitFood.ToString();
                Goal_tb.Text = lvl.goal.ToString();
                GoalStar_tb.Text = lvl.goalStar.ToString();
                CharacterCount_tb.Text = lvl.characters.Count.ToString();
                spec_event = lvl.event_name;
                Event_cb.SelectedValue = lvl.event_name;

                FillAvObjs(Product_cb);
                FillAvObjs(Object_cb);
                FillIntCb(Point_cb, 4);

                int idx = 0;
                foreach (var character in lvl.characters)
                    CreateButtonForCharacter(idx++, character);

                if (cur_btn != null)
                {
                    cur_btn.Focus();
                    BtnCharClick(cur_btn, new EventArgs());
                }
                else if (Characters_panel.Controls.Count > 0)
                {
                    cur_btn = Characters_panel.Controls[0] as Button;
                    cur_btn.Focus();
                    BtnCharClick(cur_btn, new EventArgs());
                }

                MoneyCount_tb.Text = CalculateLevelMoney().ToString();
            }
        }
        private void CreateButtonForCharacter(int index, CharacterData character)
        {
            Button btn = new Button
            {
                Height = 25,
                Width = 270,
                Left = CalculateBtnPos(character.SpawnTime)
            };
            btn.Top = 10 + (index * btn.Height);

            btn.Text = ch_localization.First(i => i.Key == character.GroupCharacter).Value;

            if (character.GroupSkin != CharacterSkinStyle.Universal && character.GroupSkin != CharacterSkinStyle.invalid)
                btn.Text += " (" + chsk_localization.First(i => i.Key == character.GroupSkin).Value +")";

            btn.Text += " -- " + character.SpawnTime + " -- " + character.requires.Count;

            if (character.unique_actions.Count > 0)
                btn.Text += " -- *";

            btn.Parent = Characters_panel;
            btn.BackColor = Color.White;
            btn.Anchor = (AnchorStyles.Right| AnchorStyles.Top);
            btn.MouseDown += Btn_MouseDown;
            btn.MouseUp += Btn_MouseUp;
            btn.MouseMove += Btn_MouseMove;
            btn.Click += BtnCharClick;
            Characters_panel.Controls.Add(btn);
        }
        private void BtnCharClick(object sender, EventArgs e)
        {
            cur_btn = sender as Button;
            cur_character = CurData.GetLevel(location,level).characters[cur_btn.TabIndex];
            Console.WriteLine(cur_btn.TabIndex);

            Character_cb.SelectedValue = cur_character.GroupCharacter;
            CbCharStyle.SelectedValue = cur_character.GroupSkin;
            Spawn_tb.Text = cur_character.SpawnTime.ToString();
            CharacterMoney_tb.Text = cur_character.Pay.ToString();

            LoadProductsToGrid();
            LoadActionsToGrid();
        }
        public int CalculateBtnPos(int spawn_time)
        {
            int time = Int32.Parse(Time_tb.Text);

            return time == 0 ? 0 : ((Characters_panel.ClientSize.Width - 265) * spawn_time) / time;
        }
        private int CalculateSpawnTime(int pos)
        {
            int time = Int32.Parse(Time_tb.Text);

            return time == 0 ? 0 : pos * time / (Characters_panel.ClientSize.Width - cur_btn.ClientSize.Width);
        }
        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragMode)
            {
                if (cur_btn.Left > 0 && cur_btn.Left < cur_btn.Parent.ClientSize.Width - cur_btn.Width)
                {
                    cur_btn.Left = cur_btn.Location.X + e.Location.X - DownPoint.X;
                }
                else if (cur_btn.Location.X + (e.X - DownPoint.X) < 0)
                {
                    cur_btn.Left = 0;
                }
                else if (cur_btn.Location.X + (e.Location.X - DownPoint.X) > cur_btn.Parent.Width - cur_btn.Width)
                {
                    cur_btn.Left = cur_btn.Parent.ClientSize.Width - cur_btn.ClientSize.Width;
                }
                else
                    cur_btn.Left = cur_btn.Location.X + e.Location.X - DownPoint.X;

                Spawn_tb.Text = CalculateSpawnTime(cur_btn.Left).ToString();
            }
        }
        private void Btn_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragMode = false;
        }
        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            DownPoint = e.Location;
            IsDragMode = true;
            cur_btn = sender as Button;
        }
        private void DestroyBtns()
        {
            if (Characters_panel.Controls.Count != 0)
            {
                for (int i = Characters_panel.Controls.Count - 1; i >= 0; i--)
                {
                    if (Characters_panel.Controls[i] is Button btn)
                    {
                        Characters_panel.Controls.RemoveAt(i);
                        btn.MouseDown -= Btn_MouseDown;
                        btn.MouseUp -= Btn_MouseUp;
                        btn.MouseMove -= Btn_MouseMove;
                        btn.Click -= BtnCharClick;
                        btn.Dispose();
                    }
                }

                cur_btn = null;
            }
        }
        private void OpenAv_btn_Click(object sender, EventArgs e)
        {
            if (avForm == null)
                avForm = new AvailableObjectsForm();

            avForm.ShowDialog();
        }
        private void LocationCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if(location != ((KeyValuePair<TypeOfLocation, string>)Location_cb.SelectedItem).Key)
                location = ((KeyValuePair<TypeOfLocation, string>)Location_cb.SelectedItem).Key;
        }
        private void LevelCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if(level != ((KeyValuePair<int, string>)Level_cb.SelectedItem).Key)
                level = ((KeyValuePair<int, string>)Level_cb.SelectedItem).Key;
        }
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if(CurData.locations[location].ElementAt(level - 1) != null )
                CurData.locations[location].RemoveAt(level - 1);
        }
        private void Spawn_tb_TextChanged(object sender, EventArgs e)
        {
            int time = Int32.Parse(Spawn_tb.Text);
            if (Spawn_tb.Text == String.Empty)
            {
                Spawn_tb.Text = "0";
                Focus();
            }
            if (time >= 0 && Int32.Parse(Time_tb.Text) >= time)
            {
                CurData.GetLevel(location,level).characters[cur_btn.TabIndex].SpawnTime = time;
                cur_btn.Left = CalculateBtnPos(CurData.GetLevel(location,level).characters[cur_btn.TabIndex].SpawnTime);
            }

            UpdateCharacterBtnText();
        }
        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (Characters_panel.Controls.Count > 0)
                LoadLevelBtn_Click(sender, e);
        }

        private void SaveLevel_btn_Click(object sender, EventArgs e)
        {
            string result = JSONUtils.JsonPrettify(MiniJSON.JsonEncode(CurData.GetLevel(location, level).ToJson()));

            string path = LocationEditor.LocationsDataPath + @"\" + location + @"\" + location + "_lvl_" + level + ".json";

            if (!Directory.Exists(LocationEditor.LocationsDataPath + @"\" + location))
                Directory.CreateDirectory(LocationEditor.LocationsDataPath + @"\" + location);

            if (!File.Exists(path))
                using (StreamWriter sw = new StreamWriter(File.Create(path), Encoding.UTF8))
                {
                    sw.WriteLine();
                }
            File.WriteAllText(path, result, Encoding.UTF8);
        }

        private void Time_tb_TextChanged(object sender, EventArgs e)
        {
            if (Time_tb.Text == String.Empty)
            {
                Time_tb.Text = "0";
                Focus();
            }
            if (Int32.Parse(Time_tb.Text) >= 0)
                CurData.GetLevel(location,level).time = Int32.Parse(Time_tb.Text);
        }
        private void DelProduct_btn_Click(object sender, EventArgs e)
        {
            if (CurData.GetLevel(location,level).characters[cur_btn.TabIndex].requires.Count > 0)
            {
                CurData.GetLevel(location,level).characters[cur_btn.TabIndex].requires.RemoveAt(Produtts_dgv.CurrentRow.Index);
                LoadProductsToGrid();
                UpdateCharacterBtnText();
            }
        }
        public void LoadProductsToGrid()
        {
            Produtts_dgv.Rows.Clear();
            foreach (var obj in CurData.GetLevel(location, level).characters[cur_btn.TabIndex].requires)
                foreach (var value in so_localization)
                    if (value.Key == obj.Product)
                    {
                        string[] row = { value.Value.ToString(), obj.Count.ToString() };
                        Produtts_dgv.Rows.Add(row);
                    }
        }
        private void AddProduct_btn_Click(object sender, EventArgs e)
        {
            RequireData data = new RequireData
            {
                Product = ((KeyValuePair<TypeOfSceneObject, string>)Product_cb.SelectedItem).Key,
                Count = Int32.Parse(Product_count_tb.Text)
            };

            if (!is_edit_product)
                cur_character.requires.Add(data);
            else
                cur_character.requires[Produtts_dgv.CurrentRow.Index] = data;

            AddProduct_btn.Text = "+";
            is_edit_product = false;
            LoadProductsToGrid();
            UpdateCharacterBtnText();
        }
        private void Produtts_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Product_cb.SelectedValue = CurData.GetLevel(location, level).characters[cur_btn.TabIndex].requires[Produtts_dgv.CurrentRow.Index].Product;
            Product_count_tb.Text = cur_character.requires[Produtts_dgv.CurrentRow.Index].Count.ToString();
            AddProduct_btn.Text = "*";
            is_edit_product = true;
        }
        private void AddAction_btn_Click(object sender, EventArgs e)
        {
            UniqueData data = new UniqueData
            {
                On_product = ((KeyValuePair<TypeOfSceneObject, string>)Object_cb.SelectedItem).Key,
                Timer = Int32.Parse(unique_time_tb.Text),
                Pointtogo = ((KeyValuePair<int, string>)Point_cb.SelectedItem).Key,
                Pay = Int32.Parse(Revard_tb.Text)
            };

            if (!is_edit_action)
                cur_character.unique_actions.Add(data);
            else
                cur_character.unique_actions[Actions_dgv.CurrentRow.Index] = data;

            AddAction_btn.Text = "+";
            is_edit_action = false;
            LoadActionsToGrid();
            UpdateCharacterBtnText();
        }
        private void DeleteAction_btn_Click(object sender, EventArgs e)
        {
            if (CurData.GetLevel(location,level).characters[cur_btn.TabIndex].unique_actions.Count > 0)
            {
                CurData.GetLevel(location,level).characters[cur_btn.TabIndex].unique_actions.RemoveAt(Actions_dgv.CurrentRow.Index);
                LoadActionsToGrid();
                UpdateCharacterBtnText();
            }
        }
        public void LoadActionsToGrid()
        {
            Actions_dgv.Rows.Clear();
            foreach (var obj in cur_character.unique_actions)
                foreach (var value in so_localization)
                    if (value.Key == obj.On_product)
                    {
                        string[] row = { value.Value.ToString(), obj.Timer.ToString(), obj.Pointtogo.ToString(), obj.Pay.ToString() };
                        Actions_dgv.Rows.Add(row);
                    }
        }
        private void Actions_dgv_DoubleClick(object sender, EventArgs e)
        {
            Object_cb.SelectedValue = cur_character.unique_actions[Actions_dgv.CurrentRow.Index].On_product;
            Point_cb.SelectedValue = cur_character.unique_actions[Actions_dgv.CurrentRow.Index].Pointtogo;
            unique_time_tb.Text = cur_character.unique_actions[Actions_dgv.CurrentRow.Index].Timer.ToString();
            Revard_tb.Text = cur_character.unique_actions[Actions_dgv.CurrentRow.Index].Pay.ToString();
            AddAction_btn.Text = "*";
            is_edit_action = true;
        }
        private void AddCharacter_btn_Click(object sender, EventArgs e)
        {
            CurData.GetLevel(location, level).characters.Add(new CharacterData());
            LoadLevelBtn_Click(sender, e);
        }
        private void CloneCharacter_btn_Click(object sender, EventArgs e)
        {
            CharacterData data = new CharacterData
            {
                GroupCharacter = CurData.GetLevel(location, level).characters[cur_btn.TabIndex].GroupCharacter,
                GroupSkin = CurData.GetLevel(location, level).characters[cur_btn.TabIndex].GroupSkin,
                Pay = CurData.GetLevel(location, level).characters[cur_btn.TabIndex].Pay,
                requires = CurData.GetLevel(location, level).characters[cur_btn.TabIndex].requires,
                SpawnTime = CurData.GetLevel(location, level).characters[cur_btn.TabIndex].SpawnTime,
                unique_actions = CurData.GetLevel(location, level).characters[cur_btn.TabIndex].unique_actions
            };
            CurData.GetLevel(location, level).characters.Add(data);
            LoadLevelBtn_Click(sender, e);
        }
        private void DelCharacter_btn_Click(object sender, EventArgs e)
        {
            CurData.GetLevel(location, level).characters.RemoveAt(cur_btn.TabIndex);
            Console.WriteLine(cur_btn.TabIndex);
            LoadLevelBtn_Click(sender, e);

        }
        private void CharacterMoney_tb_TextChanged(object sender, EventArgs e)
        {
            int money = Int32.Parse(CharacterMoney_tb.Text);
            if (CharacterMoney_tb.Text == String.Empty)
            {
                CharacterMoney_tb.Text = "0";
                Focus();
            }
            if (money >= 0)
            {
                CurData.GetLevel(location,level).characters[cur_btn.TabIndex].Pay = money;
                MoneyCount_tb.Text = CalculateLevelMoney().ToString();
            }
        }
        private void Character_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Characters_panel.Controls.Count != 0)
            {
                TypeOfGroupCharacter tmp_character = ((KeyValuePair<TypeOfGroupCharacter, string>)Character_cb.SelectedItem).Key;
                if (cur_character.GroupCharacter != tmp_character)
                {
                    CurData.GetLevel(location,level).characters[cur_btn.TabIndex].GroupCharacter = tmp_character;
                    UpdateCharacterBtnText();
                }

                FilterCharactersSkins(tmp_character);
            }
        }
        private void FilterCharactersSkins(TypeOfGroupCharacter group)
        {
            var dataSource = DescriptionUtils.GetDescEnum<CharacterSkinStyle>()
                .Where(i => GroupStyleMap[group].Contains(i.Key)).ToList();

            CbCharStyle.SelectedValueChanged -= CbCharStyle_SelectedValueChanged;
            CbCharStyle.DataSource = dataSource;
            CbCharStyle.SelectedValueChanged += CbCharStyle_SelectedValueChanged;

            CbCharStyle.Enabled = !(dataSource.Count == 1 && dataSource[0].Key == CharacterSkinStyle.invalid);
        }
        private void CbCharStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            CharacterSkinStyle groupSkin = ((KeyValuePair<CharacterSkinStyle, string>)CbCharStyle.SelectedItem).Key;
            if (cur_character != null && cur_character.GroupSkin != groupSkin)
            {
                CurData.GetLevel(location, level).characters[cur_btn.TabIndex].GroupSkin = groupSkin;
                UpdateCharacterBtnText();
            }
        }
        public void UpdateCharacterBtnText()
        {
            cur_btn.Text = ((KeyValuePair<TypeOfGroupCharacter, string>)Character_cb.SelectedItem).Value;

             var skinItem = ((KeyValuePair<CharacterSkinStyle, string>)CbCharStyle.SelectedItem);

             if (skinItem.Key != CharacterSkinStyle.Universal && skinItem.Key != CharacterSkinStyle.invalid)
                cur_btn.Text += " (" + skinItem.Value + ")";

            cur_btn.Text += " -- " + cur_character.SpawnTime + " -- " + cur_character.requires.Count;

             if (cur_character.unique_actions.Count > 0)
                cur_btn.Text += " -- *";
        }
        private void MoveUpCharacter_Click(object sender, EventArgs e)
        {
            if (cur_btn.TabIndex > 0 && Characters_panel.Controls.Count > 0)
            {
                CharacterData tmp = CurData.GetLevel(location,level).characters[cur_btn.TabIndex - 1];
                CurData.GetLevel(location,level).characters[cur_btn.TabIndex - 1] = CurData.GetLevel(location,level).characters[cur_btn.TabIndex];
                CurData.GetLevel(location,level).characters[cur_btn.TabIndex] = tmp;
                cur_btn = Characters_panel.Controls[cur_btn.TabIndex - 1] as Button;

                LoadLevelBtn_Click(sender, e);
            }
        }
        private void MoveDownCharacter_btn_Click(object sender, EventArgs e)
        {
            if (cur_btn.TabIndex < Characters_panel.Controls.Count - 1 && Characters_panel.Controls.Count > 0)
            {
                CharacterData tmp = CurData.GetLevel(location,level).characters[cur_btn.TabIndex + 1];
                CurData.GetLevel(location,level).characters[cur_btn.TabIndex + 1] = CurData.GetLevel(location,level).characters[cur_btn.TabIndex];
                CurData.GetLevel(location,level).characters[cur_btn.TabIndex] = tmp;
                cur_btn = Characters_panel.Controls[cur_btn.TabIndex + 1] as Button;

                LoadLevelBtn_Click(sender, e);
            }
        }
        public int CalculateLevelMoney()
        {
            int money = 0;
            foreach (var ch in CurData.GetLevel(location,level).characters)
            {
                money += ch.Pay;
                if (ch.unique_actions.Count > 0)
                    foreach (var ua in ch.unique_actions)
                        money += ua.Pay;
            }
            return money;
        }
        private void Product_count_tb_TextChanged(object sender, EventArgs e)
        {
            if (Product_count_tb.Text == String.Empty)
            {
                Product_count_tb.Text = "0";
                Focus();
            }
        }
        private void Revard_tb_TextChanged(object sender, EventArgs e)
        {
            if (Revard_tb.Text == String.Empty)
            {
                Revard_tb.Text = "0";
                Focus();
            }
        }
        private void Unique_time_tb_TextChanged(object sender, EventArgs e)
        {
            if (unique_time_tb.Text == String.Empty)
            {
                unique_time_tb.Text = "0";
                Focus();
            }
        }

        private void Goal_tb_TextChanged(object sender, EventArgs e)
        {
            if (Goal_tb.Text == String.Empty)
            {
                Goal_tb.Text = "0";
                Focus();
            }
            if (Int32.Parse(Goal_tb.Text) >= 0)
                CurData.GetLevel(location,level).goal = Int32.Parse(Goal_tb.Text);
        }

        private void GoalStar_tb_TextChanged(object sender, EventArgs e)
        {
            if (GoalStar_tb.Text == String.Empty)
            {
                GoalStar_tb.Text = "0";
                Focus();
            }
            if (Int32.Parse(GoalStar_tb.Text) >= 0)
                CurData.GetLevel(location,level).goalStar = Int32.Parse(GoalStar_tb.Text);
        }

        private void CatTime_tb_TextChanged(object sender, EventArgs e)
        {
            if (CatTime_tb.Text == String.Empty)
            {
                CatTime_tb.Text = "0";
                Focus();
            }
            if (Int32.Parse(CatTime_tb.Text) >= 0)
                CurData.GetLevel(location,level).catWaitFood = Int32.Parse(CatTime_tb.Text);
        }

        private void Event_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CurData.locations.Count > 0)
            {
                if (CurData.GetLevel(location, level).event_name != ((KeyValuePair<TypeOfSpecEvent, string>)Event_cb.SelectedItem).Key)
                    CurData.GetLevel(location, level).event_name = ((KeyValuePair<TypeOfSpecEvent, string>)Event_cb.SelectedItem).Key;
            }
        }

        private void SaveAsLevel_btn_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string result = JSONUtils.JsonPrettify(MiniJSON.JsonEncode(CurData.GetLevel(location, level).ToJson()));
                string path = ofd.FileName;
                File.WriteAllText(path, result);
            }
        }

        private void ReloadMenuItem_Click(object sender, EventArgs e)
        {
            fbd.SelectedPath = Directory.GetCurrentDirectory();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                UpdateWorkingDirectory(fbd.SelectedPath);
                UpdateStatus();
            }

            FillLocationsData(LocationEditor.LocationsDataPath);
        }
    }
}