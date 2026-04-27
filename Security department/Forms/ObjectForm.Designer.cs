namespace Security_department.Forms
{
    partial class ObjectForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.txtEntranceCode = new System.Windows.Forms.TextBox();
            this.txtHouseType = new System.Windows.Forms.TextBox();
            this.txtTotalFloors = new System.Windows.Forms.TextBox();
            this.txtDoorType = new System.Windows.Forms.TextBox();
            this.txtBalconyType = new System.Windows.Forms.TextBox();
            this.txtApartmentPlan = new System.Windows.Forms.TextBox();
            this.chkHasEntranceCode = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.lblId = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblEntranceCode = new System.Windows.Forms.Label();
            this.lblHouseType = new System.Windows.Forms.Label();
            this.lblTotalFloors = new System.Windows.Forms.Label();
            this.lblDoorType = new System.Windows.Forms.Label();
            this.lblBalconyType = new System.Windows.Forms.Label();
            this.lblApartmentPlan = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Size = new System.Drawing.Size(500, 500);

            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(530, 15);
            this.lblId.Text = "ID объекта:";

            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Location = new System.Drawing.Point(650, 12);
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(150, 20);

            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(530, 45);
            this.lblAddress.Text = "Адрес:";

            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(650, 42);
            this.txtAddress.Size = new System.Drawing.Size(200, 20);

            // 
            // lblFloor
            // 
            this.lblFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(530, 75);
            this.lblFloor.Text = "Этаж:";

            // 
            // txtFloor
            // 
            this.txtFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFloor.Location = new System.Drawing.Point(650, 72);
            this.txtFloor.Size = new System.Drawing.Size(60, 20);

            // 
            // lblEntranceCode
            // 
            this.lblEntranceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntranceCode.AutoSize = true;
            this.lblEntranceCode.Location = new System.Drawing.Point(530, 105);
            this.lblEntranceCode.Text = "Код замка:";

            // 
            // txtEntranceCode
            // 
            this.txtEntranceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntranceCode.Location = new System.Drawing.Point(650, 102);
            this.txtEntranceCode.Size = new System.Drawing.Size(100, 20);

            // 
            // chkHasEntranceCode
            // 
            this.chkHasEntranceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHasEntranceCode.AutoSize = true;
            this.chkHasEntranceCode.Location = new System.Drawing.Point(533, 132);
            this.chkHasEntranceCode.Text = "Есть кодовый замок";

            // 
            // lblHouseType
            // 
            this.lblHouseType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHouseType.AutoSize = true;
            this.lblHouseType.Location = new System.Drawing.Point(530, 160);
            this.lblHouseType.Text = "Тип дома:";

            // 
            // txtHouseType
            // 
            this.txtHouseType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHouseType.Location = new System.Drawing.Point(650, 157);
            this.txtHouseType.Size = new System.Drawing.Size(150, 20);

            // 
            // lblTotalFloors
            // 
            this.lblTotalFloors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFloors.AutoSize = true;
            this.lblTotalFloors.Location = new System.Drawing.Point(530, 190);
            this.lblTotalFloors.Text = "Всего этажей:";

            // 
            // txtTotalFloors
            // 
            this.txtTotalFloors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalFloors.Location = new System.Drawing.Point(650, 187);
            this.txtTotalFloors.Size = new System.Drawing.Size(60, 20);

            // 
            // lblDoorType
            // 
            this.lblDoorType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoorType.AutoSize = true;
            this.lblDoorType.Location = new System.Drawing.Point(530, 220);
            this.lblDoorType.Text = "Тип двери:";

            // 
            // txtDoorType
            // 
            this.txtDoorType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoorType.Location = new System.Drawing.Point(650, 217);
            this.txtDoorType.Size = new System.Drawing.Size(150, 20);

            // 
            // lblBalconyType
            // 
            this.lblBalconyType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalconyType.AutoSize = true;
            this.lblBalconyType.Location = new System.Drawing.Point(530, 250);
            this.lblBalconyType.Text = "Тип балкона:";

            // 
            // txtBalconyType
            // 
            this.txtBalconyType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBalconyType.Location = new System.Drawing.Point(650, 247);
            this.txtBalconyType.Size = new System.Drawing.Size(150, 20);

            // 
            // lblApartmentPlan
            // 
            this.lblApartmentPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApartmentPlan.AutoSize = true;
            this.lblApartmentPlan.Location = new System.Drawing.Point(530, 280);
            this.lblApartmentPlan.Text = "План квартиры:";

            // 
            // txtApartmentPlan
            // 
            this.txtApartmentPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApartmentPlan.Location = new System.Drawing.Point(650, 277);
            this.txtApartmentPlan.Multiline = true;
            this.txtApartmentPlan.Size = new System.Drawing.Size(200, 80);

            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(530, 470);
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
           // this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // ObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 560);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление объектами";

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dataGridView1,
                this.lblId, this.txtId,
                this.lblAddress, this.txtAddress,
                this.lblFloor, this.txtFloor,
                this.lblEntranceCode, this.txtEntranceCode,
                this.chkHasEntranceCode,
                this.lblHouseType, this.txtHouseType,
                this.lblTotalFloors, this.txtTotalFloors,
                this.lblDoorType, this.txtDoorType,
                this.lblBalconyType, this.txtBalconyType,
                this.lblApartmentPlan, this.txtApartmentPlan,
                this.btnAdd, this.btnUpdate, this.btnRemove, this.btnClear
            });

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.TextBox txtEntranceCode;
        private System.Windows.Forms.TextBox txtHouseType;
        private System.Windows.Forms.TextBox txtTotalFloors;
        private System.Windows.Forms.TextBox txtDoorType;
        private System.Windows.Forms.TextBox txtBalconyType;
        private System.Windows.Forms.TextBox txtApartmentPlan;
        private System.Windows.Forms.CheckBox chkHasEntranceCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblEntranceCode;
        private System.Windows.Forms.Label lblHouseType;
        private System.Windows.Forms.Label lblTotalFloors;
        private System.Windows.Forms.Label lblDoorType;
        private System.Windows.Forms.Label lblBalconyType;
        private System.Windows.Forms.Label lblApartmentPlan;
    }
}