using Security_department.DTOs;
using Security_department.Presenters.Interface;
using Security_department.Views;
using System;
using System.Windows.Forms;

namespace Security_department.Forms
{
    public partial class ObjectForm : Form, IObjectView
    {
        private IObjectPresenter _objectPresenter;

        public ObjectForm()
        {
            InitializeComponent();
        }

        public void SetPresenter(IObjectPresenter objectPresenter)
        {
            _objectPresenter = objectPresenter;
            LoadObjects();
        }

        public int Id
        {
            get => int.TryParse(txtId.Text, out var id) ? id : 0;
            set => txtId.Text = value.ToString();
        }

        public string Address
        {
            get => txtAddress.Text;
            set => txtAddress.Text = value;
        }

        public int Floor
        {
            get => int.TryParse(txtFloor.Text, out var floor) ? floor : 0;
            set => txtFloor.Text = value.ToString();
        }

        public string EntranceCode
        {
            get => txtEntranceCode.Text;
            set => txtEntranceCode.Text = value;
        }

        public bool HasEntranceCode
        {
            get => chkHasEntranceCode.Checked;
            set => chkHasEntranceCode.Checked = value;
        }

        public string HouseType
        {
            get => txtHouseType.Text;
            set => txtHouseType.Text = value;
        }

        public int TotalFloors
        {
            get => int.TryParse(txtTotalFloors.Text, out var floors) ? floors : 0;
            set => txtTotalFloors.Text = value.ToString();
        }

        public string DoorType
        {
            get => txtDoorType.Text;
            set => txtDoorType.Text = value;
        }

        public string BalconyType
        {
            get => txtBalconyType.Text;
            set => txtBalconyType.Text = value;
        }

        public string ApartmentPlan
        {
            get => txtApartmentPlan.Text;
            set => txtApartmentPlan.Text = value;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ClearFields()
        {
            txtId.Clear();
            txtAddress.Clear();
            txtFloor.Clear();
            txtEntranceCode.Clear();
            chkHasEntranceCode.Checked = false;
            txtHouseType.Clear();
            txtTotalFloors.Clear();
            txtDoorType.Clear();
            txtBalconyType.Clear();
            txtApartmentPlan.Clear();
        }

        public void LoadObjects()
        {
            var objects = _objectPresenter.LoadObjects();
            ClearObjectList();

            foreach (var obj in objects)
            {
                AddObjectToList(obj);
            }
        }

        public void AddObjectToList(ObjectDTO objectDto)
        {
            dataGridView1.Rows.Add(objectDto.Id, objectDto.Address, objectDto.Floor, objectDto.EntranceCode,
                                    objectDto.HasEntranceCode, objectDto.HouseType, objectDto.TotalFloors,
                                    objectDto.DoorType, objectDto.BalconyType, objectDto.ApartmentPlan);
        }

        public void ClearObjectList()
        {
            dataGridView1.Rows.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var objectDto = new ObjectDTO
                {
                    Id = Id,
                    Address = Address,
                    Floor = Floor,
                    EntranceCode = EntranceCode,
                    HasEntranceCode = HasEntranceCode,
                    HouseType = HouseType,
                    TotalFloors = TotalFloors,
                    DoorType = DoorType,
                    BalconyType = BalconyType,
                    ApartmentPlan = ApartmentPlan
                };

                _objectPresenter.AddObject(objectDto);
                ClearFields();
                LoadObjects();
                ShowMessage("Объект успешно добавлен.");
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var objectDto = new ObjectDTO
                {
                    Id = Id,
                    Address = Address,
                    Floor = Floor,
                    EntranceCode = EntranceCode,
                    HasEntranceCode = HasEntranceCode,
                    HouseType = HouseType,
                    TotalFloors = TotalFloors,
                    DoorType = DoorType,
                    BalconyType = BalconyType,
                    ApartmentPlan = ApartmentPlan
                };

                _objectPresenter.UpdateObject(objectDto);
                ClearFields();
                LoadObjects();
                ShowMessage("Объект успешно обновлен.");
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка: {ex.Message}");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                _objectPresenter.RemoveObject(Id);
                ClearFields();
                LoadObjects();
                ShowMessage("Объект успешно удален.");
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка: {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                Id = Convert.ToInt32(row.Cells["Id"].Value);
                Address = row.Cells["Address"].Value.ToString();
                Floor = Convert.ToInt32(row.Cells["Floor"].Value);
                EntranceCode = row.Cells["EntranceCode"].Value.ToString();
                HasEntranceCode = Convert.ToBoolean(row.Cells["HasEntranceCode"].Value);
                HouseType = row.Cells["HouseType"].Value.ToString();
                TotalFloors = Convert.ToInt32(row.Cells["TotalFloors"].Value);
                DoorType = row.Cells["DoorType"].Value.ToString();
                BalconyType = row.Cells["BalconyType"].Value.ToString();
                ApartmentPlan = row.Cells["ApartmentPlan"].Value.ToString();
            }
        }
    }
}