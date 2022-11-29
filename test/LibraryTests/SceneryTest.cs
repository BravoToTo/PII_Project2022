using NUnit.Framework;


namespace Library.Test
{
    [TestFixture]
    public class SceneryTest
    {
        [Test]
        public void SceneryTesting()
        {
            // Registro un empleado y un empleador
            Employee employee = new Employee ("Gonzalo", "Cañete", "gonza123", "Montevideo", "099701004", "gonza@gmail.com");
            Employer employer = new Employer ("Diego", "Godin", "faraon3", "Qatar", "01234567", "DiegoGodin@gmail.com");
            

            Admin admin = new Admin();

            // Genero una oferta
            employee.addOffer("Cocinero", 425.45, "Gastronomía");

            // Agrego la categoria
            admin.addCategory("Gastronomía");

            // Busco una oferta como empleador
            employer.searchOffers("Gastronomía");
            
            CategoriesManager.Instance.addCategory("Gastronomía");
            CategoriesManager.Instance.getCategories();

            // Reviso los contratos historicos del empleado y empleador
            ContractManager.Instance.getContracts(employee);
            ContractManager.Instance.getContracts(employer);
            
            // Hago una contratacion
            //employer.hireEmployee(CategoriesManager.Instance.getCategories());
            //admin.removeOffer();
            // Simulo una contratacion, si hago el test así, me marca error por el readLine()
            
            // Genero un contrato
            ContractManager.Instance.createContracts(12, "Cocinero", employee, employer);
            
            //ContractManager.Instance.getContracts(employee);
            
            // Reviso los contratos generados nuevamente
            employee.getContracts();
            employer.getContracts();
            
            // Califico empleado y empleador
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

