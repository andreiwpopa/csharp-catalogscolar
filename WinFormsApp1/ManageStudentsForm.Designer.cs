
namespace WinFormsApp1
{
    partial class ManageStudentsForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_upload = new System.Windows.Forms.Button();
            this.pictureBox_student = new System.Windows.Forms.PictureBox();
            this.textBox_adresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1_dataNasterii = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_prenume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_cauta = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_masculin = new System.Windows.Forms.RadioButton();
            this.radioButton_feminin = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Manage Students";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 55);
            this.panel1.TabIndex = 38;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(793, 576);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(129, 30);
            this.button_delete.TabIndex = 37;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Gold;
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(658, 576);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(129, 30);
            this.button_update.TabIndex = 36;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Location = new System.Drawing.Point(588, 407);
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(156, 27);
            this.textBox_telefon.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(510, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Telefon: ";
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.Green;
            this.button_upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(770, 524);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(129, 30);
            this.button_upload.TabIndex = 33;
            this.button_upload.Text = "Upload Photo";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // pictureBox_student
            // 
            this.pictureBox_student.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_student.Location = new System.Drawing.Point(770, 406);
            this.pictureBox_student.Name = "pictureBox_student";
            this.pictureBox_student.Size = new System.Drawing.Size(129, 113);
            this.pictureBox_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_student.TabIndex = 32;
            this.pictureBox_student.TabStop = false;
            // 
            // textBox_adresa
            // 
            this.textBox_adresa.Location = new System.Drawing.Point(118, 487);
            this.textBox_adresa.Multiline = true;
            this.textBox_adresa.Name = "textBox_adresa";
            this.textBox_adresa.Size = new System.Drawing.Size(386, 68);
            this.textBox_adresa.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Adresa:";
            // 
            // dateTimePicker1_dataNasterii
            // 
            this.dateTimePicker1_dataNasterii.Location = new System.Drawing.Point(118, 445);
            this.dateTimePicker1_dataNasterii.Name = "dateTimePicker1_dataNasterii";
            this.dateTimePicker1_dataNasterii.Size = new System.Drawing.Size(287, 27);
            this.dateTimePicker1_dataNasterii.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Data Nasterii:";
            // 
            // textBox_prenume
            // 
            this.textBox_prenume.Location = new System.Drawing.Point(362, 407);
            this.textBox_prenume.Name = "textBox_prenume";
            this.textBox_prenume.Size = new System.Drawing.Size(142, 27);
            this.textBox_prenume.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(269, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Prenume: ";
            // 
            // dataGridView_student
            // 
            this.dataGridView_student.AllowUserToAddRows = false;
            this.dataGridView_student.AllowUserToDeleteRows = false;
            this.dataGridView_student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_student.Location = new System.Drawing.Point(12, 99);
            this.dataGridView_student.Name = "dataGridView_student";
            this.dataGridView_student.RowTemplate.Height = 80;
            this.dataGridView_student.Size = new System.Drawing.Size(910, 294);
            this.dataGridView_student.TabIndex = 22;
            this.dataGridView_student.Click += new System.EventHandler(this.dataGridView_student_Click);
            // 
            // textBox_nume
            // 
            this.textBox_nume.Location = new System.Drawing.Point(118, 407);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(140, 27);
            this.textBox_nume.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nume:";
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.MediumBlue;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(523, 576);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(129, 30);
            this.button_clear.TabIndex = 39;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(634, 62);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(156, 27);
            this.textBox_search.TabIndex = 41;
            // 
            // button_cauta
            // 
            this.button_cauta.BackColor = System.Drawing.Color.MediumBlue;
            this.button_cauta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_cauta.ForeColor = System.Drawing.Color.White;
            this.button_cauta.Location = new System.Drawing.Point(796, 60);
            this.button_cauta.Name = "button_cauta";
            this.button_cauta.Size = new System.Drawing.Size(129, 30);
            this.button_cauta.TabIndex = 42;
            this.button_cauta.Text = "Cauta";
            this.button_cauta.UseVisualStyleBackColor = false;
            this.button_cauta.Click += new System.EventHandler(this.button_cauta_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(548, 487);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 27);
            this.textBox_id.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(510, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 19);
            this.label8.TabIndex = 43;
            this.label8.Text = "ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Sex: ";
            // 
            // radioButton_masculin
            // 
            this.radioButton_masculin.AutoSize = true;
            this.radioButton_masculin.Checked = true;
            this.radioButton_masculin.Location = new System.Drawing.Point(477, 449);
            this.radioButton_masculin.Name = "radioButton_masculin";
            this.radioButton_masculin.Size = new System.Drawing.Size(96, 25);
            this.radioButton_masculin.TabIndex = 28;
            this.radioButton_masculin.TabStop = true;
            this.radioButton_masculin.Text = "Masculin";
            this.radioButton_masculin.UseVisualStyleBackColor = true;
            // 
            // radioButton_feminin
            // 
            this.radioButton_feminin.AutoSize = true;
            this.radioButton_feminin.Location = new System.Drawing.Point(588, 449);
            this.radioButton_feminin.Name = "radioButton_feminin";
            this.radioButton_feminin.Size = new System.Drawing.Size(87, 25);
            this.radioButton_feminin.TabIndex = 29;
            this.radioButton_feminin.TabStop = true;
            this.radioButton_feminin.Text = "Feminin";
            this.radioButton_feminin.UseVisualStyleBackColor = true;
            // 
            // ManageStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_cauta);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_telefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.pictureBox_student);
            this.Controls.Add(this.textBox_adresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton_feminin);
            this.Controls.Add(this.radioButton_masculin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1_dataNasterii);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_prenume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_student);
            this.Controls.Add(this.textBox_nume);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageStudentsForm";
            this.Text = "ManageStudentsForm";
            this.Load += new System.EventHandler(this.ManageStudentsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.PictureBox pictureBox_student;
        private System.Windows.Forms.TextBox textBox_adresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_dataNasterii;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_prenume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_student;
        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_cauta;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_masculin;
        private System.Windows.Forms.RadioButton radioButton_feminin;
    }
}