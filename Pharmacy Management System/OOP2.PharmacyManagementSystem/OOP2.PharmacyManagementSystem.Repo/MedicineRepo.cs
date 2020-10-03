using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OOP2.PharmacyManagementSystem.Data;
using OOP2.PharmacyManagementSystem.Entity;


namespace OOP2.PharmacyManagementSystem.Repo
{
    public class MedicineRepo
    {
        private string id;
        private string Id
        {
            get { return id; }
            set { this.id = "m-" + value; }
        }

        public string AutoNextMedicineIdValue()
        {
            var dt = DataAccess.GetDataTable("select * from medicine");

            if (dt == null || dt.Rows.Count == 0)
            {
                this.Id = "0001";
                return Id;
            }

            else
            {
                string value = dt.Rows[dt.Rows.Count - 1]["id"].ToString();
                string[] id = value.Split('-');
                int number = Convert.ToInt32(id[1]);
                this.Id = (++number).ToString("d4");
                return Id;
            }
        }

        private Medicine ConvertToEntity(DataRow row)
        {
            if(row == null)
            {
                return null;
            }

            var m = new Medicine();
            m.id = row["id"].ToString();
            m.name = row["name"].ToString();
            m.company = row["company"].ToString();
            m.quantity = Convert.ToInt32(row["quantity"].ToString()) ;
            //m.price = Convert.ToDouble(row["price"].ToString()) ;
            m.price = Double.Parse(row["price"].ToString());

            return m;
        }
        public List<Medicine> GetAll(string sql= "select * from medicine")
        {
            var medicineList = new List<Medicine>();
            //var sql = "select * from medicine";
            var dt = DataAccess.GetDataTable(sql);

            for(int index = 0; index<dt.Rows.Count; index++)
            {
                Medicine m = ConvertToEntity(dt.Rows[index]);
                medicineList.Add(m);
            }
            return medicineList;
        }

        public bool SellingUpdate(Medicine medi)
        {
            string sql = "select * from medicine where id='"+medi.id+"'";
            var dt = DataAccess.GetDataTable(sql);
            int totalQuantity = Convert.ToInt32(dt.Rows[0][3]);
            int remainingQuantity = totalQuantity - medi.quantity;

            if (remainingQuantity >= 0)
            {
                string query = "update medicine set quantity = " + remainingQuantity + " where id = '" + medi.id + "'";

                int count = DataAccess.ExecuteUpdateQuery(query);

                if (count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public bool SoldItemUpdate(Medicine medi)
        {
            try
            {
                string sql = "select * from medicine where name='" + medi.name + "'";
                var dt = DataAccess.GetDataTable(sql);
                int quantity = Convert.ToInt32(dt.Rows[0][3]);
                int totalQuantity = quantity + medi.quantity;

                string query = "update medicine set name='" + medi.name + "', company='" + medi.company + "',quantity=" + totalQuantity + ",price=" + medi.price + " where name='" + medi.name + "'";
                int count = DataAccess.ExecuteUpdateQuery(query);

                if (count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Save(Medicine medi)
        {
            try
            {
                string query = "select * from medicine where id='"+medi.id+"'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "insert into medicine values('"+medi.id+"','"+medi.name+"','"+medi.company+"',"+medi.quantity+","+medi.price+")";
                }

                else
                {
                    query = "update medicine set name='" + medi.name + "',company='" + medi.company + "',quantity=" + medi.quantity + ",price=" + medi.price + " where id='" + medi.id + "'";
                }

                int count = DataAccess.ExecuteUpdateQuery(query);

                if(count>=1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Delete(string mediId)
        {
            string query = "select * from medicine where id='"+mediId+"'";

            var dt = DataAccess.GetDataTable(query);
            if(dt==null || dt.Rows.Count==0)
            {
                return false;
            }

            query = "delete medicine where id='"+mediId+"'";

            int count = DataAccess.ExecuteUpdateQuery(query);
            if(count>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
