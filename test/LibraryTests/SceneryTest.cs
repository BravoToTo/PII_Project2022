using NUnit.Framework;

namespace Library.Test
{
    [TestFixture]
    public class SceneryTest
    {
        [Test]
        public void SceneryTesting()
        {
            Employee employee = new Employee ("Gonzalo", "Cañete", "gonza123", "Montevideo", "099701004", "gonza@gmail.com");
            Employer employer = new Employer ("Diego", "Godin", "faraon3", "Qatar", "01234567", "DiegoGodin@gmail.com");
            
            Admin admin = new Admin();
            employee.addOffer("Cocinero", 425.45, "Gastronomía");
            admin.addCategory("Gastronomía");
            employer.searchOffers("Gastronomía");
            
            CategoriesManager.Instance.addCategory("Gastronomía");
            CategoriesManager.Instance.getCategories();
            
            ContractManager.Instance.getContracts(employee);
            ContractManager.Instance.getContracts(employer);
            
            //employer.hireEmployee(CategoriesManager.Instance.getCategories());
            //admin.removeOffer();
            // Simulo una contratacion, si hago el test así, me marca error por el readLine()
            
            ContractManager.Instance.createContracts(12, "Cocinero", employee, employer);
            
            //ContractManager.Instance.getContracts(employee);
            
            employee.getContracts();
            employer.getContracts();
            
            // Simulo una calificacion para que no me marque error
           
            //employer.Qualify();
            employee.getQualy();
            
            // Simulo una calificación para que no me marque error
            
            //employee.Qualify();
            employer.getQualy();

            // Compruebo la fecha del contrato:
            foreach (Contract contract in ContractManager.Instance.contracts)
            {
                if (contract.Finished == false)
                {
                    //admin.removeOffer();
                }
                else if (contract.Finished)
                {
                    contract.employee.hired = false;
                }
            }
            
            
            
        }
        
    }
}

