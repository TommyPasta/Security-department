namespace Security_department.Forms
{
    partial class ClientForm
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtIssuingAuthority = new System.Windows.Forms.TextBox();
            this.dtpDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfExpiry = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelId = new System.Windows.Forms.Label();
            this.labelIssuingAuthority = new System.Windows.Forms.Label();
            this.labelPassportNumber = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(637, 42);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(137, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(637, 79);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(137, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(637, 119);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(137, 20);
            this.txtSecondName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(637, 160);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(137, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(637, 203);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(137, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(637, 287);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(137, 20);
            this.txtPassportNumber.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(637, 245);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(137, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // txtIssuingAuthority
            // 
            this.txtIssuingAuthority.Location = new System.Drawing.Point(637, 323);
            this.txtIssuingAuthority.Name = "txtIssuingAuthority";
            this.txtIssuingAuthority.Size = new System.Drawing.Size(137, 20);
            this.txtIssuingAuthority.TabIndex = 7;
            // 
            // dtpDateOfIssue
            // 
            this.dtpDateOfIssue.Location = new System.Drawing.Point(368, 45);
            this.dtpDateOfIssue.Name = "dtpDateOfIssue";
            this.dtpDateOfIssue.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfIssue.TabIndex = 8;
            // 
            // dtpDateOfExpiry
            // 
            this.dtpDateOfExpiry.Location = new System.Drawing.Point(368, 97);
            this.dtpDateOfExpiry.Name = "dtpDateOfExpiry";
            this.dtpDateOfExpiry.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfExpiry.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 426);
            this.dataGridView1.TabIndex = 10;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(613, 45);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 11;
            this.labelId.Text = "ID";
            // 
            // labelIssuingAuthority
            // 
            this.labelIssuingAuthority.AutoSize = true;
            this.labelIssuingAuthority.Location = new System.Drawing.Point(491, 326);
            this.labelIssuingAuthority.Name = "labelIssuingAuthority";
            this.labelIssuingAuthority.Size = new System.Drawing.Size(140, 13);
            this.labelIssuingAuthority.TabIndex = 12;
            this.labelIssuingAuthority.Text = "Орган, выдавший паспорт";
            // 
            // labelPassportNumber
            // 
            this.labelPassportNumber.AutoSize = true;
            this.labelPassportNumber.Location = new System.Drawing.Point(540, 290);
            this.labelPassportNumber.Name = "labelPassportNumber";
            this.labelPassportNumber.Size = new System.Drawing.Size(91, 13);
            this.labelPassportNumber.TabIndex = 13;
            this.labelPassportNumber.Text = "Номер паспорта";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(579, 248);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 14;
            this.labelPhone.Text = "Телефон";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(593, 206);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(38, 13);
            this.labelAddress.TabIndex = 15;
            this.labelAddress.Text = "Адрес";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(577, 163);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(54, 13);
            this.labelSurname.TabIndex = 16;
            this.labelSurname.Text = "Отчество";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(575, 122);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(56, 13);
            this.labelSecondName.TabIndex = 17;
            this.labelSecondName.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(602, 82);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Дата выдачи паспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Дата окончания срока действия паспорта";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(624, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(543, 360);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(462, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelPassportNumber);
            this.Controls.Add(this.labelIssuingAuthority);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpDateOfExpiry);
            this.Controls.Add(this.dtpDateOfIssue);
            this.Controls.Add(this.txtIssuingAuthority);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtId);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtIssuingAuthority;
        private System.Windows.Forms.DateTimePicker dtpDateOfIssue;
        private System.Windows.Forms.DateTimePicker dtpDateOfExpiry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelIssuingAuthority;
        private System.Windows.Forms.Label labelPassportNumber;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
    }
}