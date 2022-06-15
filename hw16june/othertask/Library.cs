using System;
namespace othertask
{
    public class Library
    {
        Product[] Products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }


        public int GetJournalsCount()
        {
            int count = 0;
            foreach(var item in Products)
            {
                if(item is Journal)
                {
                    count++;
                }
            }
            return count;
        }

        public Product[] GetProducts(bool isBook)
        {
            Product[] products = new Product[0];
            foreach(var item in this.Products)
            {
                if (isBook)
                {
                    if(item is Book)
                    {
                        Array.Resize(ref products, products.Length + 1);
                        products[products.Length + 1] = item;

                            
                    }
                }
                else
                {
                    if (item is Journal)
                    {
                        Array.Resize(ref products, products.Length + 1);
                        products[products.Length + 1] = item;

                    }

                }
            }
            return products;


    }
}
