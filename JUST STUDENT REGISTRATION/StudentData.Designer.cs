namespace JUST_STUDENT_REGISTRATION
{
    partial class StudentData
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
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.male = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.Female = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Class = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mobile = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.date = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.StudentRecord = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.WhiteSmoke;
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.label1);
            this.header.Location = new System.Drawing.Point(0, -2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1287, 91);
            this.header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(27, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "StudentID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(29, 177);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(227, 37);
            this.id.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.id.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.id.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.id.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.id.StateCommon.Border.Rounding = 16;
            this.id.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(306, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "StudentName";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(308, 177);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(227, 37);
            this.name.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.name.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.name.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.name.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.name.StateCommon.Border.Rounding = 16;
            this.name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(27, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // male
            // 
            this.male.Location = new System.Drawing.Point(33, 276);
            this.male.Name = "male";
            this.male.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.male.Size = new System.Drawing.Size(71, 30);
            this.male.StateCommon.AdjacentGap = 3;
            this.male.StateCommon.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.male.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.male.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.male.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.TabIndex = 4;
            this.male.Values.Text = "Male";
            // 
            // Female
            // 
            this.Female.Location = new System.Drawing.Point(110, 275);
            this.Female.Name = "Female";
            this.Female.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Female.Size = new System.Drawing.Size(94, 30);
            this.Female.StateCommon.AdjacentGap = 3;
            this.Female.StateCommon.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.Female.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Female.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Female.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.TabIndex = 4;
            this.Female.Values.Text = "Female";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(306, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Classs";
            // 
            // Class
            // 
            this.Class.DropDownWidth = 217;
            this.Class.Items.AddRange(new object[] {
            "CA201",
            "CA202",
            "CA203",
            "CA204",
            "CA205",
            "CA206",
            "CA207",
            "CA208",
            "CA209",
            "CA210",
            "CA211",
            "CA212"});
            this.Class.Location = new System.Drawing.Point(308, 276);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(227, 36);
            this.Class.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.Class.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gray;
            this.Class.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gray;
            this.Class.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Class.StateCommon.ComboBox.Border.Rounding = 16;
            this.Class.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Class.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(27, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "DateOfBirth";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(306, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mobile";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // mobile
            // 
            this.mobile.Location = new System.Drawing.Point(308, 364);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(227, 37);
            this.mobile.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.mobile.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.mobile.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.mobile.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mobile.StateCommon.Border.Rounding = 16;
            this.mobile.TabIndex = 3;
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(24, 358);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(227, 47);
            this.date.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.date.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.date.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.date.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.date.StateCommon.Border.Rounding = 20;
            this.date.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.date.StateCommon.Content.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.TabIndex = 6;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(29, 453);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.Green;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.Green;
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.Color.Green;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Border.Rounding = 7;
            this.kryptonButton1.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.Size = new System.Drawing.Size(132, 41);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Green;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.Green;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 7;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 7;
            this.kryptonButton1.Values.Text = "Save";
            this.kryptonButton1.Click += new System.EventHandler(this.SaveData);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(184, 453);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.Green;
            this.kryptonButton2.OverrideDefault.Border.Color1 = System.Drawing.Color.Green;
            this.kryptonButton2.OverrideDefault.Border.Color2 = System.Drawing.Color.Green;
            this.kryptonButton2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.OverrideDefault.Border.Rounding = 7;
            this.kryptonButton2.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.Size = new System.Drawing.Size(132, 41);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.Green;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.Green;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 7;
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 7;
            this.kryptonButton2.Values.Text = "Update";
            this.kryptonButton2.Click += new System.EventHandler(this.UpdateStudent);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(331, 453);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonButton3.OverrideDefault.Back.Color2 = System.Drawing.Color.Red;
            this.kryptonButton3.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.kryptonButton3.OverrideDefault.Border.Color2 = System.Drawing.Color.Red;
            this.kryptonButton3.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.OverrideDefault.Border.Rounding = 7;
            this.kryptonButton3.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.Size = new System.Drawing.Size(132, 41);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.Color.Red;
            this.kryptonButton3.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 7;
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.TabIndex = 7;
            this.kryptonButton3.Values.Text = "Delete";
            this.kryptonButton3.Click += new System.EventHandler(this.DeleteStudent);
            // 
            // StudentRecord
            // 
            this.StudentRecord.AllowUserToAddRows = false;
            this.StudentRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentRecord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StudentRecord.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.StudentRecord.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.StudentRecord.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.StudentRecord.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.StudentRecord.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.StudentRecord.Location = new System.Drawing.Point(0, 512);
            this.StudentRecord.MultiSelect = false;
            this.StudentRecord.Name = "StudentRecord";
            this.StudentRecord.ReadOnly = true;
            this.StudentRecord.RowHeadersWidth = 51;
            this.StudentRecord.RowTemplate.Height = 24;
            this.StudentRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentRecord.Size = new System.Drawing.Size(1278, 310);
            this.StudentRecord.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.StudentRecord.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.StudentRecord.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.StudentRecord.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.StudentRecord.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.StudentRecord.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Poppins SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRecord.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.StudentRecord.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.StudentRecord.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.StudentRecord.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.StudentRecord.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StudentRecord.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.StudentRecord.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.StudentRecord.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Poppins SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRecord.TabIndex = 8;
            this.StudentRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JUST_STUDENT_REGISTRATION.Properties.Resources.edu;
            this.pictureBox2.Location = new System.Drawing.Point(594, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(631, 436);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JUST_STUDENT_REGISTRATION.Properties.Resources.icons8_close_30;
            this.pictureBox1.Location = new System.Drawing.Point(1175, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Close);
            // 
            // StudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 822);
            this.Controls.Add(this.StudentRecord);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentData";
            this.Load += new System.EventHandler(this.StudentData_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox id;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox name;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton male;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton Female;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Class;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox mobile;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker date;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView StudentRecord;
    }
}