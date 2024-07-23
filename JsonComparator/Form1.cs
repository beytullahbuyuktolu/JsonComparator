using System.Windows.Forms;
using Newtonsoft.Json;

namespace JsonComparator;

public partial class Form1 : Form
{
    public Form1() => InitializeComponent();

    private Dictionary<string, string> jsonData1;
    private Dictionary<string, string> jsonData2;

    private void btnCompare_Click(object sender, EventArgs e)
    {
        if (lbNewKeys.Items.Count > 0 && lbtobeCompared.Items.Count > 0)
        {
            var list1Keys = lbNewKeys.Items.Cast<string>().ToList();
            var list2Keys = lbtobeCompared.Items.Cast<string>().ToList();
            var result = list1Keys.Except(list2Keys).ToList();
            PopulateListBox(lbDifference, result.ToDictionary(key => key, key => jsonData1[key]));
        }
        else
            MessageBox.Show($"No Data ! ");
    }

    private void btnNewKey_Click(object sender, EventArgs e)
    {
        string jsonFilePath = GetJsonFilePath();
        if (!string.IsNullOrEmpty(jsonFilePath))
        {
            jsonData1 = LoadJsonFile(jsonFilePath);
            PopulateListBox(lbNewKeys, jsonData1);
        }
    }

    private void btntobeCompared_Click(object sender, EventArgs e)
    {
        string jsonFilePath = GetJsonFilePath();
        if (!string.IsNullOrEmpty(jsonFilePath))
        {
            jsonData2 = LoadJsonFile(jsonFilePath);
            PopulateListBox(lbtobeCompared, jsonData2);
        }
    }

    private void btnDifference_Click(object sender, EventArgs e)
    {
        if (lbNewKeys.Items.Count > 0 && lbtobeCompared.Items.Count > 0)
            if (lbDifference.Items.Count > 0)
            {
                foreach (var item in lbDifference.Items)
                    if (!lbtobeCompared.Items.Contains(item))
                        lbtobeCompared.Items.Add(item);

                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        var combinedData = lbtobeCompared.Items.Cast<string>().ToDictionary(key => key, key => jsonData1.ContainsKey(key) ? jsonData1[key] : jsonData2[key]);
                        var json = JsonConvert.SerializeObject(combinedData, Formatting.Indented);
                        string filePath = Path.Combine(folderDialog.SelectedPath, "combinedData.json");
                        File.WriteAllText(filePath, json);
                        MessageBox.Show($"JSON data has been saved to {filePath}");
                    }
                }
            }
            else
                MessageBox.Show($"First, make calculations using the Find Differences of 2 Selected Files button.");
        else
            MessageBox.Show($"No Data ! Listbox1 and Listbox2");




    }
    private string? GetJsonFilePath()
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                return openFileDialog.FileName;
        }
        return null;
    }
    private Dictionary<string, string> LoadJsonFile(string filePath)
    {
        var jsonContent = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent);
    }

    private void PopulateListBox(ListBox listBox, Dictionary<string, string> data)
    {
        listBox.Items.Clear();
        foreach (var key in data.Keys)
            listBox.Items.Add(key);
    }

}