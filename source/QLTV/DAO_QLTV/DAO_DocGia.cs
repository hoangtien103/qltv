using DTO_QLTV;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO_QLTV
{
    public class DAO_DocGia : DBConnect
    {
        public DataTable getDocGia()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DOCGIA Where ISDELETED = 0", _conn);
            DataTable dtTacGia = new DataTable();
            da.Fill(dtTacGia);
            return dtTacGia;
        }

        #region Common Query

        string insertCommon(string readerName, int nk, int gender)
        {
            string sql = string.Format("INSERT INTO DOCGIA VALUES (N'{0}', N'{1}', {2}, 0)", readerName, nk, gender);
            return sql;
        }

        string updateCommon(string readerName, int nk, int gender, int readerId)
        {
            string sql = string.Format(
                "UPDATE DOCGIA " +
                "SET HOTENSV = N'{0}', NIENKHOA = N'{1}', GIOITINH = {2} " +
                "WHERE MATHE = {3}", readerName, nk, gender, readerId
            ); 
            return sql;
        }

        string deleteCommon(int readerId)
        {
            string sql = string.Format("UPDATE DOCGIA SET ISDELETED = 1 FROM DOCGIA WHERE MATHE = {0}", readerId);
            return sql;
        }

        #endregion

        // Insert Category
        public bool insertDocGia(DTO_DocGia TG)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand(this.insertCommon(TG.TenDG, TG.NienKhoa, TG.GioiTinh), _conn);

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
        public bool updateDocGia(DTO_DocGia TG)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand(updateCommon(TG.TenDG, TG.NienKhoa, TG.GioiTinh, TG.MaDG), _conn);

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
        public bool deleteDocGia(int MaTG)
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

