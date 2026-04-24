using Security_department.Forms;
using Security_department.Presenters.Classes;
using Security_department.Presenters.Interface;
using Security_department.Repositories.Classes;
using Security_department.Repositories.Interfaces;
using Security_department.Services.Classes;
using Security_department.Services;
using Security_department.Services.Interface;
using Security_department.Views;
using System;
using System.Windows.Forms;
using Security_department.Presenters;

namespace Security_department
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Инициализация репозиториев
            IClientRepository clientRepository = new ClientRepository();
            IObjectRepository objectRepository = new ObjectRepository();
            IContractRepository contractRepository = new ContractRepository();
            ISecurityPatrolRepository securityPatrolRepository = new SecurityPatrolRepository();

            // Инициализация сервисов
            IClientService clientService = new ClientService(clientRepository);
            IObjectService objectService = new ObjectService(objectRepository);
            IContractService contractService = new ContractService(contractRepository);
            ISecurityPatrolService securityPatrolService = new SecurityPatrolService(securityPatrolRepository);

            // Создание форм
            ClientForm clientForm = new ClientForm();
            ObjectForm objectForm = new ObjectForm();
            ContractForm contractForm = new ContractForm();
            SecurityPatrolForm securityPatrolForm = new SecurityPatrolForm();

            // Инициализация презентеров
            IClientPresenter clientPresenter = new ClientPresenter(clientService, clientForm);
            IObjectPresenter objectPresenter = new ObjectPresenter(objectService);
            IContractPresenter contractPresenter = new ContractPresenter(contractService, contractForm);
            ISecurityPatrolPresenter securityPatrolPresenter = new SecurityPatrolPresenter(securityPatrolService, contractService, securityPatrolForm);

            // Установка презентеров в формы
            clientForm.SetPresenter(clientPresenter);
            objectForm.SetPresenter(objectPresenter);
            contractForm.SetPresenter(contractPresenter, objectService, clientService);
            securityPatrolForm.SetPresenter(securityPatrolPresenter, contractService);

            // Запуск главной формы
            Application.Run(new MainForm(clientForm, objectForm, contractForm, securityPatrolForm));
        }
    }
}