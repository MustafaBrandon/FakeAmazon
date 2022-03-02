using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheAmazon.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        public virtual void AddItem (Book book, int qty)
        {
            BasketLineItem line = Items.Where(p => p.Book.BookId == book.BookId).FirstOrDefault();
            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Book = book,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public virtual void RemoveItem(Book book)
        {
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }
        
        public int GetTotalQuantity()
        {
            int tot = 0;
            foreach (BasketLineItem b in Items)
            {
                tot += b.Quantity;
            }
            return tot;
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Book.Price * x.Quantity);
            return sum;
        }

        public virtual void ClearBasket()
        {
            Items.Clear();
        }
    }


    public class BasketLineItem
    {
        [Key]
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }

    }
}
