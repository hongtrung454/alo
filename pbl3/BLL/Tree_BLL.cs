using pbl3.DAL;
using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.BLL
{
    public class Tree_BLL
    {
        private static Tree_BLL instance;
        public static Tree_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Tree_BLL();
                }
                return instance;
            }

        }
        public List<TreeShort_DTO> GetTrees()
        {
            List<TreeShort_DTO> treeShort = new List<TreeShort_DTO>();
            treeShort = (Tree_DAL.Instance.GetTrees()).Select(item => new TreeShort_DTO { TreeID = item.TreeID, TreeName = item.TreeName, TreeDescription = item.TreeDescription }).ToList();
            return treeShort;
        }
        public Tree getTreeByID(String id)
        {
            return Tree_DAL.Instance.getTreebyID(id);
        }
        public bool InsertTree(Tree tree)
        {
            Tree_DAL.Instance.InsertTree(tree);
            return true;
        }
        public bool DeleteTree(List<int> ids)
        {
            Tree_DAL.Instance.DeleteTree(ids);
            return true;
        }
        public bool UpdateTree(Tree updatedTree)
        {
            Tree_DAL.Instance.UpdateTree(updatedTree);
            return true;
        }
        public List<TreeShort_DTO> GetSearchTrees(string searchTerm)
        {
            List<TreeShort_DTO> treeShort = new List<TreeShort_DTO>();
            treeShort = (Tree_DAL.Instance.SearchData(searchTerm)).Select(item => new TreeShort_DTO { TreeID = item.TreeID, TreeName = item.TreeName, TreeDescription = item.TreeDescription }).ToList();
            return treeShort;
        }
    }
}

