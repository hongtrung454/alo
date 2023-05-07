using pbl3.DAL;
using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.BLL
{
    public class Planting_BLL
    {
        private static Planting_BLL instance;
        public static Planting_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Planting_BLL();
                }
                return instance;
            }

        }
        public bool InsertPlanting(Planting info)
        {
            PlantingDAL.Instance.InsertPlanting(info);
            return true;
        }

    }
}
