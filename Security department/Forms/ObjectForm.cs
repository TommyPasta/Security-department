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
            SetupDataGridView();  // Настройка столбцов ДО загрузки данных

            // Подписываемся на событие клика по таблице
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        public void SetPresenter(IObjectPresenter objectPresenter)
        {
            _objectPresenter = objectPresenter;
            LoadObjects();  // Загружаем данные только после получения презентера
        }

        private void SetupDataGridView()
        {
            // Очищаем существующие колонки
            dataGridView1.Columns.Clear();

            // Создаём колонки
            dataGridView1.Columns.Add(CreateColumn("Id", "ID", 40));
            dataGridView1.Columns.Add(CreateColumn("Address", "Адрес", 180));
            dataGridView1.Columns.Add(CreateColumn("Floor", "Этаж", 50));
            dataGridView1.Columns.Add(CreateColumn("EntranceCode", "Код замка", 80));
            dataGridView1.Columns.Add(CreateColumn("HasEntranceCode", "Замок", 50));
            dataGridView1.Columns.Add(CreateColumn("HouseType", "Тип дома", 100));
            dataGridView1.Columns.Add(CreateColumn("TotalFloors", "Этажей", 60));
            dataGridView1.Columns.Add(CreateColumn("DoorType", "Тип двери", 100));
            dataGridView1.Columns.Add(CreateColumn("BalconyType", "Тип балкона", 100));
            dataGridView1.Columns.Add(CreateColumn("ApartmentPlan", "План квартиры", 120));

            // Настройка внешнего вида таблицы
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
        }

        private DataGridViewColumn CreateColumn(string name, string header, int width)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = name;
            column.HeaderText = header;
            column.Width = width;
            return column;
        }

        // Свойства интерфейса IObjectView
        public int Id
        {
            get
            {
                int.TryParse(txtId.Text, out int id);
                return id;
            }
            set => txtId.Text = value.ToString();
        }

        public string Address
        {
            get => txtAddress.Text;
            set => txtAddress.Text = value;
        }

        public int Floor
        {
            get
            {
                int.TryParse(txtFloor.Text, out int floor);
                return floor;
            }
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
            get
            {
                int.TryParse(txtTotalFloors.Text, out int floors);
                return floors;
            }
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

        // Методы интерфейса
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Загрузка объектов в таблицу
        public void LoadObjects()
        {
            try
            {
                var objects = _objectPresenter.LoadObjects();
                ClearObjectList();

                foreach (var obj in objects)
                {
                    AddObjectToList(obj);
                }
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка загрузки списка объектов: {ex.Message}");
            }
        }

        // Добавление объекта в таблицу
        public void AddObjectToList(ObjectDTO objectDto)
        {
            dataGridView1.Rows.Add(
                objectDto.Id,
                objectDto.Address,
                objectDto.Floor,
                objectDto.EntranceCode ?? "",
                objectDto.HasEntranceCode ? "Да" : "Нет",
                objectDto.HouseType ?? "",
                objectDto.TotalFloors,
                objectDto.DoorType ?? "",
                objectDto.BalconyType ?? "",
                objectDto.ApartmentPlan ?? ""
            );
        }

        // Очистка таблицы
        public void ClearObjectList()
        {
            dataGridView1.Rows.Clear();
        }

        // Обработчик клика по таблице
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    var row = dataGridView1.Rows[e.RowIndex];

                    if (row.Cells["Id"].Value != null)
                        Id = Convert.ToInt32(row.Cells["Id"].Value);

                    Address = row.Cells["Address"].Value?.ToString() ?? "";

                    if (row.Cells["Floor"].Value != null)
                        Floor = Convert.ToInt32(row.Cells["Floor"].Value);

                    EntranceCode = row.Cells["EntranceCode"].Value?.ToString() ?? "";

                    if (row.Cells["HasEntranceCode"].Value != null)
                        HasEntranceCode = row.Cells["HasEntranceCode"].Value.ToString() == "Да";

                    HouseType = row.Cells["HouseType"].Value?.ToString() ?? "";

                    if (row.Cells["TotalFloors"].Value != null)
                        TotalFloors = Convert.ToInt32(row.Cells["TotalFloors"].Value);

                    DoorType = row.Cells["DoorType"].Value?.ToString() ?? "";
                    BalconyType = row.Cells["BalconyType"].Value?.ToString() ?? "";
                    ApartmentPlan = row.Cells["ApartmentPlan"].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    ShowError($"Ошибка при выборе записи: {ex.Message}");
                }
            }
        }

        // Кнопка "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка заполнения обязательных полей
                if (string.IsNullOrWhiteSpace(Address))
                {
                    ShowError("Адрес не может быть пустым.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(HouseType))
                {
                    ShowError("Тип дома не может быть пустым.");
                    return;
                }

                // Создаём DTO
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

                // Добавляем через презентер
                _objectPresenter.AddObject(objectDto);
                ClearFields();
                LoadObjects();
                ShowMessage("Объект успешно добавлен.");
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка при добавлении объекта: {ex.Message}");
            }
        }

        // Кнопка "Обновить"
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                {
                    ShowError("Выберите объект для обновления из таблицы (кликните по строке).");
                    return;
                }

                if (string.IsNullOrWhiteSpace(Address))
                {
                    ShowError("Адрес не может быть пустым.");
                    return;
                }

                // Создаём DTO
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

                // Обновляем через презентер
                _objectPresenter.UpdateObject(objectDto);
                ClearFields();
                LoadObjects();
                ShowMessage("Объект успешно обновлён.");
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка при обновлении объекта: {ex.Message}");
            }
        }

        // Кнопка "Удалить"
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                {
                    ShowError("Выберите объект для удаления из таблицы (кликните по строке).");
                    return;
                }

                // Подтверждение удаления
                var result = MessageBox.Show(
                    $"Вы уверены, что хотите удалить объект №{Id}?\nАдрес: {Address}",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    _objectPresenter.RemoveObject(Id);
                    ClearFields();
                    LoadObjects();
                    ShowMessage("Объект успешно удалён.");
                }
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка при удалении объекта: {ex.Message}");
            }
        }

        // Загрузка формы
        private void ObjectForm_Load(object sender, EventArgs e)
        {
            // Если презентер ещё не установлен, ничего не делаем
            // Данные загрузятся после вызова SetPresenter
        }
    }
}