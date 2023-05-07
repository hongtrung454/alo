using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3.DAL
{
    public  class Account_DAL
    {
        private static Account_DAL instance;
        public static Account_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Account_DAL();
                }
                return instance;
            }
            private set { }
        }

        public List<Account>  GetAccounts() // tra ds Account
        {
            List<Account> accounts = new List<Account>();
            using (HoTroCayXanhEntities db = new HoTroCayXanhEntities())
            {
                accounts = db.Accounts.ToList();
            }
            return accounts;
        }
        public void AddAccount(Account account) // them Account vao data
        {
            using (HoTroCayXanhEntities db = new HoTroCayXanhEntities())
            {
                db.Accounts.Add(account);
                db.SaveChanges();
                MessageBox.Show("Đăng ký tài khoản thành công!");
            }
        }

    }
}
