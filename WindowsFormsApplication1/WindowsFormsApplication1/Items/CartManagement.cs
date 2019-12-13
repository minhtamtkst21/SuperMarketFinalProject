using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Carts
{
    class CartManagement
    {
        private MyDataEntities db;
        public Cart[] getCart()
        {
            db = new MyDataEntities();
            return db.Carts.ToArray();
        }
        public Cart getCarts(int id)
        {
            db = new MyDataEntities();
            return db.Carts.Find(id);
        }
        public void AddCart(string name, int priceunit, int quantity, int total)
        {
            var cart = new Cart();
            cart.Name = name;
            cart.PriceUnit = priceunit;
            cart.Quantity = quantity;
            cart.Total = total;
        }
        public void DeleteCart(int id)
        {
            var cart = db.Carts.Find(id);

            db.Carts.Remove(cart);
        }
    }
}
