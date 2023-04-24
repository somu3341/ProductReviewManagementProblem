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
                Console.WriteLine("Product Id:-" + data.ProductId + " " + "User Id:-" + data.UserId + " " + "Ratings:-" + data.Rating + " " + "Review:-" + data.Review + " " + "IsLikeFiels:-" + data.IsLike);
            }
        }
        public void RetrieveRecordsWrtRatingAndUserId(List<ProductReview> list)
        {
            var result = list.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 4 || x.ProductId == 9));
            foreach (var data in result)
            {
                Console.WriteLine("Product Id:-"+data.ProductId + " " +"User Id:-"+ data.UserId + " " + "Ratings:-"+data.Rating + " " +"Review:-"+ data.Review + " " + "IsLikeFiels:-"+data.IsLike);
            }
        }

    }
}