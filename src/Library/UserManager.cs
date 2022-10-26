using System;
using System.Collections;
using System.Collections.Generic;
namespace Library;

public sealed class UserManager
{
    private static UserManager instance;

    public static UserManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new UserManager();
            }

            return instance;
        }
    }
    public List<IUser> Users = new List<IUser>();
    private UserManager(){}

    public void CreateUser(string name, string lastname, string id, string rol, string location, string contactnumber, string contactemail) {
        if (string.Equals(rol.ToLower(), "employer"))
        {
            Users.Add(new Employer(name, lastname, id, rol, location, contactnumber, contactemail));
        } 
        else if (string.Equals(rol.ToLower(), "employee"))
        {
            Users.Add(new Employee(name, lastname, id, rol, location, contactnumber, contactemail));      
        }
        else
        {
            System.Console.WriteLine("El rol ingresado es invalido");
        }
    }

    public List<User> GetEmployees() {
        List<User> list = new List<User>();
        foreach (User item in this.Users)
        {
            if (item.Rol == "employee")
            {
                list.Add(item);
            }
        }
        return list;
    }
    public List<User> GetEmployers() {
        List<User> list = new List<User>();
        foreach (User item in this.Users)
        {
            if (item.Rol == "employer")
            {
                list.Add(item);
            }
        }
        return list;
    }
}
