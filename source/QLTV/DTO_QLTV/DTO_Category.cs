namespace DTO_QLTV
{
    public class DTO_Category
    {
        private int _categoryId;
        private string _categoryName;
        private string _note;

        /* ======== GETTER/SETTER ======== */

        public int categoryId
        {
            get => _categoryId;

            set
            {
                _categoryId = value;
            }
        }

        public string category
        {
            get => _categoryName;

            set
            {
                _categoryName = value;
            }
        }

        public string note
        {
            get => _note;

            set
            {
                _note = value;
            }
        }

        /* === Constructor === */
        public DTO_Category()
        {

        }

        public DTO_Category(int id, string name, string note)
        {
            this.categoryId = id;
            this.category = name;
            this.note = note;
        }
    }
}
