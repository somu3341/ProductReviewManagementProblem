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
                Console.WriteLine(data.ProductId +" "+data.UserId+" "+data.Rating+" "+data.Review+" "+data.IsLike);
            }
        }
    }
}