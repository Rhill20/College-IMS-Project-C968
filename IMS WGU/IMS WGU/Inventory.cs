using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using IMS_WGU;

namespace IMSWGU
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();


        
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }
        public static bool RemoveProduct(int prodID)
        {
            bool success = false;
            foreach (Product prod in Products)
            {
                if (prodID == prod.ProductID)
                {
                    Products.Remove(prod);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("ERROR: Removal failed.");
                    return success = false;
                }
            }
            return success;
        }
        public static Product LookupProduct(int prodID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == prodID)
                {
                    return prod;
                }
            }
            Product emptyProduct = new IMSWGU.Product();
            return emptyProduct;
        }
        public static void UpdateProduct(int prodID, Product updatedProduct)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ProductID == prodID)
                {
                    currentProduct.Name = updatedProduct.Name;
                    currentProduct.Inventory = updatedProduct.Inventory;
                    currentProduct.Price = updatedProduct.Price;
                    currentProduct.Max = updatedProduct.Max;
                    currentProduct.Min = updatedProduct.Min;
                    currentProduct.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }
        public static bool PartsInProducts(int partId)
        {
            foreach (Product product in Products)
            {
                foreach (Part part in product.AssociatedParts)
                {
                    if (part.PartID == partId)
                        return true;
                }
            }
            return false;
        }

        
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }

        public static Part LookupPart(int partID)
        {
            foreach (Part part in Parts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Part emptyPart = new InHousePart();
            return emptyPart;
        }
        public static void UpdatePart(int partID, Part part)
        {
            DeletePart(partID);
            AddPart(part);
        }
        public static bool DeletePart(int part)
        {
            Part partToDelete = LookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                Parts.Remove(partToDelete);
                return true;
            }
        }
       
        public static void MockData()
        {
            Product exampleProd = new Product(1, "Cruiser Bike", 10, 200.0m, 13, 8);
            Products.Add(exampleProd);

            Part exampleInPart = new InHousePart(1, "Tire", 26, 40.0m, 30, 11, 1234);
            Part exampleOutPart = new OutsourcedPart(2, "Frame", 4, 50.0m, 5, 2, "Bikers.CO");
            Parts.Add(exampleInPart);
            Parts.Add(exampleOutPart);

        }
    }
}
