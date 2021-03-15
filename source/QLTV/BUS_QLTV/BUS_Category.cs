using DAO_QLTV;
using DTO_QLTV;
using System.Data;

namespace BUS_QLTV
{
    public class BUS_Category
    {
        DAO_Category daoCategory = new DAO_Category();

        // Get dât to Grid 
        public DataTable getCategory()
        {
            return daoCategory.getCategory();
        }

        public bool insertCategory(DTO_Category category)
        {
            return daoCategory.insertCategory(category);
        }

        public bool updateCategory(DTO_Category category)
        {
            return daoCategory.updateCategory(category);
        }

        public bool deleteCategory(int categoryId)
        {
            return daoCategory.deleteCategory(categoryId);
        }
    }
}
