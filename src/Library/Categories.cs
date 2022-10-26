using System;
using System.Collections.Generic;

namespace Library;

public class Category {
    private List<string> category { get; set; }= new List<string>();

    public Category() {
        Populate();
    }
    public void Add(Category cat, string category){
        cat.category.Add(category);
    }

    public void getCategories() {
        foreach (string item in this.category)
        {
            System.Console.WriteLine(item);
        }
    }

    public void Populate() {
        String[] init = new String[]
        {"Aerospace Engineer",
        "Electrical Engineer",
        "Chemical Engineer",
        "Nuclear Engineer",
        "Bank Manager",
        "Mechanic",
        "Chef"};
        this.category.AddRange(init);
    }
}