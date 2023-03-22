using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLiBanThuoc.DTO;

namespace QuanLiBanThuoc.DAO
{
    public partial  class UnitDAO
    {
        public static List<Unit> GetData()
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
                return db.Units.ToList();
            }
        }

     

        public static void InsertUnit(Unit unit)
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
                Unit checkID = db.Units.FirstOrDefault(u => u.Code_Unit == unit.Code_Unit);
                if (checkID == null)
                {
                    db.Units.Add(unit);
                    db.SaveChanges();
                    XtraMessageBox.Show("Thêm Thành Công!", "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Thêm không thành công! ", "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public static void UpdateUnit(Unit unit)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();
            Unit checkId = db.Units.FirstOrDefault(s => s.Code_Unit == unit.Code_Unit);


            if (checkId != null)
            {
                checkId.Code_Unit = unit.Code_Unit;
                checkId.Name_Unit = unit.Name_Unit;

                db.SaveChanges();
                XtraMessageBox.Show("Cập Nhật Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Cập Nhật không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }


        }
        public static void DeleteUnit(string id)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();

            Unit checkId = db.Units.FirstOrDefault(s => s.Code_Unit == id);

            if (checkId != null)
            {
                db.Units.Remove(checkId);
                db.SaveChanges();
                XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else
            {
                XtraMessageBox.Show("Xóa không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
        }


    }
}
