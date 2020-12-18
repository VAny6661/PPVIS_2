using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Viewer
    {
        private float money;
        MerchShop MS = new MerchShop();
        public string[] getProducts()
        {
            return MS.getProductList();
        }
        public void buyProduct(string name) { MS.sellProduct("food"); }

        public static void makeBet(string team, float coff) { }

        public float CheckBet() { return 1f; }

        public string[] getMatchInfo() { string[] some = { "1", "2" }; return some; }

    }
}
