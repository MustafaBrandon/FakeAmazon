using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheAmazon.Models
{
    public interface IPurchasheRepository
    {
        IQueryable<Purchase> Purchases { get; }

        void SavePurchase(Purchase purchase);
    }
}
