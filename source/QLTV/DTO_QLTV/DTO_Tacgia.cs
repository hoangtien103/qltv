namespace DTO_QLTV
{
    public class DTO_Tacgia
    {
        private int MATG;
        private string TENTG;
        private string NGAYSINH;
        private int GIOITINH;

        //public void setMaTG(int _MATG)
        //{
        //    this.MATG = _MATG;
        //}

        //public int getMaTG()
        //{
        //    return MATG;
        //}

        //public void setTenTG(string _TENTG)
        //{
        //    this.TENTG = _TENTG;
        //}

        //public string getTenTG()
        //{
        //    return TENTG;
        //}

        //public void setNS(string _NGAYSINH)
        //{
        //    this.NGAYSINH = _NGAYSINH;
        //}

        //public string getNS()
        //{
        //    return NGAYSINH;
        //}

        //public void setMaTG(bool _GT)
        //{
        //    this.GIOITINH = _GT;
        //}

        //public bool getGT()
        //{
        //    return GIOITINH;
        //}

        public int MaTG
        {
            get => MATG;

            set
            {
                MATG = value;
            }
        }

        public string TenTG
        {
            get => TENTG;

            set
            {
                TENTG = value;
            }
        }

        public string NgaySinh
        {
            get => NGAYSINH;

            set
            {
                NGAYSINH = value;
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

        /* === Constructor === */
        public DTO_Tacgia()
        {

        }

        public DTO_Tacgia(int id, string name, string ns, int gt)
        {
            this.MaTG = id;
            this.TenTG = name;
            this.NgaySinh = ns;
            this.GioiTinh = gt;
        }
    }
}
