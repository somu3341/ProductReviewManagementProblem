using System;
using System.Collections.Generic;
using System.Linq;
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
        public void RetrieveProductIdAndReviewForAllRecords(List<ProductReview> list)
        {
            var result = list.Where(x => x.ProductId > 0 && (x.Review == "Good" || x.Review == "Worst" || x.Review == "Average" || x.Review == "BAverage"));
            foreach (var data in result)
            {
                Console.WriteLine("Product Id:-"+data.ProductId+" "+"Review:-"+data.Review);
            }
        }
        public void SkipTopFiveRecords(List<ProductReview> list)
        {
            var result=list.Where(x=>x.ProductId >5).ToList();
            foreach (var data in result)
            {
                Console.WriteLine("Product Id:-" + data.ProductId + " " + "User Id:-" + data.UserId + " " + "Ratings:-" + data.Rating + " " + "Review:-" + data.Review + " " + "IsLikeFields:-" + data.IsLike);
            }
        }
    }
}