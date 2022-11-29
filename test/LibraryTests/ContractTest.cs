using NUnit.Framework;

namespace Library.Test
{
    [TestFixture]
    public class ContractTests
    {
        [Test]
        public void createContractsTest()
        {
            // Creo employee para probar la creación del contrato
            Employee employee = new Employee ("Gonzalo", "Cañete", "gonza.cañete", "Montevideo","099701004","gonzalo@gmail.com");
            // Creo employer
            Employer employer = new Employer ("Cristiano", "Ronaldo", "CR7", "Manchester", "12345678", "CR7@gmail.com");
            
            // Test de creación de contrato
            //Contract expected = new Contract (System.DateTime.Now, System.DateTime.Now.AddMonths(12), "Jardinero", employer, employee);
            
            ContractManager.Instance.createContracts(12, "Jardineria",employee, employer);
            Assert.IsNotEmpty(ContractManager.Instance.contracts);
            
        }

        [Test]
        public void createContractsTestError()
        {
            Employee employee = new Employee ("Gonzalo", "Cañete", "gonza.cañete", "Montevideo","099701004","gonzalo@gmail.com");
            // Creo employer
            Employer employer = new Employer ("Cristiano", "Ronaldo", "CR7", "Manchester", "12345678", "CR7@gmail.com");
            
            // Test de creación de contrato
            //Contract expected = new Contract (System.DateTime.Now, System.DateTime.Now.AddMonths(12), "Jardinero", employer, employee);
            
            ContractManager.Instance.createContracts(-1,"Jardineria",employee, employer);
            Assert.Throws<ContractException>(
                delegate {throw new ContractException();});
            
        }

        [Test]
        public void getContractsTest()
        {
            Employee employee = new Employee ("Gonzalo", "Cañete", "gonza.cañete", "Montevideo","099701004","gonzalo@gmail.com");
            Employer employer = new Employer ("Cristiano", "Ronaldo", "CR7", "Manchester", "12345678", "CR7@gmail.com");
            ContractManager.Instance.createContracts(12,"Jardinero",employee, employer);
            Assert.IsNotEmpty(ContractManager.Instance.getContracts(employee));
        }
        [Test]
        public void getContractTestError()
        {
            Employee employee = new Employee ("Gonzalo", "Cañete", "gonza.cañete", "Montevideo","099701004","gonzalo@gmail.com");
            Employer employer = new Employer ("Cristiano", "Ronaldo", "CR7", "Manchester", "12345678", "CR7@gmail.com");
            ContractManager.Instance.createContracts(-1,"Jardinero",employee, employer);
            // Compruebo que no agregue el contrato debido a la fecha inválida
            Assert.IsNotEmpty(ContractManager.Instance.getContracts(employee));
        }
        [Test]
        public void getFinishedContractsTest()
        {
            Employee employee = new Employee ("Gonzalo", "Cañete", "gonza.cañete", "Montevideo","099701004","gonzalo@gmail.com");
            Employer employer = new Employer ("Cristiano", "Ronaldo", "CR7", "Manchester", "12345678", "CR7@gmail.com");
            ContractManager.Instance.createContracts(12,"Jardinero",employee, employer);
            foreach (Contract contract in ContractManager.Instance.contracts)
            {
                contract.ended();
            }
            Assert.IsNotEmpty(ContractManager.Instance.getFinishedContracts(employee));
        }
        [Test]
        public void getFinishedContractsTestError()
        {
            Employee employee = new Employee ("Gonzalo", "Cañete", "gonza.cañete", "Montevideo","099701004","gonzalo@gmail.com");
            Employer employer = new Employer ("Cristiano", "Ronaldo", "CR7", "Manchester", "12345678", "CR7@gmail.com");
            ContractManager.Instance.createContracts(12,"Jardinero",employee, employer);
            // Compruebo que no se agregue ningún contrato no finalizado
            Assert.IsEmpty(ContractManager.Instance.getFinishedContracts(employee));
        }
        
    }
}