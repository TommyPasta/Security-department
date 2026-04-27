namespace Security_department.Forms
{
    partial class SecurityPatrolForm
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
            this.dataGridViewPatrols = new System.Windows.Forms.DataGridView();
            this.txtCrewNumber = new System.Windows.Forms.TextBox();
            this.txtCommanderName = new System.Windows.Forms.TextBox();
            this.txtCallReason = new System.Windows.Forms.TextBox();
            this.txtStolenItemName = new System.Windows.Forms.TextBox();
            this.txtStolenItemValue = new System.Windows.Forms.TextBox();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.txtIssuingAuthority = new System.Windows.Forms.TextBox();
            this.dtpDepartureDateTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.comboBoxContracts = new System.Windows.Forms.ComboBox();
            this.btnExecutePatrol = new System.Windows.Forms.Button();
            this.btnAddStolenItem = new System.Windows.Forms.Button();
            this.btnAddArrestDetails = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.lblContract = new System.Windows.Forms.Label();
            this.lblCrewNumber = new System.Windows.Forms.Label();
            this.lblCommanderName = new System.Windows.Forms.Label();
            this.lblCallReason = new System.Windows.Forms.Label();
            this.lblDepartureDateTime = new System.Windows.Forms.Label();
            this.lblStolenItemName = new System.Windows.Forms.Label();
            this.lblStolenItemValue = new System.Windows.Forms.Label();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.lblIssuingAuthority = new System.Windows.Forms.Label();
            this.lblDateOfIssue = new System.Windows.Forms.Label();
            this.groupBoxPatrol = new System.Windows.Forms.GroupBox();
            this.groupBoxStolen = new System.Windows.Forms.GroupBox();
            this.groupBoxArrest = new System.Windows.Forms.GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatrols)).BeginInit();
            this.groupBoxPatrol.SuspendLayout();
            this.groupBoxStolen.SuspendLayout();
            this.groupBoxArrest.SuspendLayout();
            this.SuspendLayout();

            // 
            // dataGridViewPatrols
            // 
            this.dataGridViewPatrols.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPatrols.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPatrols.Size = new System.Drawing.Size(450, 550);

            // 
            // groupBoxPatrol
            // 
            this.groupBoxPatrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPatrol.Location = new System.Drawing.Point(480, 12);
            this.groupBoxPatrol.Size = new System.Drawing.Size(320, 170);
            this.groupBoxPatrol.Text = "Данные патруля";

            // lblContract
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(10, 25);
            this.lblContract.Text = "Контракт:";
            this.groupBoxPatrol.Controls.Add(this.lblContract);

            // comboBoxContracts
            this.comboBoxContracts.Location = new System.Drawing.Point(120, 22);
            this.comboBoxContracts.Size = new System.Drawing.Size(190, 21);
            this.comboBoxContracts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBoxPatrol.Controls.Add(this.comboBoxContracts);

            // lblCrewNumber
            this.lblCrewNumber.AutoSize = true;
            this.lblCrewNumber.Location = new System.Drawing.Point(10, 55);
            this.lblCrewNumber.Text = "Номер экипажа:";
            this.groupBoxPatrol.Controls.Add(this.lblCrewNumber);

            // txtCrewNumber
            this.txtCrewNumber.Location = new System.Drawing.Point(120, 52);
            this.txtCrewNumber.Size = new System.Drawing.Size(190, 20);
            this.groupBoxPatrol.Controls.Add(this.txtCrewNumber);

            // lblCommanderName
            this.lblCommanderName.AutoSize = true;
            this.lblCommanderName.Location = new System.Drawing.Point(10, 85);
            this.lblCommanderName.Text = "Командир:";
            this.groupBoxPatrol.Controls.Add(this.lblCommanderName);

            // txtCommanderName
            this.txtCommanderName.Location = new System.Drawing.Point(120, 82);
            this.txtCommanderName.Size = new System.Drawing.Size(190, 20);
            this.groupBoxPatrol.Controls.Add(this.txtCommanderName);

            // lblCallReason
            this.lblCallReason.AutoSize = true;
            this.lblCallReason.Location = new System.Drawing.Point(10, 115);
            this.lblCallReason.Text = "Причина вызова:";
            this.groupBoxPatrol.Controls.Add(this.lblCallReason);

            // txtCallReason
            this.txtCallReason.Location = new System.Drawing.Point(120, 112);
            this.txtCallReason.Size = new System.Drawing.Size(190, 20);
            this.groupBoxPatrol.Controls.Add(this.txtCallReason);

            // lblDepartureDateTime
            this.lblDepartureDateTime.AutoSize = true;
            this.lblDepartureDateTime.Location = new System.Drawing.Point(10, 145);
            this.lblDepartureDateTime.Text = "Дата выезда:";
            this.groupBoxPatrol.Controls.Add(this.lblDepartureDateTime);

            // dtpDepartureDateTime
            this.dtpDepartureDateTime.Location = new System.Drawing.Point(120, 141);
            this.dtpDepartureDateTime.Size = new System.Drawing.Size(190, 20);
            this.groupBoxPatrol.Controls.Add(this.dtpDepartureDateTime);

            // 
            // groupBoxStolen
            // 
            this.groupBoxStolen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStolen.Location = new System.Drawing.Point(480, 195);
            this.groupBoxStolen.Size = new System.Drawing.Size(320, 100);
            this.groupBoxStolen.Text = "Украденная вещь";

            // lblStolenItemName
            this.lblStolenItemName.AutoSize = true;
            this.lblStolenItemName.Location = new System.Drawing.Point(10, 25);
            this.lblStolenItemName.Text = "Название:";
            this.groupBoxStolen.Controls.Add(this.lblStolenItemName);

            // txtStolenItemName
            this.txtStolenItemName.Location = new System.Drawing.Point(120, 22);
            this.txtStolenItemName.Size = new System.Drawing.Size(190, 20);
            this.groupBoxStolen.Controls.Add(this.txtStolenItemName);

            // lblStolenItemValue
            this.lblStolenItemValue.AutoSize = true;
            this.lblStolenItemValue.Location = new System.Drawing.Point(10, 55);
            this.lblStolenItemValue.Text = "Стоимость:";
            this.groupBoxStolen.Controls.Add(this.lblStolenItemValue);

            // txtStolenItemValue
            this.txtStolenItemValue.Location = new System.Drawing.Point(120, 52);
            this.txtStolenItemValue.Size = new System.Drawing.Size(100, 20);
            this.groupBoxStolen.Controls.Add(this.txtStolenItemValue);

            // btnAddStolenItem
            this.btnAddStolenItem.Location = new System.Drawing.Point(120, 75);
            this.btnAddStolenItem.Size = new System.Drawing.Size(100, 20);
            this.btnAddStolenItem.Text = "Добавить вещь";
            this.btnAddStolenItem.UseVisualStyleBackColor = true;
            this.btnAddStolenItem.Click += new System.EventHandler(this.btnAddStolenItem_Click);
            this.groupBoxStolen.Controls.Add(this.btnAddStolenItem);

            // 
            // groupBoxArrest
            // 
            this.groupBoxArrest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxArrest.Location = new System.Drawing.Point(480, 308);
            this.groupBoxArrest.Size = new System.Drawing.Size(320, 130);
            this.groupBoxArrest.Text = "Сведения о задержании";

            // lblDocumentNumber
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Location = new System.Drawing.Point(10, 25);
            this.lblDocumentNumber.Text = "Номер документа:";
            this.groupBoxArrest.Controls.Add(this.lblDocumentNumber);

            // txtDocumentNumber
            this.txtDocumentNumber.Location = new System.Drawing.Point(120, 22);
            this.txtDocumentNumber.Size = new System.Drawing.Size(190, 20);
            this.groupBoxArrest.Controls.Add(this.txtDocumentNumber);

            // lblIssuingAuthority
            this.lblIssuingAuthority.AutoSize = true;
            this.lblIssuingAuthority.Location = new System.Drawing.Point(10, 55);
            this.lblIssuingAuthority.Text = "Кем выдан:";
            this.groupBoxArrest.Controls.Add(this.lblIssuingAuthority);

            // txtIssuingAuthority
            this.txtIssuingAuthority.Location = new System.Drawing.Point(120, 52);
            this.txtIssuingAuthority.Size = new System.Drawing.Size(190, 20);
            this.groupBoxArrest.Controls.Add(this.txtIssuingAuthority);

            // lblDateOfIssue
            this.lblDateOfIssue.AutoSize = true;
            this.lblDateOfIssue.Location = new System.Drawing.Point(10, 85);
            this.lblDateOfIssue.Text = "Дата выдачи:";
            this.groupBoxArrest.Controls.Add(this.lblDateOfIssue);

            // dtpDateOfIssue
            this.dtpDateOfIssue.Location = new System.Drawing.Point(120, 81);
            this.dtpDateOfIssue.Size = new System.Drawing.Size(190, 20);
            this.groupBoxArrest.Controls.Add(this.dtpDateOfIssue);

            // btnAddArrestDetails
            this.btnAddArrestDetails.Location = new System.Drawing.Point(120, 105);
            this.btnAddArrestDetails.Size = new System.Drawing.Size(120, 20);
            this.btnAddArrestDetails.Text = "Добавить задержание";
            this.btnAddArrestDetails.UseVisualStyleBackColor = true;
            this.btnAddArrestDetails.Click += new System.EventHandler(this.btnAddArrestDetails_Click);
            this.groupBoxArrest.Controls.Add(this.btnAddArrestDetails);

            // 
            // btnExecutePatrol
            // 
            this.btnExecutePatrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecutePatrol.Location = new System.Drawing.Point(490, 460);
            this.btnExecutePatrol.Size = new System.Drawing.Size(130, 40);
            this.btnExecutePatrol.Text = "Выполнить патруль";
            this.btnExecutePatrol.UseVisualStyleBackColor = true;
            this.btnExecutePatrol.Click += new System.EventHandler(this.btnExecutePatrol_Click);

            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(630, 460);
            this.btnClear.Size = new System.Drawing.Size(90, 40);
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
         //   this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // SecurityPatrolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 580);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление патрулями";

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dataGridViewPatrols,
                this.groupBoxPatrol,
                this.groupBoxStolen,
                this.groupBoxArrest,
                this.btnExecutePatrol,
                this.btnClear
            });

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatrols)).EndInit();
            this.groupBoxPatrol.ResumeLayout(false);
            this.groupBoxPatrol.PerformLayout();
            this.groupBoxStolen.ResumeLayout(false);
            this.groupBoxStolen.PerformLayout();
            this.groupBoxArrest.ResumeLayout(false);
            this.groupBoxArrest.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewPatrols;
        private System.Windows.Forms.TextBox txtCrewNumber;
        private System.Windows.Forms.TextBox txtCommanderName;
        private System.Windows.Forms.TextBox txtCallReason;
        private System.Windows.Forms.TextBox txtStolenItemName;
        private System.Windows.Forms.TextBox txtStolenItemValue;
        private System.Windows.Forms.TextBox txtDocumentNumber;
        private System.Windows.Forms.TextBox txtIssuingAuthority;
        private System.Windows.Forms.DateTimePicker dtpDepartureDateTime;
        private System.Windows.Forms.DateTimePicker dtpDateOfIssue;
        private System.Windows.Forms.ComboBox comboBoxContracts;
        private System.Windows.Forms.Button btnExecutePatrol;
        private System.Windows.Forms.Button btnAddStolenItem;
        private System.Windows.Forms.Button btnAddArrestDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Label lblCrewNumber;
        private System.Windows.Forms.Label lblCommanderName;
        private System.Windows.Forms.Label lblCallReason;
        private System.Windows.Forms.Label lblDepartureDateTime;
        private System.Windows.Forms.Label lblStolenItemName;
        private System.Windows.Forms.Label lblStolenItemValue;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.Label lblIssuingAuthority;
        private System.Windows.Forms.Label lblDateOfIssue;
        private System.Windows.Forms.GroupBox groupBoxPatrol;
        private System.Windows.Forms.GroupBox groupBoxStolen;
        private System.Windows.Forms.GroupBox groupBoxArrest;
    }
}