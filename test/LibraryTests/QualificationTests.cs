using System.IO;

using NUnit.Framework;
namespace Library.Tests;
using Library;


    [TestFixture]
    public class QualificationTests
    {
        [SetUp]
        public void Setup()
        {   
        }
        
        [Test]
        public void AddingQualification()
        {
            Employee empleado1 = new Employee ("Juan", "Suarez", "cedula1", "Montevideo", "099999999", "juangaymer777@adinet.com.uy");
            Employer empleador1 = new Employer ("Mateo", "no se", "cedula2", "Montevideo", "099696969", "mateonosemiapellido@taringa.com");
            Contract contrato1 = new Contract(System.DateTime.Now, System.DateTime.Now, "La constru", empleador1, empleado1);
            Contract contrato2 = new Contract(System.DateTime.Now, System.DateTime.Now, "La constru", empleador1, empleado1);
            Qualification review1 = new Qualification(5, "Buen empleado");
            Qualification review2 = new Qualification(4, "Buen empleador");
            
<<<<<<< HEAD
            // Employer empleador1= new Employer("Mateo", "Sosa", "Montevideo " ,"0353212", "Mate9o@tanto");

            Qualification calificacion1= new Qualification(11, "Muy buen trabajador" );
            
            Qualification calificacion2= new Qualification(5, "Muy mal jefe" );
            Qualification calificacion3= new Qualification(76, "Muy buwn jefe" );


            //int expectedValor= 5 ;
            //string expectedDescription= "Muy mal jefe" ;

            // empleado1.Qualify(calificacion2,empleador1);
            // empleado1.Qualify(calificacion3,empleador1);

            
           //int valorObtenido= empleador1.Reviews[0].Value;
           //string descripcionObtenida= empleador1.Reviews[0].Description;

           // Assert.AreEqual(expectedValor,valorObtenido);
            //Assert.AreEqual(expectedDescription,descripcionObtenida);


=======
            empleado1.AddQualification(review1);
            empleador1.AddQualification(review2);
            Assert.AreEqual(empleado1.Reviews[0], review1);
            Assert.AreEqual(empleador1.Reviews[0], review2);
>>>>>>> master
        }
    }