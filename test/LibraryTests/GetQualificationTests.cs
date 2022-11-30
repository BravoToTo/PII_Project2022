using System.IO;

using NUnit.Framework;
namespace Library.Tests;
using Library;


    [TestFixture]
    public class GetQualificationTests
    {
        [SetUp]
        public void Setup()
        {   
        }
        
        [Test]
        public void getHigherQualification()
        {
            Employee empleado1 = new Employee ("Juan", "Suarez", "cedula1", "Montevideo", "099999999", "juangaymer777@adinet.com.uy");
            Employer empleador1 = new Employer ("Mateo", "no se", "cedula2", "Montevideo", "099696969", "mateonosemiapellido@taringa.com");
            Employer empleador2 = new Employer ("Lucas", "no se", "cedula3", "Montevideo", "099696969", "mateonosemiapellido@taringa.com");
            Contract contrato1 = new Contract(System.DateTime.Now, System.DateTime.Now, "La constru", empleador1, empleado1);
            Contract contrato2 = new Contract(System.DateTime.Now, System.DateTime.Now, "La constru", empleador2, empleado1);
            Qualification review1 = new Qualification(5, "Buen empleado");
            Qualification review2 = new Qualification(9, "Buen empleadoo");
            
            empleado1.AddQualification(review1);
            empleado1.AddQualification(review2);
            Assert.AreEqual(9, QualificationManager.Instance.getHigherQualification(empleado1));
        }
    }