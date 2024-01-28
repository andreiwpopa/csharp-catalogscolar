
namespace WinFormsApp1
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            this.textBox_prenume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1_dataNasterii = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_masculin = new System.Windows.Forms.RadioButton();
            this.radioButton_feminin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_adresa = new System.Windows.Forms.TextBox();
            this.pictureBox_student = new System.Windows.Forms.PictureBox();
            this.button_upload = new System.Windows.Forms.Button();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume:";
            // 
            // textBox_nume
            // 
            this.textBox_nume.Location = new System.Drawing.Point(124, 371);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(140, 27);
            this.textBox_nume.TabIndex = 2;
            // 
            // dataGridView_student
            // 
            this.dataGridView_student.AllowUserToAddRows = false;
            this.dataGridView_student.AllowUserToDeleteRows = false;
            this.dataGridView_student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_student.Location = new System.Drawing.Point(12, 61);
            this.dataGridView_student.Name = "dataGridView_student";
            this.dataGridView_student.RowTemplate.Height = 80;
            this.dataGridView_student.Size = new System.Drawing.Size(910, 294);
            this.dataGridView_student.TabIndex = 3;
            // 
            // textBox_prenume
            // 
            this.textBox_prenume.Location = new System.Drawing.Point(363, 371);
            this.textBox_prenume.Name = "textBox_prenume";
            this.textBox_prenume.Size = new System.Drawing.Size(142, 27);
            this.textBox_prenume.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(270, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prenume: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Nasterii:";
            // 
            // dateTimePicker1_dataNasterii
            // 
            this.dateTimePicker1_dataNasterii.Location = new System.Drawing.Point(124, 424);
            this.dateTimePicker1_dataNasterii.Name = "dateTimePicker1_dataNasterii";
            this.dateTimePicker1_dataNasterii.Size = new System.Drawing.Size(287, 27);
            this.dateTimePicker1_dataNasterii.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sex: ";
            // 
            // radioButton_masculin
            // 
            this.radioButton_masculin.AutoSize = true;
            this.radioButton_masculin.Checked = true;
            this.radioButton_masculin.Location = new System.Drawing.Point(470, 428);
            this.radioButton_masculin.Name = "radioButton_masculin";
            this.radioButton_masculin.Size = new System.Drawing.Size(96, 25);
            this.radioButton_masculin.TabIndex = 9;
            this.radioButton_masculin.TabStop = true;
            this.radioButton_masculin.Text = "Masculin";
            this.radioButton_masculin.UseVisualStyleBackColor = true;
            // 
            // radioButton_feminin
            // 
            this.radioButton_feminin.AutoSize = true;
            this.radioButton_feminin.Location = new System.Drawing.Point(581, 428);
            this.radioButton_feminin.Name = "radioButton_feminin";
            this.radioButton_feminin.Size = new System.Drawing.Size(87, 25);
            this.radioButton_feminin.TabIndex = 10;
            this.radioButton_feminin.TabStop = true;
            this.radioButton_feminin.Text = "Feminin";
            this.radioButton_feminin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(48, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adresa:";
            // 
            // textBox_adresa
            // 
            this.textBox_adresa.Location = new System.Drawing.Point(124, 481);
            this.textBox_adresa.Multiline = true;
            this.textBox_adresa.Name = "textBox_adresa";
            this.textBox_adresa.Size = new System.Drawing.Size(621, 68);
            this.textBox_adresa.TabIndex = 12;
            // 
            // pictureBox_student
            // 
            this.pictureBox_student.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_student.Location = new System.Drawing.Point(770, 374);
            this.pictureBox_student.Name = "pictureBox_student";
            this.pictureBox_student.Size = new System.Drawing.Size(129, 113);
            this.pictureBox_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_student.TabIndex = 13;
            this.pictureBox_student.TabStop = false;
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.Green;
            this.button_upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(770, 503);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(129, 30);
            this.button_upload.TabIndex = 14;
            this.button_upload.Text = "Upload Photo";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Location = new System.Drawing.Point(589, 371);
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(156, 27);
            this.textBox_telefon.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(511, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telefon: ";
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Gold;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(658, 571);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(129, 30);
            this.button_clear.TabIndex = 17;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Blue;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(793, 571);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(129, 30);
            this.button_add.TabIndex = 18;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
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
            this.panel1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Registration";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_clear);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.DataGridView dataGridView_student;
        private System.Windows.Forms.TextBox textBox_prenume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_dataNasterii;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_masculin;
        private System.Windows.Forms.RadioButton radioButton_feminin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_adresa;
        private System.Windows.Forms.PictureBox pictureBox_student;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}