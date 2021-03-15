namespace DTO_QLTV
{
    public class DTO_DocGia
    {
        private int MATHE;
        private string HOTENSV;
        private int NIENKHOA;
        private int GIOITINH;
        private int ISDELETED;

        public int MaDG
        {
            get => MATHE;

            set
            {
                MATHE = value;
            }
        }

        public string TenDG
        {
            get => HOTENSV;

            set
            {
                HOTENSV = value;
            }
        }

        public int NienKhoa
        {
            get => NIENKHOA;

            set
            {
                NIENKHOA = value;
            }
        }

        public int GioiTinh
        {
            get => GIOITINH;

            set
            {
                GIOITINH = value;
            }
        }

        public int IsDeleted
        {
            get => ISDELETED;

            set
            {
                ISDELETED = value;
            }
        }

        /* === Constructor === */
        public DTO_DocGia()
        {

        }

        public DTO_DocGia(int id, string name, int nk, int gt)
        {
            this.MATHE = id;
            this.HOTENSV = name;
            this.NIENKHOA = nk;
            this.GioiTinh = gt;
        }
    }
}
