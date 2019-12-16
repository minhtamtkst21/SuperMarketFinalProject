using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Producers
{
    class ProducerManagement
    {
        private MyDataEntities db;
        public Producer[] getProducer()
        {
            db = new MyDataEntities();
            return db.Producers.ToArray();
        }
        public Producer getProducers(int id)
        {
            db = new MyDataEntities();
            return db.Producers.Find(id);
        }
        public void AddProducer(string code, string name)
        {
            var producer = new Producer();
            producer.Code = code;
            producer.Name = name;

            db = new MyDataEntities();
            db.Producers.Add(producer);
            db.SaveChanges();
        }
        public void UpdateProducer(string id, string name)
        {

            var producer = new Producer();
            producer.Name = name;

            db = new MyDataEntities();
            db.Entry(producer).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteProducer(int id)
        {
            var producer = db.Producers.Find(id);

            db = new MyDataEntities();
            db.Producers.Remove(producer);
            db.SaveChanges();
        }
    }

}
