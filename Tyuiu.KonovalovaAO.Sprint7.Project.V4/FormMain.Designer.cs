
namespace Tyuiu.KonovalovaAO.Sprint7.Project.V4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxAuthro_KAO = new System.Windows.Forms.TextBox();
            this.textBoxPubHos_KAO = new System.Windows.Forms.TextBox();
            this.textBoxData_KAO = new System.Windows.Forms.TextBox();
            this.buttonEdit_KAO = new System.Windows.Forms.Button();
            this.buttonDelt_KAO = new System.Windows.Forms.Button();
            this.buttonOpenFile_KAO = new System.Windows.Forms.Button();
            this.buttonSaveFile_KAO = new System.Windows.Forms.Button();
            this.buttonSort_KAO = new System.Windows.Forms.Button();
            this.textBoxSort_KAO = new System.Windows.Forms.TextBox();
            this.buttonDone_KAO = new System.Windows.Forms.Button();
            this.textBoxTitle_KAO = new System.Windows.Forms.TextBox();
            this.buttonInfo_KAO = new System.Windows.Forms.Button();
            this.labelAuthro_KAO = new System.Windows.Forms.Label();
            this.labelPubHos_KAO = new System.Windows.Forms.Label();
            this.labelData_KAO = new System.Windows.Forms.Label();
            this.labelTitle_KAO = new System.Windows.Forms.Label();
            this.labelSort_KAO = new System.Windows.Forms.Label();
            this.dataGridViewBook_KAO = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Authro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishingHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog_KAO = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_KAO = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook_KAO)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // textBoxAuthro_KAO
            // 
            this.textBoxAuthro_KAO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAuthro_KAO.Location = new System.Drawing.Point(12, 198);
            this.textBoxAuthro_KAO.Multiline = true;
            this.textBoxAuthro_KAO.Name = "textBoxAuthro_KAO";
            this.textBoxAuthro_KAO.Size = new System.Drawing.Size(181, 40);
            this.textBoxAuthro_KAO.TabIndex = 40;
            this.toolTip1.SetToolTip(this.textBoxAuthro_KAO, "Ввести Фамилию и инициалы автора (слова)");
            // 
            // textBoxPubHos_KAO
            // 
            this.textBoxPubHos_KAO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPubHos_KAO.Location = new System.Drawing.Point(239, 198);
            this.textBoxPubHos_KAO.Multiline = true;
            this.textBoxPubHos_KAO.Name = "textBoxPubHos_KAO";
            this.textBoxPubHos_KAO.Size = new System.Drawing.Size(181, 40);
            this.textBoxPubHos_KAO.TabIndex = 38;
            this.toolTip1.SetToolTip(this.textBoxPubHos_KAO, "Ввести название издательства (слова) ");
            // 
            // textBoxData_KAO
            // 
            this.textBoxData_KAO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxData_KAO.Location = new System.Drawing.Point(239, 112);
            this.textBoxData_KAO.Multiline = true;
            this.textBoxData_KAO.Name = "textBoxData_KAO";
            this.textBoxData_KAO.Size = new System.Drawing.Size(181, 40);
            this.textBoxData_KAO.TabIndex = 36;
            this.toolTip1.SetToolTip(this.textBoxData_KAO, "Ввести дату издание книги (цифры)");
            // 
            // buttonEdit_KAO
            // 
            this.buttonEdit_KAO.BackColor = System.Drawing.Color.Lavender;
            this.buttonEdit_KAO.Location = new System.Drawing.Point(148, 265);
            this.buttonEdit_KAO.Name = "buttonEdit_KAO";
            this.buttonEdit_KAO.Size = new System.Drawing.Size(133, 55);
            this.buttonEdit_KAO.TabIndex = 35;
            this.buttonEdit_KAO.Text = "изменить";
            this.toolTip1.SetToolTip(this.buttonEdit_KAO, "Изменение параметров книги");
            this.buttonEdit_KAO.UseVisualStyleBackColor = false;
            // 
            // buttonDelt_KAO
            // 
            this.buttonDelt_KAO.BackColor = System.Drawing.Color.Lavender;
            this.buttonDelt_KAO.Location = new System.Drawing.Point(287, 265);
            this.buttonDelt_KAO.Name = "buttonDelt_KAO";
            this.buttonDelt_KAO.Size = new System.Drawing.Size(133, 55);
            this.buttonDelt_KAO.TabIndex = 34;
            this.buttonDelt_KAO.Text = "удалить";
            this.toolTip1.SetToolTip(this.buttonDelt_KAO, "Удаление Книги с ее параметрами");
            this.buttonDelt_KAO.UseVisualStyleBackColor = false;
            // 
            // buttonOpenFile_KAO
            // 
            this.buttonOpenFile_KAO.BackColor = System.Drawing.Color.Lavender;
            this.buttonOpenFile_KAO.Location = new System.Drawing.Point(73, 326);
            this.buttonOpenFile_KAO.Name = "buttonOpenFile_KAO";
            this.buttonOpenFile_KAO.Size = new System.Drawing.Size(133, 55);
            this.buttonOpenFile_KAO.TabIndex = 33;
            this.buttonOpenFile_KAO.Text = "открыть файл";
            this.toolTip1.SetToolTip(this.buttonOpenFile_KAO, "Открытие файл на вашем компьютере. \r\nФайл должен быть формата SCV");
            this.buttonOpenFile_KAO.UseVisualStyleBackColor = false;
            this.buttonOpenFile_KAO.Click += new System.EventHandler(this.buttonOpenFile_KAO_Click);
            // 
            // buttonSaveFile_KAO
            // 
            this.buttonSaveFile_KAO.BackColor = System.Drawing.Color.Lavender;
            this.buttonSaveFile_KAO.Location = new System.Drawing.Point(212, 326);
            this.buttonSaveFile_KAO.Name = "buttonSaveFile_KAO";
            this.buttonSaveFile_KAO.Size = new System.Drawing.Size(133, 55);
            this.buttonSaveFile_KAO.TabIndex = 32;
            this.buttonSaveFile_KAO.Text = "сохранить файл";
            this.toolTip1.SetToolTip(this.buttonSaveFile_KAO, "Сохранить файл в выбраную папку");
            this.buttonSaveFile_KAO.UseVisualStyleBackColor = false;
            // 
            // buttonSort_KAO
            // 
            this.buttonSort_KAO.BackColor = System.Drawing.Color.Lavender;
            this.buttonSort_KAO.Location = new System.Drawing.Point(212, 481);
            this.buttonSort_KAO.Name = "buttonSort_KAO";
            this.buttonSort_KAO.Size = new System.Drawing.Size(133, 55);
            this.buttonSort_KAO.TabIndex = 31;
            this.buttonSort_KAO.Text = "сортировать";
            this.toolTip1.SetToolTip(this.buttonSort_KAO, "Сортировка по введеному столбцу");
            this.buttonSort_KAO.UseVisualStyleBackColor = false;
            // 
            // textBoxSort_KAO
            // 
            this.textBoxSort_KAO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSort_KAO.Location = new System.Drawing.Point(12, 496);
            this.textBoxSort_KAO.Multiline = true;
            this.textBoxSort_KAO.Name = "textBoxSort_KAO";
            this.textBoxSort_KAO.Size = new System.Drawing.Size(159, 40);
            this.textBoxSort_KAO.TabIndex = 30;
            this.toolTip1.SetToolTip(this.textBoxSort_KAO, "Ввести название столбца на англиском ");
            // 
            // buttonDone_KAO
            // 
            this.buttonDone_KAO.BackColor = System.Drawing.Color.Lavender;
            this.buttonDone_KAO.Location = new System.Drawing.Point(9, 265);
            this.buttonDone_KAO.Name = "buttonDone_KAO";
            this.buttonDone_KAO.Size = new System.Drawing.Size(133, 55);
            this.buttonDone_KAO.TabIndex = 26;
            this.buttonDone_KAO.Text = "добавить";
            this.toolTip1.SetToolTip(this.buttonDone_KAO, "Добовление Книги с ее параметрами в таблицу");
            this.buttonDone_KAO.UseVisualStyleBackColor = false;
            // 
            // textBoxTitle_KAO
            // 
            this.textBoxTitle_KAO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxTitle_KAO.Location = new System.Drawing.Point(12, 112);
            this.textBoxTitle_KAO.Multiline = true;
            this.textBoxTitle_KAO.Name = "textBoxTitle_KAO";
            this.textBoxTitle_KAO.Size = new System.Drawing.Size(181, 40);
            this.textBoxTitle_KAO.TabIndex = 25;
            this.toolTip1.SetToolTip(this.textBoxTitle_KAO, "Ввести название книги (слова)");
            // 
            // buttonInfo_KAO
            // 
            this.buttonInfo_KAO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInfo_KAO.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_KAO.Image")));
            this.buttonInfo_KAO.Location = new System.Drawing.Point(996, 12);
            this.buttonInfo_KAO.Name = "buttonInfo_KAO";
            this.buttonInfo_KAO.Size = new System.Drawing.Size(54, 51);
            this.buttonInfo_KAO.TabIndex = 42;
            this.buttonInfo_KAO.UseVisualStyleBackColor = false;
            // 
            // labelAuthro_KAO
            // 
            this.labelAuthro_KAO.AutoSize = true;
            this.labelAuthro_KAO.Location = new System.Drawing.Point(9, 161);
            this.labelAuthro_KAO.Name = "labelAuthro_KAO";
            this.labelAuthro_KAO.Size = new System.Drawing.Size(60, 34);
            this.labelAuthro_KAO.TabIndex = 41;
            this.labelAuthro_KAO.Text = "Автор\r\n(Authro)";
            // 
            // labelPubHos_KAO
            // 
            this.labelPubHos_KAO.AutoSize = true;
            this.labelPubHos_KAO.Location = new System.Drawing.Point(236, 161);
            this.labelPubHos_KAO.Name = "labelPubHos_KAO";
            this.labelPubHos_KAO.Size = new System.Drawing.Size(126, 34);
            this.labelPubHos_KAO.TabIndex = 39;
            this.labelPubHos_KAO.Text = "Идательство\r\n(Publishing house)";
            // 
            // labelData_KAO
            // 
            this.labelData_KAO.AutoSize = true;
            this.labelData_KAO.Location = new System.Drawing.Point(244, 75);
            this.labelData_KAO.Name = "labelData_KAO";
            this.labelData_KAO.Size = new System.Drawing.Size(101, 34);
            this.labelData_KAO.TabIndex = 37;
            this.labelData_KAO.Text = "Дата издания\r\n(Data)";
            // 
            // labelTitle_KAO
            // 
            this.labelTitle_KAO.AutoSize = true;
            this.labelTitle_KAO.Location = new System.Drawing.Point(9, 75);
            this.labelTitle_KAO.Name = "labelTitle_KAO";
            this.labelTitle_KAO.Size = new System.Drawing.Size(72, 34);
            this.labelTitle_KAO.TabIndex = 29;
            this.labelTitle_KAO.Text = "Название\r\n(Title)";
            // 
            // labelSort_KAO
            // 
            this.labelSort_KAO.AutoSize = true;
            this.labelSort_KAO.Location = new System.Drawing.Point(9, 476);
            this.labelSort_KAO.Name = "labelSort_KAO";
            this.labelSort_KAO.Size = new System.Drawing.Size(130, 17);
            this.labelSort_KAO.TabIndex = 28;
            this.labelSort_KAO.Text = "Название столбца";
            // 
            // dataGridViewBook_KAO
            // 
            this.dataGridViewBook_KAO.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewBook_KAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook_KAO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Data,
            this.Authro,
            this.PublishingHouse});
            this.dataGridViewBook_KAO.Location = new System.Drawing.Point(448, 86);
            this.dataGridViewBook_KAO.Name = "dataGridViewBook_KAO";
            this.dataGridViewBook_KAO.RowHeadersWidth = 51;
            this.dataGridViewBook_KAO.RowTemplate.Height = 24;
            this.dataGridViewBook_KAO.Size = new System.Drawing.Size(605, 464);
            this.dataGridViewBook_KAO.TabIndex = 27;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 140;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.Width = 130;
            // 
            // Authro
            // 
            this.Authro.HeaderText = "Authro";
            this.Authro.MinimumWidth = 6;
            this.Authro.Name = "Authro";
            this.Authro.Width = 140;
            // 
            // PublishingHouse
            // 
            this.PublishingHouse.HeaderText = "PublishingHouse";
            this.PublishingHouse.MinimumWidth = 6;
            this.PublishingHouse.Name = "PublishingHouse";
            this.PublishingHouse.Width = 140;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1062, 562);
            this.Controls.Add(this.buttonInfo_KAO);
            this.Controls.Add(this.labelAuthro_KAO);
            this.Controls.Add(this.textBoxAuthro_KAO);
            this.Controls.Add(this.labelPubHos_KAO);
            this.Controls.Add(this.textBoxPubHos_KAO);
            this.Controls.Add(this.labelData_KAO);
            this.Controls.Add(this.textBoxData_KAO);
            this.Controls.Add(this.buttonEdit_KAO);
            this.Controls.Add(this.buttonDelt_KAO);
            this.Controls.Add(this.buttonOpenFile_KAO);
            this.Controls.Add(this.buttonSaveFile_KAO);
            this.Controls.Add(this.buttonSort_KAO);
            this.Controls.Add(this.textBoxSort_KAO);
            this.Controls.Add(this.labelTitle_KAO);
            this.Controls.Add(this.labelSort_KAO);
            this.Controls.Add(this.dataGridViewBook_KAO);
            this.Controls.Add(this.buttonDone_KAO);
            this.Controls.Add(this.textBoxTitle_KAO);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Библиотека";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook_KAO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonInfo_KAO;
        private System.Windows.Forms.Label labelAuthro_KAO;
        private System.Windows.Forms.TextBox textBoxAuthro_KAO;
        private System.Windows.Forms.Label labelPubHos_KAO;
        private System.Windows.Forms.TextBox textBoxPubHos_KAO;
        private System.Windows.Forms.Label labelData_KAO;
        private System.Windows.Forms.TextBox textBoxData_KAO;
        private System.Windows.Forms.Button buttonEdit_KAO;
        private System.Windows.Forms.Button buttonDelt_KAO;
        private System.Windows.Forms.Button buttonOpenFile_KAO;
        private System.Windows.Forms.Button buttonSaveFile_KAO;
        private System.Windows.Forms.Button buttonSort_KAO;
        private System.Windows.Forms.TextBox textBoxSort_KAO;
        private System.Windows.Forms.Label labelTitle_KAO;
        private System.Windows.Forms.Label labelSort_KAO;
        private System.Windows.Forms.DataGridView dataGridViewBook_KAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Authro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishingHouse;
        private System.Windows.Forms.Button buttonDone_KAO;
        private System.Windows.Forms.TextBox textBoxTitle_KAO;
        private System.Windows.Forms.OpenFileDialog openFileDialog_KAO;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_KAO;
    }
}

