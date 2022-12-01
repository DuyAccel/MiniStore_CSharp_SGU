using MiniStore.DAO;
using MiniStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniStore.ExtendedFeatures;

namespace MiniStore.BUS
{
    public static class ProductBUS
    {
        public static DataTable getAllProduct()
        {
            return ProductDAO.getAllProduct();
        }
        public static bool addProduct(ProductDTO product)
        {
            product.Quantity = 0;
            if (ProductDAO.addProduct(product) == 1)
            {
                DataTable dt = ProductDAO.getLatestProduct();
                string id = dt.Rows[0][0].ToString();
                product.Barcode = Barcode.GenerateBarcode(id);
                ProductDAO.updateProduct(product, id);
                return true;
            }
            return false;

        }
        public static bool updateProduct(ProductDTO product)
        {
            return (ProductDAO.updateProduct(product) == 1);
        }
        public static bool removeProduct(string productID)
        {
            return (ProductDAO.removeProduct(productID) == 1);
        }
        public static DataTable searchAdvance(string column, string keywords)
        {
            return ProductDAO.searchAdvance(column, keywords);
        }
    }
}
