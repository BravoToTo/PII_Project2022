using System.Collections;
using System.Collections.Generic;
namespace Library;

public class Employer:IUser
{
    //datos personales
    public string displayName;
    private string Name;
    private string LastName;
    public string Location;
    //info de contacto
    public string contactNumber;
    public string contactEmail;
    public List<Qualification> Reviews = new List<Qualification>();

    public Employer (string Name, string LastName, string Location, string contactNumber, string contactEmail)
    {
        this.displayName = Name;
        this.Name = Name;
        this.LastName = LastName;
        this.Location = Location;
        this.contactNumber=contactNumber;
        this.contactEmail = contactEmail;
        
    }
    public void changeUsername(string newName)
    {
        this.displayName = newName;
    }
    public void changeNumber(string newNumber)
    {
        this.contactNumber=newNumber;
    }
    public void changeEmail(string newEmail)
    {
        this.contactEmail = newEmail;
    }
  
    }



