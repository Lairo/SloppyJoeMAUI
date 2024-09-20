using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoeMAUI
{
    class MenuItem
    {
        public string[] Proteins = [
            "Roast beef", "Salami", "Turkey",
            "Ham", "Pastrami", "Tofu"
            ];

        public string[] Condiments = [
            "yellow mustard","brown mustard",
            "honey mustard", "mayo", "relish", "French dressing"
            ];

        public string[] Breads = ["rye", "white", "wheat", "pumpernickel", "a roll"];

        public string Description = "";
        public string Price = "";

        public void Generate()
        {
            string randomProtein = Proteins[Random.Shared.Next(Proteins.Length)];
            string randomCondiment = Condiments[Random.Shared.Next(Condiments.Length)];
            string randomBread = Breads[Random.Shared.Next(Breads.Length)];
            Description = $"{randomProtein} with {randomCondiment} on {randomBread}.";

            decimal price = Random.Shared.Next(5, 15) + Random.Shared.Next(0, 100) * .01M;


            Price = price.ToString("c");
        }
    }
}
