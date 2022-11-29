using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Library;

public class Employer : User, IUser
{
<<<<<<< HEAD
    public List<Qualification> Reviews = new List<Qualification>();

    public Employer (string name, string lastname, string id, string rol, string location, string contactnumber, string contactemail) 
    : base(name, lastname, id, rol, location, contactemail, contactnumber)
=======
    public Employer (string name, string lastname, string id, string location, string contactnumber, string contactemail) 
    : base(name, lastname, id, location, contactemail, contactnumber)
>>>>>>> master
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new UserException("Nombre inválido");
        }
        else if (string.IsNullOrEmpty(lastname))
        {
            throw new UserException("Apellido inválido");
        }
        else if (string.IsNullOrEmpty(id))
        {
            throw new UserException("ID inválido");
        }
        else if (string.IsNullOrEmpty(location))
        {
            throw new UserException("Localización inválido");
        }
        else if (string.IsNullOrEmpty(contactnumber))
        {
            throw new UserException("Numero inválido");
        }
        else if (string.IsNullOrEmpty(contactemail))
        {
            throw new UserException("Email inválido");
        }
        else
        {   
            this.Name = name;
            this.LastName = lastname;
            this.ID = id;
            this.Location = location;
            this.contactNumber = contactnumber;
            this.contactEmail = contactemail;
        }
    }
    // ADD
    public void searchOffers (string category)
    {
<<<<<<< HEAD
    //ni idea que poner aca
    }
    public void AddQualification(Qualification calificacion){
        this.Reviews.Add(calificacion);
    }
    public void Qualify(Qualification calificacion, Employee receptor)
=======
       // El empleador debe recibir una lista de ofertas y seleccionar uno para contratar un employee.
       var offers = OffersManager.Instance.getOffersCategories(category);
       int counter = 1;
       //Elegir que oferta se acepta
       // mi idea acá es elegir de la lista de offers una oferta, sacarla de esa lista, y que ese offer al estar relacionado
       // con un employee, ya lo pueda contratar.
       foreach (Offer offer in offers)
       {
            System.Console.WriteLine("{0} - {1} => {2}", counter, offer.Category, offer.employee.Name);
            counter++;
       }
       hireEmployee(offers);
    }
    public void hireEmployee (List<Offer> offers)
>>>>>>> master
    {
        System.Console.WriteLine("Seleccione un empleado a contratar:");

        // Comparo lo que se ingresa por consola y si es igual al nombre del employee lo contrata
        var offer = offers.ElementAt(int.Parse(System.Console.ReadLine())-1);
        {
            System.Console.WriteLine("{0} contratado", offer.Category);
            offer.employee.hired = true;
            
            ContractManager.Instance.createContracts(1, offer.Category, offer.employee, this);
        }
    }
}
    

    
    



