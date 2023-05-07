using pbl3.DAL;
using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.BLL
{
    public class UserLocation_BLL
    {
        private static UserLocation_BLL instance;
        public static UserLocation_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserLocation_BLL();
                }
                return instance;
            }
            private set { }
        }
        public List<CBBItem> GetCBBItems()
        {
            List<CBBItem> listcbb = new List<CBBItem>();
            foreach ( UserLocation a in UserLocation_DAL.Instance.GetUserLocations() )
            {
                listcbb.Add(new CBBItem { Value = a.UserLocationID, Text = a.LocationName });
            }
            return listcbb;
        }
        public string GetLocationNameByUserLocationId(int id)
        {
            foreach(UserLocation ul in UserLocation_DAL.Instance.GetUserLocations())
            {
                if(ul.UserLocationID == id)
                {
                    return ul.LocationName;
                }
            }
            return null;
        }
    }
}
