using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace pbl3.DAL
{
    public class UserLocation_DAL
    {
        private static UserLocation_DAL instance;
        public static UserLocation_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserLocation_DAL();
                }
                return instance;
            }
            private set { }
        }
        public List<UserLocation> GetUserLocations()
        {
            List<UserLocation> Location = new List<UserLocation>();
            using (HoTroCayXanhEntities db = new HoTroCayXanhEntities())
            {
                Location = db.UserLocations.ToList();
            }
            return Location;
        }
    }
}
