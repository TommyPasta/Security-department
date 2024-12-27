
namespace Security_department.Forms
{
    using Security_department.DTOs;
    using Security_department.Presenters.Interface;
    using Security_department.Views;
    using System;
    using System.Windows.Forms;
    using Newtonsoft.Json;
    using System.IO;

    public partial class ClientForm : Form, IClientView
    {
        private readonly IClientPresenter _clientPresenter;
        private const string JsonFilePath = "clients.json";

        public ClientForm(IClientPresenter clientPresenter)
        {
            InitializeComponent();
            _clientPresenter = clientPresenter;
            LoadClients();
        }

        private void LoadClients()
        {
            var clients = _clientPresenter.GetAllClients();
            dataGridView1.Rows.Clear();
            foreach (var client in clients)
            {
                dataGridView1.Rows.Add(client.Id, client.FirstName, client.SecondName, client.Surname, client.Address, client.Phone, client.Passport.PassportNumber);
            }
        }

        public int Id
        {
            get => int.Parse(txtId.Text);
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
                txtPassportNumber.Text = value.PassportNumber;
                txtIssuingAuthority.Text = value.IssuingAuthority;
                dtpDateOfIssue.Value = value.DateOfIssue;
                dtpDateOfExpiry.Value = value.DateOfExpiry;
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

        private void btnAdd_Click(object sender, EventArgs e)
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
            SaveClientsToJson();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _clientPresenter.RemoveClient(Id);
            ClearFields();
            SaveClientsToJson();
        }
        public void ClearClientList()
        {
            dataGridView1.Rows.Clear();
        }

        public void AddClientToList(ClientDTO client)
        {
            dataGridView1.Rows.Add(client.Id, client.FirstName, client.SecondName, client.Surname, client.Address, client.Phone, client.Passport.PassportNumber);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
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
            SaveClientsToJson();
        }

        private void SaveClientsToJson()
        {
            var clients = _clientPresenter.GetAllClients();
            var json = JsonConvert.SerializeObject(clients, Formatting.Indented);
            File.WriteAllText(JsonFilePath, json);
            ShowMessage("Данные успешно сохранены в JSON.");
        }
    }
}
