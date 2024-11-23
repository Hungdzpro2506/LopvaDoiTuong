using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HinhChuNhat{
        private double Chieucao;
        private double Chieurong;
        public HinhChuNhat() { }

        public HinhChuNhat(double Chieucao, double Chieurong)
        {
            this.Chieucao = Chieucao;
            this.Chieurong = Chieurong;
        }
        public double getDienTich()
        {
            return this.Chieucao*this.Chieurong;
        }
        public double GetChuVi()
        {
            return (this.Chieucao+this.Chieurong)*2;
        }
        public string Display()
        {
            return $"Hinh Chu Nhat co chieu cao = {Chieucao} va chieu rong = {Chieurong}  ";
        }

}
    internal class TinhHCN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu cao cua HCN: ");
            double Chieucao = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong cua HCN: ");
            double Chieurong = Double.Parse(Console.ReadLine());
            HinhChuNhat HCN = new HinhChuNhat(Chieucao, Chieurong);
            Console.WriteLine(HCN.Display());
            Console.WriteLine("HCN cua ban co dien tich: "+ HCN.getDienTich());
            Console.WriteLine("HCN cua ban co chu vi: " + HCN.GetChuVi());


        }
    }
}
