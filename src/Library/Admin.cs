using System;

namespace Library;

public class Admin
{
<<<<<<< HEAD
    
    
=======
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
>>>>>>> master

   public void removeOffer()
   {
        OffersManager.Instance.removeOffer();
   }
}