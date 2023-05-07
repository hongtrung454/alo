using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.DAL
{
    public class PlantingDAL
    {
        private static PlantingDAL instance;
        public static PlantingDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PlantingDAL();
                }
                return instance;
            }
            private set { }
        }
        public bool InsertPlanting(Planting info)
        {
            using (HoTroCayXanhEntities db = new HoTroCayXanhEntities())
            {
                db.Plantings.Add(info);
                db.SaveChanges();
            }    
            return true;

        }
    }
}
