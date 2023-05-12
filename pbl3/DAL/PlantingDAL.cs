using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public List<UserTree_DTO> GetUserPlantings (Account acc)
        {
            using (HoTroCayXanhEntities db = new HoTroCayXanhEntities())
            {
                List<UserTree_DTO> list1 = new List<UserTree_DTO>();
                    list1 = (from c in db.Trees
                           join e in db.Plantings on c.TreeID equals e.TreeID
                           join a in db.Accounts on e.UserName equals a.UserName
                           where e.UserName == acc.UserName
                           select new UserTree_DTO{ TreeName = c.TreeName, Picture = c.Picture, TreeDescription = c.TreeDescription, TreeID = c.TreeID }).ToList();
                return list1;
            }
        }
        public bool CheckDuplicateUserTree(int _TreeID, Account acc)
        {
            using (HoTroCayXanhEntities db = new HoTroCayXanhEntities())
            {
                //    var treeid = (from c in db.Trees
                //                join e in db.Plantings on c.TreeID equals e.TreeID
                //                join a in db.Accounts on e.UserName equals a.UserName
                //                where e.UserName == acc.UserName && c.TreeID == TreeID
                //                select c).;
                bool check = false;
                foreach (Planting item in db.Plantings)
                {
                    if (item.TreeID == _TreeID && item.UserName == acc.UserName)
                        check = true;
                }
                    return check;


            }
        }
        public Planting GetOnePlanting(Account acc, int TreeID)
        {
            Planting planting = new Planting();
            using (HoTroCayXanhEntities db = new HoTroCayXanhEntities())
            {
                planting = db.Plantings.FirstOrDefault(obj => obj.TreeID == TreeID && obj.UserName == acc.UserName);
            }
            return planting;
        }
        public void DeleteTreePlanting(string username, int TreeID)
        {
            using (HoTroCayXanhEntities dbContext = new HoTroCayXanhEntities())
            {
                Planting plantingTree = new Planting();
                plantingTree = dbContext.Plantings.FirstOrDefault(obj => obj.TreeID == TreeID && obj.UserName == username);
                dbContext.Plantings.Remove(plantingTree);
                dbContext.SaveChanges();
            }
        }
        public bool UpdateTreePlanting(Planting _planting)
        {
            using (HoTroCayXanhEntities dbContext = new HoTroCayXanhEntities())
            {
                // Tìm đối tượng cần cập nhật trong cơ sở dữ liệu
                Planting treePlantingNeedToUpdate = dbContext.Plantings.FirstOrDefault(obj => obj.TreeID == _planting.TreeID && obj.UserName == _planting.UserName);
                
                if (treePlantingNeedToUpdate != null)
                {
                    // Cập nhật thuộc tính của đối tượng đã tồn tại
                    treePlantingNeedToUpdate.NumberPlanted = _planting.NumberPlanted;
                    treePlantingNeedToUpdate.Water = _planting.Water;
                    treePlantingNeedToUpdate.Fertilize = _planting.Fertilize;
                    treePlantingNeedToUpdate.DatePlanted = _planting.DatePlanted;
                    // ...
                    // Lưu các thay đổi vào cơ sở dữ liệu
                    dbContext.SaveChanges();

                    // Thực hiện các hành động khác sau khi cập nhật thành công
                    // ...
                    
                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                    return false;
                }
                return true;
            }
        }
    }
}
