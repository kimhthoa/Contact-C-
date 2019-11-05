using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaiKiemTra01.DAL
{
    class ChiTietdb
    {
        public string ten { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }
        public string manhom { get; set; }
        public string diachi { get; set; }
        public static List<ChiTietdb> getListFromFile(string pathData, string manhom)
        {
            var rline = File.ReadLines(pathData);
            var listChiTiet = new List<ChiTietdb>();
            foreach (var rs in rline)
            {
                var rd = rs.Split(new char[] { '#' });
                var chitietdanhba = new ChiTietdb
                {
                    ten = rd[1],
                    email = rd[2],
                    sdt = rd[3],
                    manhom = rd[4],
                    diachi = rd[5]
                };
                if (chitietdanhba.manhom == manhom)
                    listChiTiet.Add(chitietdanhba);
            }
            return listChiTiet;
        }
    }
}
