using ShoppingCartArchitecture.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Repository.UnitOfWorks
{
   public class BaseRepository
    {
      public  ShoppingCartOldDBContext Context;
        
public BaseRepository()
        {
            Context = new ShoppingCartOldDBContext();
        }
    }
}
