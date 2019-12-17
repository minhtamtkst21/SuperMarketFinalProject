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
        public void AddCart(string name,int Id_Item, int priceunit, int quantity, int total)
        {
            var cart = new Cart();
            cart.Name = name;
            cart.PriceUnit = priceunit;
            cart.Quantity = quantity;
            cart.Total = total;
            cart.Id_item = Id_Item;

            db = new MyDataEntities();
            db.Carts.Add(cart);
            db.SaveChanges();
        }
        public void DeleteCart(int id)
        {
            db = new MyDataEntities();
            var cart = db.Carts.Find(id);

            db.Carts.Remove(cart);
            db.SaveChanges();
        }
        public void UpdateCart(int id,int quantity)
        {
            db = new MyDataEntities();
            var cart = db.Carts.Find(id);
            cart.Quantity = quantity;

            db.Entry(cart).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
