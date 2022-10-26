using System.Collections;
using System.Collections.Generic;
namespace Library;

/// <summary>
/// Implemento interfaz ISearchoffer, encargada de devolver un string para usar en el metodo hireEmployee
/// </summary>
public class Employer : ISearchOffer
{
    //datos personales
    public string displayName;
    private string Name;
    private string LastName;
    public string Location;
    //info de contacto
    public ArrayList contactNumbers = new ArrayList();
    public string contactEmail;
    public List<Qualification> Reviews = new List<Qualification>();
    public string SearchCategory;

    public Employer (string Name, string LastName, string Location, string contactNumber, string contactEmail)
    {
        this.displayName = Name;
        this.Name = Name;
        this.LastName = LastName;
        this.Location = Location;
        this.contactNumbers.Add(contactNumber);
        this.contactEmail = contactEmail;
        
    }
    public void changeUsername(string newName)
    {
        this.displayName = newName;
    }
    public void addNumber(string newNumber)
    {
        this.contactNumbers.Add(newNumber);
    }
    public void changeEmail(string newEmail)
    {
        this.contactEmail = newEmail;
    }
    
    public void searchEmployee()
    {
    //ni idea que poner aca
    }
    public void AddQualification(Qualification calificacion){
        this.Reviews.Add(calificacion);
    }
    public void Qualify(Qualification calificacion, Employee receptor)
    {
        receptor.AddQualification(calificacion);
    }

    public string searchOffer(string cat)
    {
        this.SearchCategory = cat;
        return this.SearchCategory;
    }
    private string Hire;

    /// <summary>
    /// Este metodo lo hice para probar como sería contratar un empleado. Si la oferta es igual a la demanda, lo podría contratar
    /// </summary>
    /// <param name="emp"> El empleado que realizó la oferta </param>
    /// <param name="dir"> El empleador que buscó la oferta </param>
    /// <returns>"Hired" o "Not hired" comparando el metodo searchOffer de Employer y makeOffer de Employee.
    
    public void hireEmployee(Employee emp, Employer dir)
    {
        
        if (dir.searchOffer(this.SearchCategory) == emp.makeOffer(emp.ServiceCategory))
        {   
            System.Console.WriteLine("Do you want to hire {0}?\nY => Yes \nN => No ", emp.getName());
            Hire = System.Console.ReadLine();
            Hire.ToLower();
            if (Hire == "y")
            {
                System.Console.WriteLine("Hired");
                emp.hired = true;
            }
            else 
            {
                System.Console.WriteLine("Not hired");
            }
        }
        else
        {
            System.Console.WriteLine("Not hired");
            emp.hired = false;
        }
    }

    
}
