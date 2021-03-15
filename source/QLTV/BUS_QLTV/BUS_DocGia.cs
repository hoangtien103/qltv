using DAO_QLTV;
using DTO_QLTV;
using System.Data;

namespace BUS_QLTV
{
    public class BUS_DocGia
    {
        DAO_DocGia daoTG = new DAO_DocGia();

        public DataTable getDocGia()
        {
            return daoTG.getDocGia();
        }

        public bool insertdocgia(DTO_DocGia docgia)
        {
            return daoTG.insertDocGia(docgia);
        }

        public bool updateDocGia(DTO_DocGia docgia)
        {
            return daoTG.updateDocGia(docgia);
        }

        public bool deleteDocGia(int MaTG)
        {
            return daoTG.deleteDocGia(MaTG);
        }
    }
}
