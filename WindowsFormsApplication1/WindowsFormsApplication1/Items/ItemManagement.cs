using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Items
{
    class ItemManagement
    {
        private MyDataEntities db;
        public Item[] getItem()
        {
            db = new MyDataEntities();
            return db.Items.ToArray();
        }
        public Item getItems(int id)
        {
            db = new MyDataEntities();
            return db.Items.Find(id);
        }
        public void AddItem(string code, string name, int producer, int quantity, int price)
        {
            var item = new Item();
            item.Code = code;
            item.Name = name;
            item.ProducerID = producer;
            item.Amount = quantity;
            item.Price = price;

            db.Items.Add(item);
            db.SaveChanges();
        }
        public void UpdateItem(int id, string name, int producer, int quantity, int price)
        {
            var item = new Item();
            item.Name = name;
            item.ProducerID = producer;
            item.Amount = quantity;
            item.Price = price;

            db.Entry(item).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteItem(int id)
        {
            var item = db.Items.Find(id);

            db.Items.Remove(item);
        }
    }
}
