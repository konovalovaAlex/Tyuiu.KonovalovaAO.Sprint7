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
        string openFilePath;
        int cols, rows;
        private void buttonOpenFile_KAO_Click(object sender, EventArgs e)
        {
            openFileDialog_KAO.ShowDialog();
            openFilePath = openFileDialog_KAO.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewBook_KAO.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewBook_KAO.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewBook_KAO.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 5] == "True")
                    dataGridViewBook_KAO.Rows[i].Cells[5].Value = true;
                else
                    dataGridViewBook_KAO.Rows[i].Cells[5].Value = false;
            }
        }

    }
    }
}
