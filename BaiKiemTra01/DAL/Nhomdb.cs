using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaiKiemTra01.DAL
{
    class Nhomdb
    {
        public string TenNhom { get; set; }
        public string maNhom { get; set; }
        public static List<Nhomdb> GetListFromFile(string pathData)
        {
            var arrayLines = File.ReadAllLines(pathData);
            List<Nhomdb> ketQua = new List<Nhomdb>();
            foreach (var line in arrayLines)
            {
                var lsValue = line.Split(new char[] { '#' });
                var nhomdanhba = new Nhomdb
                {
                    maNhom = lsValue[1],
                    TenNhom = lsValue[2]
                };

                ketQua.Add(nhomdanhba);
            }
            return ketQua;
        }
    }
}
