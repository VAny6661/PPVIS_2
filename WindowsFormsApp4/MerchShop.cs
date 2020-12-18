using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class MerchShop
    {

        public List<Product> lp = new List<Product>();
        public void sellProduct(string name)
        {
            for (int i = 0; i < lp.Count; i++)
            {
                if (lp[i].name == name)
                {
                    lp.RemoveAt(i);
                    i--;
                }
            }
        }
            public string[] getProductList()
            {
              Product pr = new Product();
              lp.Add(pr);
              pr.name = "1";
                string[] some = { "1", "2" };
                return some;
            }
        }
    } 
