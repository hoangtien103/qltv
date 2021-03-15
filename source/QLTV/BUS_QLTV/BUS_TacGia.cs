using DAO_QLTV;
using DTO_QLTV;
using System.Data;

namespace BUS_QLTV
{
    public class BUS_TacGia
    {
        DAO_TacGia daoTG = new DAO_TacGia();

        public DataTable getTacGia()
        {
            return daoTG.getTacGia();
        }

        public bool insertTacGia(DTO_Tacgia tacgia)
        {
            return daoTG.insertTacGia(tacgia);
        }

        public bool updateTacGia(DTO_Tacgia tacgia)
        {
            return daoTG.updateTacgia(tacgia);
        }

        public bool deleteTacGia(int MaTG)
        {
            return daoTG.deleteTacgia(MaTG);
        }
    }
}
