using MiniStore.DTO;
using MiniStore.GUI.Controls;
using MiniStore.GUI.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.GUI.Features
{
    public class ProductSetting
    {
        private static MyDialog dialog;
        public static void Show()
        {
            ProductItem product = new ProductItem();
            dialog = new MyDialog(product);
            product.parent = dialog;
            dialog.ShowDialog();
        }
        public static void Show(ProductDTO dto)
        {
            ProductItem product = new ProductItem(dto);
            dialog = new MyDialog(product);
            product.parent = dialog;
            dialog.ShowDialog();
        }
        
    }
}
