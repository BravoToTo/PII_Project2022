using System;
using System.Collections.Generic;

namespace Library;

public class Category {

    public string CategoryName;
    public Category(string tipoCategoria) {
        this.CategoryName=tipoCategoria;
    }



    /*public void Add(Category cat, string category){
        cat.Categories.Add(category);
    }*/

    /*public void getCategories() {
        foreach (string item in this.Categories)
        {
            System.Console.WriteLine(item);
        }
    }*/

    /*public void Populate() {
        String[] init = new String[]
        {"Aerospace Engineer",
        "Electrical Engineer",
        "Chemical Engineer",
        "Nuclear Engineer",
        "Bank Manager",
        "Mechanic",
        "Chef"};
        this.Categories.AddRange(init);
    }*/
}