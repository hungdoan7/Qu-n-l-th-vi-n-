﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
	 interface DacTrungDocGia
	{
		void GiaHanThe(Date Today);
	    void DangKyTaiKhoanMoi(Date Today);
	}
	abstract class Nguoi
    {
		protected string sHoTen;	
        protected string sDiaChi;
        protected string sSDT;
        protected Date dtNgaySinh;
		
		public string HoTen
		{
			get
			{
				return this.sHoTen;
			}
		}
		public string DiaChi
		{
			get
			{
				return this.sDiaChi;
			}
		}
		public string SDT
		{
			get
			{
				return this.sSDT;
			}
		}
		public Date NgaySinh
		{
			get
			{
				return this.dtNgaySinh;
			}
		}
		public Nguoi()
		{
			this.dtNgaySinh = new Date();
		}
		public Nguoi(string HoTen, string DiaChi, string SDT, int NgaySinh, int ThangSinh,int NamSinh)
        {
            this.sHoTen = HoTen;
            this.sDiaChi = DiaChi;
            this.sSDT = SDT;
			Date Temp = new Date(NgaySinh, ThangSinh, NamSinh);
            this.dtNgaySinh = Temp;
        }
		public virtual void Nhap()
		{
			Console.Write("Ten: ");
			this.sHoTen = Console.ReadLine();
			Console.Write("Dia chi: ");
			this.sDiaChi = Console.ReadLine();
			Console.Write("SDT: ");
			this.sSDT = Console.ReadLine();
			Console.Write("Ngay sinh: ");
			this.dtNgaySinh.Ngay = Convert.ToInt32(Console.ReadLine());
			Console.Write("Thang sinh: ");
			this.dtNgaySinh.Thang = Convert.ToInt32(Console.ReadLine());
			Console.Write("Nam sinh: ");
			this.dtNgaySinh.Nam = Convert.ToInt32(Console.ReadLine());
		}
        public virtual void Xuat()
        {
            Console.WriteLine("Ho Ten: " + this.sHoTen);
            Console.WriteLine("Dia Chi: " + this.sDiaChi);
            Console.WriteLine("SDT: " + this.sSDT);
            Console.WriteLine("Ngay Sinh: " + this.dtNgaySinh.Ngay+"/"+this.dtNgaySinh.Thang+"/"+this.dtNgaySinh.Nam+" ");
        }
		public abstract void Tien(double a);
    }
}
