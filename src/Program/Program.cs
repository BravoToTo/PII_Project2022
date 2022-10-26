using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Category cat = new Category();

            Offer Offer1 = new Offer("Arquitecto", 100);
            Offer Offer2 = new Offer("Ingeniero", 500);
            Offer Offer3 = new Offer("Jardinero", 1000);
            ServiceOffer Services = new ServiceOffer();
            Services.addOffer(Offer1);
            Services.addOffer(Offer2);
            Services.addOffer(Offer3);

            Admin adm = new Admin();
            adm.addCategory(cat, "Translator");
            adm.addCategory(cat, "Data Analyst");
            adm.addCategory(cat, "Fitness Instructor");

            /*
            cat.getCategories();
            cat.removeCategory();
            cat.getCategories();
            */

            /*
            Services.getServices();
            Services.removeService();
            Services.getServices();
            */

            
            Employee emp = new Employee ("Gonzalo", "Cañete", "Centro", "099701004", "gonzalocb1997@gmail.com");
            //Contract cont = new Contract("12/12/2022", "13/12/2022","Translator");
            //Contract cont2 = new Contract("18/2/2010", "12/10/2022","Developer");
            /*
            emp.addContracts(cont,emp);
            emp.addContracts(cont2,emp);
            emp.printContracts();
            */
            
            Employer dir = new Employer("Juan","Perez","Centro","092123456","juanperez@gmail.com");

            emp.makeOffer("Translator");
            dir.searchOffer("Translator");

            dir.hireEmployee(emp,dir);
            emp.addContracts(emp);
            emp.printContracts();

            /*
            User user1 = new User ("Pedro", "Gonzalez","012345678","aaa@gmail.com");
            user1.makeUser("Employer");
            User user2 = new User ("Juan","Sosa", "0156", "asd@gmail.com");
            user2.makeUser("Employer");
            */
        }
    }
}
