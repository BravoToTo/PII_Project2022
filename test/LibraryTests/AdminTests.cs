using System.IO;
using System.Collections.Generic;
using Library;
using NUnit.Framework;

namespace LibraryTests
{
    public class AdminTests
    {
        [SetUp]
        public void Setup()
        {   
        }

        [Test]
        public void addCategoryTest()
        {
            for (int i = 1; i < 5; i++)
            {
                string category = $"{i}";
                Admin.Instance.addCategory(category);
            }
            List<Category> list = CategoriesManager.Instance.getCategories();
            int counter = 1;
            foreach (Category item in list)
            {
                string Expected = $"{counter}";
                Assert.AreEqual(Expected, item.Name);
                counter++;
            }
        }

/// <summary>
/// Test de la clase agregada al administrador
/// </summary>
        public void getMaximum(155)
        {
            Employer empleador = new Employer(155);

            foreach (Employer empleador in this.Employer)
            	{
                    Console.WriteLine(QualificationManager.Instance.getAverage(this.Reviews).Max());
                }
        }  
    }
}