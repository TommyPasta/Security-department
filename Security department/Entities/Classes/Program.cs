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

            IClientRepository clientRepository = new ClientRepository();
            IObjectRepository objectRepository = new ObjectRepository();
            IContractRepository contractRepository = new ContractRepository();
            ISecurityPatrolRepository securityPatrolRepository = new SecurityPatrolRepository();

 
            IClientService clientService = new ClientService(clientRepository);
            IObjectService objectService = new ObjectService(objectRepository);
            IContractService contractService = new ContractService(contractRepository);
            ISecurityPatrolService securityPatrolService = new SecurityPatrolService(securityPatrolRepository);

            // Формы создаются с правильным порядком зависимостей
            ClientForm clientForm = new ClientForm();
            ObjectForm objectForm = new ObjectForm();
            ContractForm contractForm = new ContractForm();
            SecurityPatrolForm securityPatrolForm = new SecurityPatrolForm();


            // ClientPresenter: связывает ClientForm ↔ ClientService
            IClientPresenter clientPresenter = new ClientPresenter(clientService, clientForm);

            // ObjectPresenter: связывает ObjectForm ↔ ObjectService
            IObjectPresenter objectPresenter = new ObjectPresenter(objectService);

            // ContractPresenter: связывает ContractForm ↔ ContractService
            IContractPresenter contractPresenter = new ContractPresenter(contractService, contractForm);

            // SecurityPatrolPresenter: связывает SecurityPatrolForm ↔ SecurityPatrolService + ContractService
            ISecurityPatrolPresenter securityPatrolPresenter = new SecurityPatrolPresenter(
                securityPatrolService,
                contractService,
                securityPatrolForm
            );

            // Каждая форма получает свой презентер и необходимые сервисы
            clientForm.SetPresenter(clientPresenter);

            objectForm.SetPresenter(objectPresenter);

            // ContractForm дополнительно получает сервисы для комбобоксов
            contractForm.SetPresenter(contractPresenter, objectService, clientService);

            // SecurityPatrolForm получает презентер и ContractService для загрузки контрактов
            securityPatrolForm.SetPresenter(securityPatrolPresenter, contractService);


            // MainForm получает все дочерние формы для навигации
            Application.Run(new MainForm(clientForm, objectForm, contractForm, securityPatrolForm));
        }
    }
}