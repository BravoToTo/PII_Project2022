using System;
using System.Collections.Generic;

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
    public List<string> Administrators = new List<string>();
   
    public void createAdmin(string ID)
    {
        this.Administrators.Add(ID);
    }
    public void addCategory(string category)
    {
        CategoriesManager.Instance.addCategory(category);
    }

  
}