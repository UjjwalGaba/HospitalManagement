namespace HospitalManagement
{
    partial class Patient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PatientId = new Guna.UI.WinForms.GunaLineTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PatientAddress = new Guna.UI.WinForms.GunaLineTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PatientName = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PatientAge = new Guna.UI.WinForms.GunaLineTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PatientPhone = new Guna.UI.WinForms.GunaLineTextBox();
            this.combo_Gender = new Guna.UI.WinForms.GunaComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_BloodGroup = new Guna.UI.WinForms.GunaComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Disease = new Guna.UI.WinForms.GunaLineTextBox();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.gv_Patient = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Patient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 144);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(672, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(625, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "City Hospital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Patient Id";
            // 
            // txt_PatientId
            // 
            this.txt_PatientId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_PatientId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PatientId.FocusedLineColor = System.Drawing.Color.Gray;
            this.txt_PatientId.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PatientId.LineColor = System.Drawing.Color.DarkGray;
            this.txt_PatientId.Location = new System.Drawing.Point(496, 203);
            this.txt_PatientId.Name = "txt_PatientId";
            this.txt_PatientId.PasswordChar = '\0';
            this.txt_PatientId.SelectedText = "";
            this.txt_PatientId.Size = new System.Drawing.Size(183, 34);
            this.txt_PatientId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Patient Address";
            // 
            // txt_PatientAddress
            // 
            this.txt_PatientAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_PatientAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PatientAddress.FocusedLineColor = System.Drawing.Color.Gray;
            this.txt_PatientAddress.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PatientAddress.LineColor = System.Drawing.Color.DarkGray;
            this.txt_PatientAddress.Location = new System.Drawing.Point(496, 331);
            this.txt_PatientAddress.Name = "txt_PatientAddress";
            this.txt_PatientAddress.PasswordChar = '\0';
            this.txt_PatientAddress.SelectedText = "";
            this.txt_PatientAddress.Size = new System.Drawing.Size(183, 34);
            this.txt_PatientAddress.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Patient Name";
            // 
            // txt_PatientName
            // 
            this.txt_PatientName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_PatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PatientName.FocusedLineColor = System.Drawing.Color.Gray;
            this.txt_PatientName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PatientName.LineColor = System.Drawing.Color.DarkGray;
            this.txt_PatientName.Location = new System.Drawing.Point(496, 267);
            this.txt_PatientName.Name = "txt_PatientName";
            this.txt_PatientName.PasswordChar = '\0';
            this.txt_PatientName.SelectedText = "";
            this.txt_PatientName.Size = new System.Drawing.Size(183, 34);
            this.txt_PatientName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Patient Age";
            // 
            // txt_PatientAge
            // 
            this.txt_PatientAge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_PatientAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PatientAge.FocusedLineColor = System.Drawing.Color.Gray;
            this.txt_PatientAge.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PatientAge.LineColor = System.Drawing.Color.DarkGray;
            this.txt_PatientAge.Location = new System.Drawing.Point(496, 397);
            this.txt_PatientAge.Name = "txt_PatientAge";
            this.txt_PatientAge.PasswordChar = '\0';
            this.txt_PatientAge.SelectedText = "";
            this.txt_PatientAge.Size = new System.Drawing.Size(183, 34);
            this.txt_PatientAge.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(737, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Patient Phone";
            // 
            // txt_PatientPhone
            // 
            this.txt_PatientPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_PatientPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PatientPhone.FocusedLineColor = System.Drawing.Color.Gray;
            this.txt_PatientPhone.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PatientPhone.LineColor = System.Drawing.Color.DarkGray;
            this.txt_PatientPhone.Location = new System.Drawing.Point(737, 203);
            this.txt_PatientPhone.Name = "txt_PatientPhone";
            this.txt_PatientPhone.PasswordChar = '\0';
            this.txt_PatientPhone.SelectedText = "";
            this.txt_PatientPhone.Size = new System.Drawing.Size(183, 34);
            this.txt_PatientPhone.TabIndex = 14;
            // 
            // combo_Gender
            // 
            this.combo_Gender.BackColor = System.Drawing.Color.Transparent;
            this.combo_Gender.BaseColor = System.Drawing.Color.White;
            this.combo_Gender.BorderColor = System.Drawing.Color.Silver;
            this.combo_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Gender.FocusedColor = System.Drawing.Color.Empty;
            this.combo_Gender.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Gender.ForeColor = System.Drawing.Color.Black;
            this.combo_Gender.FormattingEnabled = true;
            this.combo_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combo_Gender.Location = new System.Drawing.Point(737, 262);
            this.combo_Gender.Name = "combo_Gender";
            this.combo_Gender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combo_Gender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combo_Gender.Size = new System.Drawing.Size(183, 32);
            this.combo_Gender.TabIndex = 16;
            this.combo_Gender.Tag = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(737, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Gender";
            // 
            // combo_BloodGroup
            // 
            this.combo_BloodGroup.BackColor = System.Drawing.Color.Transparent;
            this.combo_BloodGroup.BaseColor = System.Drawing.Color.White;
            this.combo_BloodGroup.BorderColor = System.Drawing.Color.Silver;
            this.combo_BloodGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_BloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_BloodGroup.FocusedColor = System.Drawing.Color.Empty;
            this.combo_BloodGroup.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_BloodGroup.ForeColor = System.Drawing.Color.Black;
            this.combo_BloodGroup.FormattingEnabled = true;
            this.combo_BloodGroup.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.combo_BloodGroup.Location = new System.Drawing.Point(737, 325);
            this.combo_BloodGroup.Name = "combo_BloodGroup";
            this.combo_BloodGroup.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combo_BloodGroup.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combo_BloodGroup.Size = new System.Drawing.Size(183, 32);
            this.combo_BloodGroup.TabIndex = 18;
            this.combo_BloodGroup.Tag = "Blood Group";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(737, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Blood Group";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(737, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Major Disease";
            // 
            // txt_Disease
            // 
            this.txt_Disease.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Disease.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Disease.FocusedLineColor = System.Drawing.Color.Gray;
            this.txt_Disease.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Disease.LineColor = System.Drawing.Color.DarkGray;
            this.txt_Disease.Location = new System.Drawing.Point(737, 392);
            this.txt_Disease.Name = "txt_Disease";
            this.txt_Disease.PasswordChar = '\0';
            this.txt_Disease.SelectedText = "";
            this.txt_Disease.Size = new System.Drawing.Size(183, 34);
            this.txt_Disease.TabIndex = 20;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Purple;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Home.Location = new System.Drawing.Point(740, 503);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(98, 34);
            this.btn_Home.TabIndex = 26;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Purple;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Update.Location = new System.Drawing.Point(737, 447);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(98, 34);
            this.btn_Update.TabIndex = 25;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Purple;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Delete.Location = new System.Drawing.Point(581, 503);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(98, 34);
            this.btn_Delete.TabIndex = 24;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Purple;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add.Location = new System.Drawing.Point(581, 447);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(98, 34);
            this.btn_Add.TabIndex = 23;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // gv_Patient
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.gv_Patient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gv_Patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Patient.BackgroundColor = System.Drawing.Color.White;
            this.gv_Patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Patient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_Patient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_Patient.ColumnHeadersHeight = 30;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Patient.DefaultCellStyle = dataGridViewCellStyle7;
            this.gv_Patient.EnableHeadersVisualStyles = false;
            this.gv_Patient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_Patient.Location = new System.Drawing.Point(15, 585);
            this.gv_Patient.Name = "gv_Patient";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Patient.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gv_Patient.RowHeadersWidth = 51;
            this.gv_Patient.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gv_Patient.RowTemplate.Height = 30;
            this.gv_Patient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Patient.Size = new System.Drawing.Size(1386, 229);
            this.gv_Patient.TabIndex = 27;
            this.gv_Patient.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gv_Patient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_Patient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gv_Patient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gv_Patient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gv_Patient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gv_Patient.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_Patient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_Patient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.gv_Patient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_Patient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_Patient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gv_Patient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_Patient.ThemeStyle.HeaderStyle.Height = 30;
            this.gv_Patient.ThemeStyle.ReadOnly = false;
            this.gv_Patient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_Patient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_Patient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gv_Patient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_Patient.ThemeStyle.RowsStyle.Height = 30;
            this.gv_Patient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_Patient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_Patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Patient_CellContentClick);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1413, 841);
            this.Controls.Add(this.gv_Patient);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Disease);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_BloodGroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combo_Gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_PatientPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_PatientAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_PatientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_PatientAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PatientId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaLineTextBox txt_PatientId;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLineTextBox txt_PatientAddress;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaLineTextBox txt_PatientName;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaLineTextBox txt_PatientAge;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaLineTextBox txt_PatientPhone;
        private Guna.UI.WinForms.GunaComboBox combo_Gender;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaComboBox combo_BloodGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaLineTextBox txt_Disease;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private Guna.UI.WinForms.GunaDataGridView gv_Patient;
    }
}