using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivs_Ebay.Entities
{
    public class Listings
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserID { get; set; }
        public Categories Category { get; set; }  

        public Listings(int id, string title, string description, decimal price, DateTime dateCreated, int userId, Categories category)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
            DateCreated = dateCreated;
            UserID = userId;
            Category = category;  
        }

        public Listings()
        {
        }
    }

}
