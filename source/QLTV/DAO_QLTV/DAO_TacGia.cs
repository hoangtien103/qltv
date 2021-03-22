using DTO_QLTV;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO_QLTV
{
    public class DAO_TacGia : DBConnect
    {
        public DataTable getTacGia()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TACGIA Where ISDELETED = 0", _conn);
            DataTable dtTacGia = new DataTable();
            da.Fill(dtTacGia);
            return dtTacGia;
        }

        #region Common Query

        string insertCommon(string authorName, string birthDate, int gender)
        {
            string sql = string.Format("INSERT INTO TACGIA (TENTG,NGAYSINH,GIOITINH) VALUES (N'{0}', N'{1}', {2})", authorName, birthDate, gender);
            return sql;
        }

        string updateCommon(string authorName, string birthDate, int gender, int authorId)
        {
            string sql = string.Format(
                "UPDATE TACGIA " +
                "SET TENTG = N'{0}', NGAYSINH = N'{1}', GIOITINH = {2} " +
                "WHERE MATG = {3}", authorName, birthDate, gender, authorId
            ); 
            return sql;
        }

        string deleteCommon(int authorId)
        {
            string sql = string.Format("UPDATE TACGIA SET ISDELETED = 1 WHERE MATG = {0}", authorId);
            return sql;
        }

        #endregion

        // Insert Category
        public bool insertTacGia(DTO_Tacgia TG)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand(this.insertCommon(TG.TenTG, TG.NgaySinh, TG.GioiTinh), _conn);

                int rowNumber = cmd.ExecuteNonQuery();
                if (rowNumber > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        // Update Category
        public bool updateTacgia(DTO_Tacgia TG)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand(updateCommon(TG.TenTG, TG.NgaySinh, TG.GioiTinh, TG.MaTG), _conn);

                int rowNumber = cmd.ExecuteNonQuery();
                if (rowNumber > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        // Delete category
        public bool deleteTacgia(int MaTG)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand(deleteCommon(MaTG), _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
    }
}

