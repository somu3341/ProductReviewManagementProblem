using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementProblem
{
    public class Operation
    {
        public void RetreiveTopRecords(List<ProductReview> list)
        {
            var result = list.Where(x => x.Rating == 5).Take(3);
            foreach (var data in result)
            {
                Console.WriteLine("Product Id:-" + data.ProductId + " " + "User Id:-" + data.UserId + " " + "Ratings:-" + data.Rating + " " + "Review:-" + data.Review + " " + "IsLikeFields:-" + data.IsLike);
            }
        }
        public void RetrieveRecordsWrtRatingAndUserId(List<ProductReview> list)
        {
            var result = list.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 4 || x.ProductId == 9));
            foreach (var data in result)
            {
                Console.WriteLine("Product Id:-"+data.ProductId + " " +"User Id:-"+ data.UserId + " " + "Ratings:-"+data.Rating + " " +"Review:-"+ data.Review + " " + "IsLikeFields:-"+data.IsLike);
            }
        }
        public void RetrieveCountWrtUseId(List<ProductReview> list)
        {
            var result = list.GroupBy(x => x.UserId).Select(x => new { UserId = x.Key, Count = x.Count() });
            foreach (var data in result)
            {
                Console.WriteLine("User Id:-" + data.UserId+" " +"Group Count:-"+data.Count);
            }
        }
        //UC5 and //UC7
        public void RetrieveProductIdAndReviewForAllRecords(List<ProductReview> list)
        {
            var result = list.Where(x => x.ProductId > 0 && (x.Review == "Good" || x.Review == "Worst" || x.Review == "Average" || x.Review == "BAverage"));
            foreach (var data in result)
            {
                Console.WriteLine("Product Id:-"+data.ProductId+" "+"Review:-"+data.Review);
            }
        }
        //UC6
        public void SkipTopFiveRecords(List<ProductReview> list)
        {
            var result=list.Where(x=>x.ProductId >5).ToList();
            foreach (var data in result)
            {
                Console.WriteLine("Product Id:-" + data.ProductId + " " + "User Id:-" + data.UserId + " " + "Ratings:-" + data.Rating + " " + "Review:-" + data.Review + " " + "IsLikeFields:-" + data.IsLike);
            }
        }
        //UC8
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial catalog = ProductReview_Management";
        SqlConnection connection = new SqlConnection(connectionString);
        public void CreatDataTableListAndGetAllRecords()
        {
            try
            {
                ProductReview product = new ProductReview();
                using(this.connection)
                {
                    string query = @"Select * from Product_Review";
                    SqlCommand command = new SqlCommand(query, this.connection);
                    command.CommandType = CommandType.Text;
                    this.connection.Open();
                    SqlDataReader read = command.ExecuteReader();
                    if (read.HasRows)
                    {
                        while(read.Read())
                        {
                            product.ProductId = read.GetInt32(0);
                            product.UserId = read.GetInt32(1);
                            product.Rating = read.GetInt32(2);
                            product.Review = read.GetString(3);
                            product.IsLike = read.GetString(4);
                        }
                        Console.WriteLine("Product Id:-" + product.ProductId + " " + "User Id:-" + product.UserId + " " + "Ratings:-" + product.Rating + " " + "Review:-" + product.Review + " " + "IsLikeFields:-" + product.IsLike);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //UC9
        public void FindAverageRatingsOfProductId(List<ProductReview> list)
        {
            var result = list.Where(x => x.ProductId >0 && x.Rating >= 1);
              // var sum= list.GroupBy(x=>x.UserId). Select(x => new { UserId = x.Key, Count = x.Count() });
            int resultCount=result.Count();
            if(resultCount !=0)
            {
                int totalRating= result.Sum(x=>x.Rating);
                int average=totalRating/resultCount;
                Console.WriteLine("Average Raings {0}",average);
            }
        }
        //UC10
        public void RetrieveRecordsContainNiceInIt(List<ProductReview>list)
        {
            var result = list.Where(x => x.Review == "Nice");
            foreach(var data in result)
            {
                Console.WriteLine("Product Id:-" + data.ProductId + " " + "User Id:-" + data.UserId + " " + "Ratings:-" + data.Rating + " " + "Review:-" + data.Review + " " + "IsLikeFields:-" + data.IsLike);
            }
        }
    }
}