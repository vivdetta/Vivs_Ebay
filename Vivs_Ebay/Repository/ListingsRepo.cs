using System.Data;
using System.Data.SqlClient;
using Vivs_Ebay.Entities;

namespace Vivs_Ebay.Repository
{
    public class ListingsRepo
    {
        // Things to remember
        // Use the DataContext to execute the update command
        // Create and use SqlParameter to avoid SQL injection
        public List<Listings> SearchListingsByCategoryAndTitle(int categoryId, string title)
        {
            string sql =
                "SELECT tblListings.ID, tblListings.Title, tblListings.Description, tblListings.Price, tblListings.CategoryID, tblCategory.Category, " +
                "tblListings.DateCreated, tblListings.UserID FROM tblListings " +
                "INNER JOIN tblCategory ON tblListings.CategoryID = tblCategory.ID " +
                "WHERE tblListings.CategoryID = @categoryId AND tblListings.Title LIKE @title";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@categoryId", categoryId),
                new SqlParameter("@title", "%" + title + "%")
            };

            DataContext context = new DataContext();
            DataTable data = context.ExecuteCommandReturnTable(sql, parameters);

            List<Listings> listings = new List<Listings>();

            foreach (DataRow row in data.Rows)
            {
                Categories caty = new Categories(
                    (int)row["CategoryID"],
                    row["Category"].ToString()
                );

                Listings listing = new Listings(
                    (int)row["ID"],
                    row["Title"].ToString(),
                    row["Description"].ToString(),
                    (decimal)row["Price"],
                    (DateTime)row["DateCreated"],
                    (int)row["UserID"],
                    caty
                );

                listings.Add(listing);
            }

            return listings;
        }

        public List<Listings> SearchListingsByCategory(int categoryId)
        {
            
            string sql =
                "SELECT tblListings.ID, tblListings.Title, tblListings.Description, tblListings.Price, tblListings.CategoryID, tblCategory.Category, " +
                "tblListings.DateCreated, tblListings.UserID FROM tblListings INNER JOIN tblCategory ON tblListings.CategoryID = tblCategory.ID " +
                "WHERE tblListings.CategoryID = @categoryId;";

            
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@categoryId", categoryId) 
            };

            DataContext context = new DataContext();

            DataTable data = context.ExecuteCommandReturnTable(sql, parameters);

            List<Listings> listings = new List<Listings>();

           
            foreach (DataRow row in data.Rows)
            {
                
                Categories caty = new Categories(
                    (int)row.ItemArray[4],          
                    row.ItemArray[5].ToString()      
                );

                
                Listings listing = new Listings(
                    (int)row.ItemArray[0],          
                    row.ItemArray[1].ToString(),     
                    row.ItemArray[2].ToString(),      
                    (decimal)row.ItemArray[3],        
                    (DateTime)row.ItemArray[6],       
                    (int)row.ItemArray[7],           
                    caty                             
                );

                listings.Add(listing);
            }
            return listings;
        }

        public List<Listings> SearchListingsByTitle(string condition)
        {
            
            string sql =
                "SELECT tblListings.ID, tblListings.Title, tblListings.Description, tblListings.Price, tblListings.CategoryID, tblCategory.Category, " +
                "tblListings.DateCreated, tblListings.UserID FROM tblListings INNER JOIN tblCategory ON tblListings.CategoryID = tblCategory.ID " +
                "WHERE tblListings.Title LIKE @condition;";


            // Add the search condition parameter to prevent SQL injection
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@condition", "%" + condition + "%"));

            DataContext context = new DataContext();

            // Execute the SQL query and store the result in a DataTable
            DataTable data = context.ExecuteCommandReturnTable(sql, parameters);

            List<Listings> listings = new List<Listings>();

            // Loop through each row in the DataTable to map database values to Listings objects
            foreach (DataRow row in data.Rows)
            {
                // Create a Categories object using CategoryID and CategoryName
                Categories caty = new Categories(
                    (int)row.ItemArray[4],          
                    row.ItemArray[5].ToString()     
                );

                // Create a Listings object using the listing's details and associated Category object
                Listings listing = new Listings(
                    (int)row.ItemArray[0],           
                    row.ItemArray[1].ToString(),      
                    row.ItemArray[2].ToString(),     
                    (decimal)row.ItemArray[3], 
                    (DateTime)row.ItemArray[6],      
                    (int)row.ItemArray[7],           
                    caty                              
                );

                listings.Add(listing);
            }
            return listings;

        }

        public List<Categories> GetAllCategories()
        {

            DataContext context = new DataContext();

            string sql = "SELECT ID, Category FROM tblCategory";
            DataTable data = context.ExecuteCommandReturnTable(sql, null);

            List<Categories> categories = new List<Categories>();
            foreach (DataRow row in data.Rows)
            {
                categories.Add(new Categories(
                    (int)row["ID"],
                    row["Category"].ToString()
                ));
            }
            return categories;
        }

        public List<Listings> GetListingsByUser(string username)
        {
            string sql =
                "SELECT tblListings.ID, tblListings.Title, tblListings.Description, tblListings.Price, tblListings.CategoryID, tblCategory.Category, " +
                "tblListings.DateCreated, tblListings.UserID FROM tblListings " +
                "INNER JOIN tblCategory ON tblListings.CategoryID = tblCategory.ID " +
                "INNER JOIN tblUser ON tblListings.UserID = tblUser.ID " +
                "WHERE tblUser.Username = @username";

            // Add the username parameter to prevent SQL injection
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@username", username)
            };

            DataContext context = new DataContext();

            // Execute the SQL query and store the result in a DataTable
            DataTable data = context.ExecuteCommandReturnTable(sql, parameters);

            List<Listings> listings = new List<Listings>();

            
            foreach (DataRow row in data.Rows)
            {
                
                Categories caty = new Categories(
                    (int)row["CategoryID"],           
                    row["Category"].ToString()         
                );

                
                Listings listing = new Listings(
                    (int)row["ID"],                    
                    row["Title"].ToString(),            
                    row["Description"].ToString(),      
                    (decimal)row["Price"],              
                    (DateTime)row["DateCreated"],       
                    (int)row["UserID"],                 
                    caty                                
                );

                listings.Add(listing);
            }

            return listings;
        }
        public void AddListing(Listings listing)
        {
            string sql = "INSERT INTO tblListings (Title, Description, Price, CategoryID, UserID, DateCreated) " +
                         "VALUES (@title, @description, @price, @categoryID, @userID, @dateCreated);";

            
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@title", listing.Title),
                new SqlParameter("@description", listing.Description),
                new SqlParameter("@price", listing.Price),
                new SqlParameter("@categoryID", listing.Category.Id), 
                new SqlParameter("@userID", listing.UserID), 
                new SqlParameter("@DateCreated", listing.DateCreated)
            };

            
            DataContext context = new DataContext();

            context.ExecuteCommandNoReturnValue(sql, parameters);
        }
        public void DeleteListing(int listingId)
        {
            string sql = "DELETE FROM tblListings WHERE ID = @listingId";

            // Create parameter to avoid SQL injection
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@listingId", listingId)
            };

            // Use the DataContext to execute the delete command
            DataContext context = new DataContext();
            context.ExecuteCommandNoReturnValue(sql, parameters);
        }
        public void UpdateListing(Listings listing)
        {
            string sql = "UPDATE tblListings SET Title = @title, Description = @description, Price = @price, CategoryID = @categoryID WHERE ID = @listingId";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@title", listing.Title),
                new SqlParameter("@description", listing.Description),
                new SqlParameter("@price", listing.Price),
                new SqlParameter("@categoryID", listing.Category.Id),
                new SqlParameter("@listingId", listing.Id)
            };

            // Use the DataContext to execute the update command
            DataContext context = new DataContext();
            context.ExecuteCommandNoReturnValue(sql, parameters);
        }

    }
}
