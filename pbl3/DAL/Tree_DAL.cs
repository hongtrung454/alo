using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.DAL
{
    public class Tree_DAL
    {
        private static Tree_DAL instance;
        public static Tree_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Tree_DAL();
                }
                return instance;
            }
            private set { }
        }
        public List<Tree> GetTrees() // tra ds Cay
        {
            List<Tree> trees = new List<Tree>();
            using (HoTroCayXanhEntities db = new HoTroCayXanhEntities())
            {
                trees = db.Trees.ToList();
            }
            return trees;
        }
        public Tree getTreebyID(String id)
        {
            int intID = Convert.ToInt32(id);
            Tree tree = new Tree();
            using (HoTroCayXanhEntities db = new HoTroCayXanhEntities())
            {
                tree = db.Trees.FirstOrDefault(obj => obj.TreeID == intID);
            }
            return tree;
        }
        public bool InsertTree(Tree tree)
        {
            using (HoTroCayXanhEntities db = new HoTroCayXanhEntities())
            {
                db.Trees.Add(tree);
                db.SaveChanges();
            }
            return true;
        }    
        public bool DeleteTree(List<int> ids)
        {
            using (HoTroCayXanhEntities db = new HoTroCayXanhEntities())
            {
                // Tìm danh sách đối tượng cần xóa trong cơ sở dữ liệu
                List<Tree> objectsToDelete = db.Trees.Where(obj => ids.Contains(obj.TreeID)).ToList();

                if (objectsToDelete.Count > 0)
                {
                    // Xóa danh sách đối tượng khỏi cơ sở dữ liệu
                    db.Trees.RemoveRange(objectsToDelete);
                    db.SaveChanges();

                    // Thực hiện các hành động khác sau khi xóa thành công
                    // ...
                }
            }
            return true;
        }
        public void UpdateTree(Tree updatedTree)
        {
            using (HoTroCayXanhEntities dbContext = new HoTroCayXanhEntities())
            {
                // Tìm đối tượng cần cập nhật trong cơ sở dữ liệu
                Tree treeNeedToUpdate = dbContext.Trees.FirstOrDefault(obj => obj.TreeID == updatedTree.TreeID);

                if (treeNeedToUpdate != null)
                {
                    // Cập nhật thuộc tính của đối tượng đã tồn tại
                    treeNeedToUpdate.TreeName = updatedTree.TreeName;
                    treeNeedToUpdate.TreeDescription = updatedTree.TreeDescription;
                    // ...

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    dbContext.SaveChanges();

                    // Thực hiện các hành động khác sau khi cập nhật thành công
                    // ...
                }
            }
        }
        public List<Tree> SearchData(string searchTerm)
        {
            using (HoTroCayXanhEntities dbContext = new HoTroCayXanhEntities())
            {
                // Truy vấn dữ liệu từ cơ sở dữ liệu
                List<Tree> searchData = dbContext.Trees
                    .Where(row => row.TreeName.Contains(searchTerm))
                    .ToList();

                return searchData;
            }
        }



    }
}
