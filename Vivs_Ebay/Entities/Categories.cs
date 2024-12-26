using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivs_Ebay.Entities
{
    public class Categories
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public Categories(int id, string categoryName)
        {
            Id = id;
            CategoryName = categoryName;
        }

        public Categories()
        {
            
        }
    }
}
