using System.Collections;
using System.Collections.Generic;
namespace Library;

/// <summary>
/// Uso la interfaz IMakeOffer para devolver un string que se usa en hireEmployee
/// </summary>
public class Employee : IMakeOffer  // Pensaba agregarle acá una herencia a User ya que tienen casi los mismos atributos que Employer
{
    //datos personales
    public string displayName;
    private string Name;
    private string LastName;
    public string Location;
    //info de contacto
    public ArrayList ContactNumbers = new ArrayList();
    public string contactEmail;
    public List<Qualification> Reviews = new List<Qualification>();

    /// <summary>
    /// Creo una lista HistoricalContracts para almacenar los contrator que tuvo el empleado
    /// </summary>
    /// <typeparam name="Contract"></typeparam>
    /// <returns> un string con la información de fecha de inicio, final y rubro </returns>
    
    public List<Contract> HistoricalContracts {get; set;}= new List<Contract>();
    public string ServiceCategory;
    public bool hired {get;set;}

    public Employee (string Name, string LastName, string Location, string PhoneNumber, string ContactEmail)
    {
        this.displayName = Name;
        this.Name = Name;
        this.LastName = LastName;
        this.Location = Location;
        this.ContactNumbers.Add(PhoneNumber);
        this.contactEmail = ContactEmail;
    }
    public void changeUsername(string newName)
    {
        this.displayName = newName;
    }
    public void addNumber(string newNumber)
    {
        this.ContactNumbers.Add(newNumber);
    }
    public void changeEmail(string newEmail)
    {
        this.contactEmail = newEmail;
    }
    
    public void AddQualification(Qualification calificacion){
        this.Reviews.Add(calificacion);
    }
    public void Qualify(Qualification calificacion, Employer receptor)
    {
        receptor.AddQualification(calificacion);
    }

    /// <summary>
    /// Metodo para agregar un contrato una vez que el empleado fue contratado. En este metodo no se necesita agregar un contrato anterior
    /// Lo genera automatico
    /// </summary>
    /// <param name="employee"> empleado que genera un contrato </param>

    
    public void addContracts(Employee employee)
    {
        if (employee.hired){
            Contract contract = new Contract("25/10/2022","-",employee.makeOffer(ServiceCategory));
            employee.HistoricalContracts.Add(contract);
        }
        
    }
    

    

    /// <summary>
    /// Metodo para agregar contratos a la lista HistoricalContracts. Para este metodo, los contratos se agregan manualmente
    /// </summary>
    /// <param name="contract"> contrato creado en la clase Contract </param>
    /// <param name="employee"> empleado que cumple ese contrato </param>
    public void addContracts(Contract contract, Employee employee){
        employee.HistoricalContracts.Add(contract);
    }
    
    public void printContracts(){
        foreach(Contract a in HistoricalContracts){
            System.Console.WriteLine("{0} started work in {1} until {2} as a {3}",this.Name, a.initDate, a.endDate, a.jobs);
        }
    }

    /// <summary>
    /// Metodo para realizar una oferta
    /// </summary>
    /// <param name="cat"> describe a que rubro corresponde la oferta </param>
    /// <returns> devuelve un string que se compara con searchOffer de la clase Employer </returns>
    
    public string makeOffer(string cat)
    {
        this.ServiceCategory = cat;
        return this.ServiceCategory;
    }
    
    public string getName()
    {
        return this.Name;
    }
}
