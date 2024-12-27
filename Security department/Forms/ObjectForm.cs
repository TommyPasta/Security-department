using Security_department.DTOs;
using Security_department.Presenters.Interface;
using Security_department.Views;
using System;
using System.Windows.Forms;

namespace Security_department.Forms
{
    public partial class ObjectForm : Form, IObjectView
    {
        private readonly IObjectPresenter _objectPresenter;

        public ObjectForm(IObjectPresenter objectPresenter)
        {
            InitializeComponent();
            _objectPresenter = objectPresenter;
            LoadObjects(); // Загрузка объектов при инициализации формы
        }

        public int Id { get => int.Parse(txtId.Text); set => txtId.Text = value.ToString(); }
        public string Address { get => txtAddress.Text; set => txtAddress.Text = value; }
        public int Floor { get => int.Parse(txtFloor.Text); set => txtFloor.Text = value.ToString(); }
        public string EntranceCode { get => txtEntranceCode.Text; set => txtEntranceCode.Text = value; }
        public bool HasEntranceCode { get => chkHasEntranceCode.Checked; set => chkHasEntranceCode.Checked = value; }
        public string HouseType { get => txtHouseType.Text; set => txtHouseType.Text = value; }
        public int TotalFloors { get => int.Parse(txtTotalFloors.Text); set => txtTotalFloors.Text = value.ToString(); }
        public string DoorType { get => txtDoorType.Text; set => txtDoorType.Text = value; }
        public string BalconyType { get => txtBalconyType.Text; set => txtBalconyType.Text = value; }
        public string ApartmentPlan { get => txtApartmentPlan.Text; set => txtApartmentPlan.Text = value; }

        // Методы для отображения сообщений
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        // Метод для очистки полей ввода
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

        // Метод для загрузки объектов в представление
        public void LoadObjects()
        {
            var objects = _objectPresenter.LoadObjects();
            ClearObjectList();

            foreach (var obj in objects)
            {
                AddObjectToList(obj);
            }
        }

        // Метод для добавления объекта в список
        public void AddObjectToList(ObjectDTO objectDto)
        {
            dataGridView1.Rows.Add(objectDto.Id, objectDto.Address, objectDto.Floor, objectDto.EntranceCode,
                                    objectDto.HasEntranceCode, objectDto.HouseType, objectDto.TotalFloors,
                                    objectDto.DoorType, objectDto.BalconyType, objectDto.ApartmentPlan);
        }

        // Метод для очистки списка объектов
        public void ClearObjectList()
        {
            dataGridView1.Rows.Clear();
        }

        // Обработчики событий для кнопок
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Создаем новый объект DTO на основе введенных данных
            var objectDto = new ObjectDTO
            {
                Id = Id, // Получаем ID из текстового поля
                Address = Address, // Получаем адрес из текстового поля
                Floor = Floor, // Получаем этаж из текстового поля
                EntranceCode = EntranceCode, // Получаем код замка из текстового поля
                HasEntranceCode = HasEntranceCode, // Получаем состояние замка из чекбокса
                HouseType = HouseType, // Получаем тип дома из текстового поля
                TotalFloors = TotalFloors, // Получаем общее количество этажей из текстового поля
                DoorType = DoorType, // Получаем тип двери из текстового поля
                BalconyType = BalconyType, // Получаем тип балкона из текстового поля
                ApartmentPlan = ApartmentPlan // Получаем план квартиры из текстового поля
            };

            // Вызываем метод добавления объекта в Presenter
            _objectPresenter.AddObject(objectDto);

            // Очищаем поля ввода и обновляем список объектов
            ClearFields();
            LoadObjects();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Создаем объект DTO на основе введенных данных
            var objectDto = new ObjectDTO
            {
                Id = Id, // Получаем ID из текстового поля
                Address = Address, // Получаем адрес из текстового поля
                Floor = Floor, // Получаем этаж из текстового поля
                EntranceCode = EntranceCode, // Получаем код замка из текстового поля
                HasEntranceCode = HasEntranceCode, // Получаем состояние замка из чекбокса
                HouseType = HouseType, // Получаем тип дома из текстового поля
                TotalFloors = TotalFloors, // Получаем общее количество этажей из текстового поля
                DoorType = DoorType, // Получаем тип двери из текстового поля
                BalconyType = BalconyType, // Получаем тип балкона из текстового поля
                ApartmentPlan = ApartmentPlan // Получаем план квартиры из текстового поля
            };

            // Вызываем метод обновления объекта в Presenter
            _objectPresenter.UpdateObject(objectDto);

            // Очищаем поля ввода и обновляем список объектов
            ClearFields();
            LoadObjects();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _objectPresenter.RemoveObject(Id);
            ClearFields();
            LoadObjects();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Проверка, что строка выбрана
            {
                var row = dataGridView1.Rows[e.RowIndex];

                // Заполнение полей формы данными из выбранной строки
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