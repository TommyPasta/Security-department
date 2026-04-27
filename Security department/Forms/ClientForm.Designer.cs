namespace Security_department.Forms
{
    partial class ClientForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.lblId = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.lblIssuingAuthority = new System.Windows.Forms.Label();
            this.lblDateOfIssue = new System.Windows.Forms.Label();
            this.lblDateOfExpiry = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridView1 - РАСТЯГИВАЕТСЯ ВО ВСЕ СТОРОНЫ
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 500);
            this.dataGridView1.TabIndex = 0;

            // 
            // lblId - ПРИВЯЗАН К ВЕРХУ И ПРАВОМУ КРАЮ
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(530, 15);
            this.lblId.Name = "lblId";
            this.lblId.Text = "ID:";

            // 
            // txtId - ПРИВЯЗАН К ВЕРХУ И ПРАВОМУ КРАЮ
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Location = new System.Drawing.Point(650, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(180, 20);

            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(530, 45);
            this.lblFirstName.Text = "Имя:";

            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(650, 42);
            this.txtFirstName.Size = new System.Drawing.Size(180, 20);

            // 
            // lblSecondName
            // 
            this.lblSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(530, 75);
            this.lblSecondName.Text = "Фамилия:";

            // 
            // txtSecondName
            // 
            this.txtSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecondName.Location = new System.Drawing.Point(650, 72);
            this.txtSecondName.Size = new System.Drawing.Size(180, 20);

            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(530, 105);
            this.lblSurname.Text = "Отчество:";

            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSurname.Location = new System.Drawing.Point(650, 102);
            this.txtSurname.Size = new System.Drawing.Size(180, 20);

            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(530, 135);
            this.lblAddress.Text = "Адрес:";

            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(650, 132);
            this.txtAddress.Size = new System.Drawing.Size(180, 20);

            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(530, 165);
            this.lblPhone.Text = "Телефон:";

            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(650, 162);
            this.txtPhone.Size = new System.Drawing.Size(180, 20);

            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.Location = new System.Drawing.Point(530, 195);
            this.lblPassportNumber.Text = "Номер паспорта:";

            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassportNumber.Location = new System.Drawing.Point(650, 192);
            this.txtPassportNumber.Size = new System.Drawing.Size(180, 20);

            // 
            // lblIssuingAuthority
            // 
            this.lblIssuingAuthority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIssuingAuthority.AutoSize = true;
            this.lblIssuingAuthority.Location = new System.Drawing.Point(530, 225);
            this.lblIssuingAuthority.Text = "Кем выдан:";

            // 
            // txtIssuingAuthority
            // 
            this.txtIssuingAuthority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIssuingAuthority.Location = new System.Drawing.Point(650, 222);
            this.txtIssuingAuthority.Size = new System.Drawing.Size(180, 20);

            // 
            // lblDateOfIssue
            // 
            this.lblDateOfIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateOfIssue.AutoSize = true;
            this.lblDateOfIssue.Location = new System.Drawing.Point(530, 255);
            this.lblDateOfIssue.Text = "Дата выдачи:";

            // 
            // dtpDateOfIssue
            // 
            this.dtpDateOfIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfIssue.Location = new System.Drawing.Point(650, 252);
            this.dtpDateOfIssue.Size = new System.Drawing.Size(180, 20);

            // 
            // lblDateOfExpiry
            // 
            this.lblDateOfExpiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateOfExpiry.AutoSize = true;
            this.lblDateOfExpiry.Location = new System.Drawing.Point(530, 285);
            this.lblDateOfExpiry.Text = "Срок действия:";

            // 
            // dtpDateOfExpiry
            // 
            this.dtpDateOfExpiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfExpiry.Location = new System.Drawing.Point(650, 282);
            this.dtpDateOfExpiry.Size = new System.Drawing.Size(180, 20);

            // 
            // btnAdd - ПРИВЯЗАН К НИЗУ И ПРАВОМУ КРАЮ
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(530, 470);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(630, 470);
            this.btnUpdate.Size = new System.Drawing.Size(90, 35);
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(730, 470);
            this.btnRemove.Size = new System.Drawing.Size(90, 35);
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(530, 510);
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            //this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 560);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление клиентами";

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dataGridView1,
                this.lblId, this.txtId,
                this.lblFirstName, this.txtFirstName,
                this.lblSecondName, this.txtSecondName,
                this.lblSurname, this.txtSurname,
                this.lblAddress, this.txtAddress,
                this.lblPhone, this.txtPhone,
                this.lblPassportNumber, this.txtPassportNumber,
                this.lblIssuingAuthority, this.txtIssuingAuthority,
                this.lblDateOfIssue, this.dtpDateOfIssue,
                this.lblDateOfExpiry, this.dtpDateOfExpiry,
                this.btnAdd, this.btnUpdate, this.btnRemove, this.btnClear
            });

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.TextBox txtIssuingAuthority;
        private System.Windows.Forms.DateTimePicker dtpDateOfIssue;
        private System.Windows.Forms.DateTimePicker dtpDateOfExpiry;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPassportNumber;
        private System.Windows.Forms.Label lblIssuingAuthority;
        private System.Windows.Forms.Label lblDateOfIssue;
        private System.Windows.Forms.Label lblDateOfExpiry;
    }
}