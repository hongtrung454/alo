using pbl3.DAL;
using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public List<UserTree_DTO> GetUserPlanting(Account acc)
        {
            List<UserTree_DTO> l1 = new List<UserTree_DTO>();
            l1 = PlantingDAL.Instance.GetUserPlantings(acc);
            return l1;
        }
        public bool CheckDuplicateUserTree(int TreeID, Account acc)
        {
            return PlantingDAL.Instance.CheckDuplicateUserTree(TreeID, acc);

        }
        public Planting GetOnePlanting(Account acc, String TreeID)
        {
            return PlantingDAL.Instance.GetOnePlanting(acc, Convert.ToInt32(TreeID));
        }
        public bool DeleteTreePlanting(string username, int TreeID)
        {
            PlantingDAL.Instance.DeleteTreePlanting(username, TreeID);
            return true;
        }
        public bool UpdateTreePlanting(Planting _planting)
        {
            return PlantingDAL.Instance.UpdateTreePlanting(_planting);

        }

    }
}
