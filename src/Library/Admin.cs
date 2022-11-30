using System;

namespace Library;

public class Admin
{
    private static Admin instance;

    public static Admin Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Admin();
            }

            return instance;
        }
    }
   
   public void addCategory(string category)
   {
        CategoriesManager.Instance.addCategory(category);
   }

    public QualificationManager GetQualificationManager()
    {
        return QualificationManager;
    }

    /// <summary>
    /// El administrador implementa un método en el que busca para el id de un usuario, empleador (identificado por Id), para las
    /// calificaciones que tenga (por los contratos ya finalizados), su calificación más alta. 
    /// </summary>
    public void getMaximum(string id)  
    {
        Employer empleador = new Employer(id);

        foreach (Employer empleador in this.Employer)
        	{
                Console.WriteLine(QualificationManager.Instance.getAverage(this.Reviews).Max());
            }
    }        
}	