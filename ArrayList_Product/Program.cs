using System;
using System.Collections;           // class ArrayList được chứa trong namespace "System.Collections"
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Product
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Tạo ArrayList
            ArrayList sanPham = new ArrayList();

            // Thêm giá trị vào mảng
            sanPham.Add(new Product("A", 5.9, 3));
            sanPham.Add(new Product("B", 8.2, 2));
            sanPham.Add(new Product("C", 3.5, 4));
            sanPham.Add(new Product("D", 1.8, 8));

            // in danh sách

            foreach(Product sp in sanPham)
            {
                Console.WriteLine(" " + sp);
            }    
        }
    }
}