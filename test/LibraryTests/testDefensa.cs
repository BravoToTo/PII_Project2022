using System.IO;

using NUnit.Framework;
namespace Library.Tests;
using Library;


    [TestFixture]
    public class TestDefensa
    {
        [SetUp]
        public void Setup()
        {   
        }
        
        [Test]
        public void TestDefensa1()
        {
            Employer empleador1 = new Employer ("Mateo", "no se", "cedula2", "Montevideo", "099696969", "mateonosemiapellido@taringa.com");
            Qualification review1 = new Qualification(5, "Muy bBuen empleador");
            Qualification review2 = new Qualification(4, "Buen empleador");
            Qualification review3 = new Qualification(3, "Buen empleador");
            Qualification review4 = new Qualification(4, "Buen empleador");
            
            empleador1.AddQualification(review4);
            empleador1.AddQualification(review1);
            empleador1.AddQualification(review2);
            empleador1.AddQualification(review3);

            int expected = 5;

            Assert.AreEqual(expected, empleador1.MaxRating(empleador1));
        }
    }