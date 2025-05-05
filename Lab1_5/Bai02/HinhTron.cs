using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class HinhTron : Hinh
    {
        public double r {get; set;}
        public HinhTron(){}
        public HinhTron(double r){r = r;}
        public override double ChuVi(){return 2 * Math.PI * r;}
        public override double DienTich(){return Math.PI * r * r;}
    }
}