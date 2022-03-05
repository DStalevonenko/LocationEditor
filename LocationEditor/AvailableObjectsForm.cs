using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LocationEditor
{
    public partial class AvailableObjectsForm : Form
    {
        AvailableObjectsInLocation objs = new AvailableObjectsInLocation();
        TypeOfLocation loc = TypeOfLocation.HarrysFarm;
        TypeOfSceneObject so = TypeOfSceneObject.tomatoes;
        Dictionary<TypeOfSceneObject, string> localization = DescriptionUtils.GetDescEnum<TypeOfSceneObject>();
        int level = 1;
        public AvailableObjectsForm()
        {
            InitializeComponent();

            LoadFromFile();

            MainForm.FillEnumCb<TypeOfLocation>(CbLocation);
            CbLocation.SelectedValue = TypeOfLocation.HarrysFarm;
            MainForm.FillIntCb(CbLevel, 16);
            CbLevel.SelectedValue = 1;
            MainForm.FillEnumCb<TypeOfSceneObject>(CbSceneObject);
            CbSceneObject.SelectedValue = TypeOfSceneObject.tomatoes;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AvailableObject obj = new AvailableObject(so, level);

            if (!objs.dictionary.ContainsKey(loc))
                objs.dictionary.Add(loc, new List<AvailableObject>() { obj});
            else
                if (!objs.dictionary[loc].Contains(obj))
                    objs.dictionary[loc].Add(obj);

            LoadDataToGrid();
        }

        public void LoadDataToGrid()
        {
            AvGridV.Rows.Clear();
            if (objs.dictionary.ContainsKey(loc))
                foreach (var avObjects in objs.dictionary[loc])
                    foreach (var value in localization)
                        if (value.Key == avObjects.sceneObject)
                        {
                            string[] row = { value.Value.ToString(), avObjects.level.ToString() };
                            AvGridV.Rows.Add(row);
                        }
        }

        private void AvGridV_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            AvGridV.Rows.Clear();
            LoadDataToGrid();
        }

        private void AvailableObjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(LocationEditor.AvailableObjectsFilePath, JSONUtils.JsonPrettify(MiniJSON.JsonEncode(objs.ToJson())));
        }

        public void LoadFromFile()
        {
            if (File.Exists(LocationEditor.AvailableObjectsFilePath))
            {
                string result = File.ReadAllText(LocationEditor.AvailableObjectsFilePath);
                List<object> lst = (List<object>)MiniJSON.JsonDecode(result);
                objs.dictionary = AvailableObjectsInLocation.FromJson(lst);
            }
        }

        private void CbLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            loc = ((KeyValuePair<TypeOfLocation, string>)CbLocation.SelectedItem).Key;
            LoadDataToGrid();
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            TypeOfSceneObject so_for_del = TypeOfSceneObject.invalid;
            if (localization.ContainsValue(AvGridV.CurrentRow.Cells[0].Value.ToString()))
                foreach (var item in localization)
                    if (item.Value == AvGridV.CurrentRow.Cells[0].Value.ToString())
                        so_for_del = item.Key;

            int lvl = Int32.Parse(AvGridV.CurrentRow.Cells[1].Value.ToString());
            for (int i = 0; i < objs.dictionary[loc].Count; ++i)
                if (objs.dictionary[loc][i].sceneObject == so_for_del && objs.dictionary[loc][i].level == lvl)
                    objs.dictionary[loc].RemoveAt(i);

            LoadDataToGrid();
        }

        private void CbSceneObject_SelectedValueChanged(object sender, EventArgs e)
        {
            so = ((KeyValuePair<TypeOfSceneObject, string>)CbSceneObject.SelectedItem).Key;
        }

        private void CbLevel_SelectedValueChanged(object sender, EventArgs e)
        {
            level = ((KeyValuePair<int, string>)CbLevel.SelectedItem).Key;
        }
    }
}
