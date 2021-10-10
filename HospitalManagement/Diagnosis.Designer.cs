namespace HospitalManagement
{
    partial class Diagnosis
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
            this.txt_DiagnosisId = new Guna.UI.WinForms.GunaLineTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_PatientId = new Guna.UI.WinForms.GunaComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PatientName = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Symptoms = new Guna.UI.WinForms.GunaLineTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Diagnosis = new Guna.UI.WinForms.GunaLineTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Medicines = new Guna.UI.WinForms.GunaLineTextBox();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.gv_Diagnosis = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Diagnosis)).BeginInit();
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
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(672, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Diagnosis";
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
            this.label3.Location = new System.Drawing.Point(39, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Diagnosis Id";
            // 
            // txt_DiagnosisId
            // 
            this.txt_DiagnosisId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_DiagnosisId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiagnosisId.FocusedLineColor = System.Drawing.Color.Gray;
            this.txt_DiagnosisId.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiagnosisId.LineColor = System.Drawing.Color.DarkGray;
            this.txt_DiagnosisId.Location = new System.Drawing.Point(39, 219);
            this.txt_DiagnosisId.Name = "txt_DiagnosisId";
            this.txt_DiagnosisId.PasswordChar = '\0';
            this.txt_DiagnosisId.SelectedText = "";
            this.txt_DiagnosisId.Size = new System.Drawing.Size(183, 34);
            this.txt_DiagnosisId.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Patient Id";
            // 
            // combo_PatientId
            // 
            this.combo_PatientId.BackColor = System.Drawing.Color.Transparent;
            this.combo_PatientId.BaseColor = System.Drawing.Color.White;
            this.combo_PatientId.BorderColor = System.Drawing.Color.Silver;
            this.combo_PatientId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_PatientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_PatientId.FocusedColor = System.Drawing.Color.Empty;
            this.combo_PatientId.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_PatientId.ForeColor = System.Drawing.Color.Black;
            this.combo_PatientId.FormattingEnabled = true;
            this.combo_PatientId.Location = new System.Drawing.Point(39, 285);
            this.combo_PatientId.Name = "combo_PatientId";
            this.combo_PatientId.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combo_PatientId.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combo_PatientId.Size = new System.Drawing.Size(183, 32);
            this.combo_PatientId.TabIndex = 18;
            this.combo_PatientId.Tag = "";
            this.combo_PatientId.SelectionChangeCommitted += new System.EventHandler(this.combo_PatientId_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Patient Name";
            // 
            // txt_PatientName
            // 
            this.txt_PatientName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_PatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PatientName.Enabled = false;
            this.txt_PatientName.FocusedLineColor = System.Drawing.Color.Gray;
            this.txt_PatientName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PatientName.LineColor = System.Drawing.Color.DarkGray;
            this.txt_PatientName.Location = new System.Drawing.Point(39, 355);
            this.txt_PatientName.Name = "txt_PatientName";
            this.txt_PatientName.PasswordChar = '\0';
            this.txt_PatientName.SelectedText = "";
            this.txt_PatientName.Size = new System.Drawing.Size(183, 34);
            this.txt_PatientName.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Symptoms";
            // 
            // txt_Symptoms
            // 
            this.txt_Symptoms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Symptoms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Symptoms.FocusedLineColor = System.Drawing.Color.Gray;
            this.txt_Symptoms.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Symptoms.LineColor = System.Drawing.Color.DarkGray;
            this.txt_Symptoms.Location = new System.Drawing.Point(39, 425);
            this.txt_Symptoms.Name = "txt_Symptoms";
            this.txt_Symptoms.PasswordChar = '\0';
            this.txt_Symptoms.SelectedText = "";
            this.txt_Symptoms.Size = new System.Drawing.Size(183, 34);
            this.txt_Symptoms.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Diagnosis ";
            // 
            // txt_Diagnosis
            // 
            this.txt_Diagnosis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Diagnosis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Diagnosis.FocusedLineColor = System.Drawing.Color.Gray;
            this.txt_Diagnosis.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Diagnosis.LineColor = System.Drawing.Color.DarkGray;
            this.txt_Diagnosis.Location = new System.Drawing.Point(39, 493);
            this.txt_Diagnosis.Name = "txt_Diagnosis";
            this.txt_Diagnosis.PasswordChar = '\0';
            this.txt_Diagnosis.SelectedText = "";
            this.txt_Diagnosis.Size = new System.Drawing.Size(183, 34);
            this.txt_Diagnosis.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Medicines ";
            // 
            // txt_Medicines
            // 
            this.txt_Medicines.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Medicines.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Medicines.FocusedLineColor = System.Drawing.Color.Gray;
            this.txt_Medicines.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Medicines.LineColor = System.Drawing.Color.DarkGray;
            this.txt_Medicines.Location = new System.Drawing.Point(39, 562);
            this.txt_Medicines.Name = "txt_Medicines";
            this.txt_Medicines.PasswordChar = '\0';
            this.txt_Medicines.SelectedText = "";
            this.txt_Medicines.Size = new System.Drawing.Size(183, 34);
            this.txt_Medicines.TabIndex = 26;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Purple;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Home.Location = new System.Drawing.Point(175, 764);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(98, 34);
            this.btn_Home.TabIndex = 31;
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
            this.btn_Update.Location = new System.Drawing.Point(175, 708);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(98, 34);
            this.btn_Update.TabIndex = 30;
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
            this.btn_Delete.Location = new System.Drawing.Point(39, 764);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(98, 34);
            this.btn_Delete.TabIndex = 29;
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
            this.btn_Add.Location = new System.Drawing.Point(39, 708);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(98, 34);
            this.btn_Add.TabIndex = 28;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // gv_Diagnosis
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.gv_Diagnosis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gv_Diagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Diagnosis.BackgroundColor = System.Drawing.Color.White;
            this.gv_Diagnosis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Diagnosis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_Diagnosis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Diagnosis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_Diagnosis.ColumnHeadersHeight = 30;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Diagnosis.DefaultCellStyle = dataGridViewCellStyle7;
            this.gv_Diagnosis.EnableHeadersVisualStyles = false;
            this.gv_Diagnosis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_Diagnosis.Location = new System.Drawing.Point(297, 190);
            this.gv_Diagnosis.Name = "gv_Diagnosis";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Diagnosis.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gv_Diagnosis.RowHeadersWidth = 51;
            this.gv_Diagnosis.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gv_Diagnosis.RowTemplate.Height = 30;
            this.gv_Diagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Diagnosis.Size = new System.Drawing.Size(1102, 619);
            this.gv_Diagnosis.TabIndex = 32;
            this.gv_Diagnosis.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gv_Diagnosis.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_Diagnosis.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gv_Diagnosis.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gv_Diagnosis.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gv_Diagnosis.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gv_Diagnosis.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_Diagnosis.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_Diagnosis.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.gv_Diagnosis.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_Diagnosis.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_Diagnosis.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gv_Diagnosis.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_Diagnosis.ThemeStyle.HeaderStyle.Height = 30;
            this.gv_Diagnosis.ThemeStyle.ReadOnly = false;
            this.gv_Diagnosis.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_Diagnosis.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_Diagnosis.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gv_Diagnosis.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_Diagnosis.ThemeStyle.RowsStyle.Height = 30;
            this.gv_Diagnosis.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_Diagnosis.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_Diagnosis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Diagnosis_CellContentClick);
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 841);
            this.Controls.Add(this.gv_Diagnosis);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Medicines);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Diagnosis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Symptoms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_PatientName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combo_PatientId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DiagnosisId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis";
            this.Load += new System.EventHandler(this.Diagnosis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Diagnosis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaLineTextBox txt_DiagnosisId;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaComboBox combo_PatientId;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLineTextBox txt_PatientName;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaLineTextBox txt_Symptoms;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaLineTextBox txt_Diagnosis;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaLineTextBox txt_Medicines;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private Guna.UI.WinForms.GunaDataGridView gv_Diagnosis;
    }
}