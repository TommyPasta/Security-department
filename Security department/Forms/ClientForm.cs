using Security_department.DTOs;
using Security_department.Presenters.Interface;
using Security_department.Views;
using System;
using System.Windows.Forms;

namespace Security_department.Forms
{
    public partial class ClientForm : Form, IClientView
    {
        private IClientPresenter _clientPresenter;

        public ClientForm()
        {
            InitializeComponent();
        }

        public void SetPresenter(IClientPresenter clientPresenter)
        {
            _clientPresenter = clientPresenter;
            LoadClients();
        }

        private void LoadClients()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("FirstName", "Имя");
            dataGridView1.Columns.Add("SecondName", "Фамилия");
            dataGridView1.Columns.Add("Surname", "Отчество");
            dataGridView1.Columns.Add("Address", "Адрес");
            dataGridView1.Columns.Add("Phone", "Телефон");
            dataGridView1.Columns.Add("PassportNumber", "Паспорт");

            var clients = _clientPresenter.GetAllClients();
            foreach (var client in clients)
            {
                dataGridView1.Rows.Add(client.Id, client.FirstName, client.SecondName, client.Surname,
                                      client.Address, client.Phone, client.Passport?.PassportNumber);
            }
        }

        public int Id
        {
            get => int.TryParse(txtId.Text, out var id) ? id : 0;
            set => txtId.Text = value.ToString();
        }

        public string FirstName
        {
            get => txtFirstName.Text;
            set => txtFirstName.Text = value;
        }

        public string SecondName
        {
            get => txtSecondName.Text;
            set => txtSecondName.Text = value;
        }

        public string Surname
        {
            get => txtSurname.Text;
            set => txtSurname.Text = value;
        }

        public string Address
        {
            get => txtAddress.Text;
            set => txtAddress.Text = value;
        }

        public string Phone
        {
            get => txtPhone.Text;
            set => txtPhone.Text = value;
        }

        public PassportDTO Passport
        {
            get => new PassportDTO
            {
                PassportNumber = txtPassportNumber.Text,
                IssuingAuthority = txtIssuingAuthority.Text,
                DateOfIssue = dtpDateOfIssue.Value,
                DateOfExpiry = dtpDateOfExpiry.Value
            };
            set
            {
                txtPassportNumber.Text = value?.PassportNumber;
                txtIssuingAuthority.Text = value?.IssuingAuthority;
                dtpDateOfIssue.Value = value?.DateOfIssue ?? DateTime.Now;
                dtpDateOfExpiry.Value = value?.DateOfExpiry ?? DateTime.Now.AddYears(10);
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ClearFields()
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtSecondName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtPassportNumber.Clear();
            txtIssuingAuthority.Clear();
            dtpDateOfIssue.Value = DateTime.Now;
            dtpDateOfExpiry.Value = DateTime.Now.AddYears(10);
        }

        public void ClearClientList()
        {
            dataGridView1.Rows.Clear();
        }

        public void AddClientToList(ClientDTO client)
        {
            dataGridView1.Rows.Add(client.Id, client.FirstName, client.SecondName, client.Surname,
                                  client.Address, client.Phone, client.Passport?.PassportNumber);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var clientDto = new ClientDTO
                {
                    Id = Id,
                    FirstName = FirstName,
                    SecondName = SecondName,
                    Surname = Surname,
                    Address = Address,
                    Phone = Phone,
                    Passport = Passport
                };
                _clientPresenter.AddClient(clientDto);
                ClearFields();
                LoadClients();
                ShowMessage("Клиент успешно добавлен.");
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
                _clientPresenter.RemoveClient(Id);
                ClearFields();
                LoadClients();
                ShowMessage("Клиент успешно удален.");
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
                var clientDto = new ClientDTO
                {
                    Id = Id,
                    FirstName = FirstName,
                    SecondName = SecondName,
                    Surname = Surname,
                    Address = Address,
                    Phone = Phone,
                    Passport = Passport
                };
                _clientPresenter.UpdateClient(clientDto);
                ClearFields();
                LoadClients();
                ShowMessage("Клиент успешно обновлен.");
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка: {ex.Message}");
            }
        }
    }
}