using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Product
{
    internal class Product
    {
        string name;    // tên sản phẩm
        double price;   // Giá sản phẩm
        int onhand;     // Số lượng sản phẩm sẵn có

        public Product(string name, double price, int onhand)
        {
            this.name = name;
            this.price = price;
            this.onhand = onhand;
        }

        public override string ToString()
        {
            return String.Format("{0,-10} Price: {1,6:C} On hand: {2}",name, price, onhand);
        }

    }
}
