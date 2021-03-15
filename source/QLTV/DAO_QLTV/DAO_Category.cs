using DTO_QLTV;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO_QLTV
{
    public class DAO_Category : DBConnect
    {
        DTO_Category category = new DTO_Category();

        // Insert common
        string insertCommon(string table, string categoryName, string note)
        {
            string sql = string.Format("INSERT INTO {0} VALUES (N'{1}', N'{2}')", table, categoryName, note);
            return sql;
        }

        // Update common
        string updateCommon(string table, string where, string category, string note, int categoryId)
        {
            string sql = string.Format(
                    "UPDATE {0} " +
                    "SET THELOAI = N'{2}', NOTE = N'{3}'" +
                    "WHERE {1} = {4}",
                    table,
                    where,
                    category, 
                    note, 
                    categoryId);
            return sql;
        }

        // Delete common
        string deleteCommon(int categoryId)
        {
            string sql = string.Format("DELETE FROM LOAISACH WHERE MALOAI = {0}", categoryId);
            return sql;
        }

        public DataTable getCategory()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAISACH", _conn);
            DataTable dtCategory = new DataTable();
            da.Fill(dtCategory);
            return dtCategory;
        }

        // Insert Category
        public bool insertCategory(DTO_Category category)
        {
            try
            {
                _conn.Open();
                string sql = this.insertCommon("LOAISACH", category.category, category.note);

                SqlCommand cmd = new SqlCommand(sql, _conn);

                int rowNumber = cmd.ExecuteNonQuery();
                if(rowNumber > 0)
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
        public bool updateCategory(DTO_Category category)
        {
            try
            {
                _conn.Open();
                string sql = updateCommon("LOAISACH", "MALOAI", category.category, category.note, category.categoryId);

                SqlCommand cmd = new SqlCommand(sql, _conn);

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
        public bool deleteCategory(int categoryId)
        {
            try
            {
                _conn.Open();
                string sql = deleteCommon(categoryId);

                SqlCommand cmd = new SqlCommand(sql, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

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
