using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KonovalovaAO.Sprint7.Project.V4.Lib;
namespace Tyuiu.KonovalovaAO.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_KAO.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialog_KAO.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";

        }
        DataService ds = new DataService();
        static string[,] arrayValues;
        string openFilePath;
        static int rows, colums;
        private int index;



        private void buttonDone_KAO_Click(object sender, EventArgs e)
        {
            addRow(Title_KAO.Text, Data_KAO.Text, Authro_KAO.Text, PubHos_KAO.Text);
        }
        private void addRow(string Title_KAO, string Data_KAO, string Authro_KAO, string PubHos_KAO)
        {
            String[] row = { Title_KAO, Data_KAO, Authro_KAO, PubHos_KAO };
            dataGridViewBook_KAO.Rows.Add(row);
        }

        private void buttonDelt_KAO_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewBook_KAO.SelectedRows)
            {
                dataGridViewBook_KAO.Rows.Remove(row);
            }

        }
        private void dataGridViewBook_KAO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridViewBook_KAO.Rows[index];
            Title_KAO.Text = row.Cells[0].Value.ToString();
            Data_KAO.Text = row.Cells[1].Value.ToString();
            Authro_KAO.Text = row.Cells[2].Value.ToString();
            PubHos_KAO.Text = row.Cells[3].Value.ToString();

        }

        private void buttonEdit_KAO_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = dataGridViewBook_KAO.Rows[index];
            newData.Cells[0].Value = Title_KAO.Text;
            newData.Cells[1].Value = Data_KAO.Text;
            newData.Cells[2].Value = Authro_KAO.Text;
            newData.Cells[3].Value = PubHos_KAO.Text;

        }
        private void buttonSort_KAO_Click(object sender, EventArgs e)
        {
            string columnName = Sort_KAO.Text;
            dataGridViewBook_KAO.Sort(dataGridViewBook_KAO.Columns[columnName], ListSortDirection.Ascending);
        }

        private void buttonSaveFile_KAO_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_KAO.FileName = "FileTask7.csv";
                saveFileDialog_KAO.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog_KAO.ShowDialog();

                string path = saveFileDialog_KAO.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewBook_KAO.RowCount;
                int columns = dataGridViewBook_KAO.ColumnCount;

                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridViewBook_KAO.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewBook_KAO.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.Default);
                    str = "";
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_KAO_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_KAO.ShowDialog();
                openFilePath = openFileDialog_KAO.FileName;
                arrayValues = ds.LoadFromFileData(openFilePath);
                dataGridViewBook_KAO.Rows.Clear();

                rows = arrayValues.GetUpperBound(0) + 1;
                colums = arrayValues.Length / rows;

                dataGridViewBook_KAO.ColumnCount = colums;
                dataGridViewBook_KAO.RowCount = rows;


                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < colums; c++)
                    {
                        dataGridViewBook_KAO.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }
                dataGridViewBook_KAO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                buttonSaveFile_KAO.Enabled = true;
                buttonEdit_KAO.Enabled = true;
                buttonDelt_KAO.Enabled = true;
                buttonDone_KAO.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


    }

}
  

