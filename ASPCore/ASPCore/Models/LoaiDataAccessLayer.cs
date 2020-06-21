using ASPCore.ADONETLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Validation trước khi chạy store luôn
/// Viết store nằm trên database, còn gọi store thì nhanh
/// </summary>
namespace ASPCore.Models
{
    public class LoaiDataAccessLayer
    {
        public IEnumerable<Loai> GetLoais()
        {
            List<Loai> dsLoai = new List<Loai>();
            using (var dtLoai = DataProvider.SelectData("spLayTatCaLoai",
           CommandType.StoredProcedure, null))
            {
                foreach (DataRow row in dtLoai.Rows)
                {
                    Loai lo = new Loai();
                    lo.MaLoai = Convert.ToInt32(row["MaLoai"]);
                    lo.TenLoai = row["TenLoai"].ToString();
                    lo.MoTa = row["MoTa"].ToString();
                    lo.Hinh = row["Hinh"].ToString();
                    dsLoai.Add(lo);
                }
            }
            return dsLoai;
        }

        public int AddLoai(Loai lo)
        {
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("MaLoai", SqlDbType.Int);
            pa[0].Direction = ParameterDirection.Output;
            pa[1] = new SqlParameter("TenLoai", lo.TenLoai);
            pa[2] = new SqlParameter("MoTa", lo.MoTa);
            pa[3] = new SqlParameter("Hinh", lo.Hinh);
            DataProvider.ExcuteNonQuery("spThemLoai", CommandType.StoredProcedure, pa);

            return (int) pa[0].Value;
        }

        public void UpdateLoai(Loai lo)
        {
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("MaLoai", lo.MaLoai);
            pa[1] = new SqlParameter("TenLoai", lo.TenLoai);            
            pa[2] = new SqlParameter("MoTa", lo.MoTa);
            pa[3] = new SqlParameter("Hinh", lo.Hinh);
            DataProvider.ExcuteNonQuery("spSuaLoai", CommandType.StoredProcedure, pa);
        }
        public Loai GetLoai(int id)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("MaLoai", id);
            DataTable dtLoai = DataProvider.SelectData("spLayLoai",
           CommandType.StoredProcedure, pa);
            if (dtLoai.Rows.Count > 0)
            {
                var row = dtLoai.Rows[0];
                return new Loai()
                {
                    MaLoai = Convert.ToInt32(row["MaLoai"]),
                    TenLoai = row["TenLoai"].ToString(),
                    MoTa = row["MoTa"].ToString(),
                    Hinh = row["Hinh"].ToString()
                };
            }
            return null;
        }

        public void DeleteLoai(int id)
        {        
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("MaLoai", id);
            DataProvider.ExcuteNonQuery("spXoaLoai", CommandType.StoredProcedure, pa);
        }
    }
}
