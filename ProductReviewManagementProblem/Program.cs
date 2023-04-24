using System;
namespace ProductReviewManagementProblem
{
    class Program
    {

        static void Main(string[] args)
        {
            List<ProductReview> list = new List<ProductReview>();
            bool flag = true;
            while (flag)
            {
                
                Console.WriteLine("Choose Option to Perform Opearation\n1.Create Product Review Data\n2.Retrieve Top 3 Records\n3.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.Add(new ProductReview { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true });
                        list.Add(new ProductReview { ProductId = 2, UserId = 5, Rating = 4, Review = "Good", IsLike = true });
                        list.Add(new ProductReview { ProductId = 3, UserId = 1, Rating = 5, Review = "Worst", IsLike = true });
                        list.Add(new ProductReview { ProductId = 4, UserId = 7, Rating = 3, Review = "Average", IsLike = true });
                        list.Add(new ProductReview { ProductId = 5, UserId = 1, Rating = 5, Review = "Worst", IsLike = true });
                        list.Add(new ProductReview { ProductId = 6, UserId = 3, Rating = 5, Review = "Good", IsLike = true });
                        list.Add(new ProductReview { ProductId = 7, UserId = 1, Rating = 5, Review = "Worst", IsLike = true });
                        list.Add(new ProductReview { ProductId = 8, UserId = 6, Rating = 4, Review = "Good", IsLike = true });
                        list.Add(new ProductReview { ProductId = 9, UserId = 1, Rating = 5, Review = "Worst", IsLike = true });
                        list.Add(new ProductReview { ProductId = 10, UserId = 1, Rating = 5, Review = "Worst", IsLike = true });
                        list.Add(new ProductReview { ProductId = 11, UserId = 6, Rating = 3, Review = "Average", IsLike = true });
                        list.Add(new ProductReview { ProductId = 12, UserId = 8, Rating = 5, Review = "Good", IsLike = true });
                        list.Add(new ProductReview { ProductId = 13, UserId = 2, Rating = 4, Review = "Good", IsLike = true });
                        list.Add(new ProductReview { ProductId = 14, UserId = 4, Rating = 5, Review = "Good", IsLike = true });
                        list.Add(new ProductReview { ProductId = 15, UserId = 6, Rating = 2, Review = "BAverage", IsLike = true });
                        list.Add(new ProductReview { ProductId = 16, UserId = 5, Rating = 5, Review = "Good", IsLike = true });
                        list.Add(new ProductReview { ProductId = 17, UserId = 9, Rating = 4, Review = "Good", IsLike = true });
                        list.Add(new ProductReview { ProductId = 18, UserId = 11, Rating = 5, Review = "Good", IsLike = true });
                        list.Add(new ProductReview { ProductId = 19, UserId = 14, Rating = 3, Review = "Average", IsLike = true });
                        list.Add(new ProductReview { ProductId = 20, UserId = 1, Rating = 5, Review = "Good", IsLike = true });
                        list.Add(new ProductReview { ProductId = 21, UserId = 16, Rating = 5, Review = "Good", IsLike = true });
                        list.Add(new ProductReview { ProductId = 22, UserId = 1, Rating = 1, Review = "Worst", IsLike = true });
                        list.Add(new ProductReview { ProductId = 23, UserId = 10, Rating = 2, Review = "BAverage", IsLike = true });
                        list.Add(new ProductReview { ProductId = 24, UserId = 11, Rating = 5, Review = "Good", IsLike = true });
                        list.Add(new ProductReview { ProductId = 25, UserId = 12, Rating = 4, Review = "Good", IsLike = true });
                        Console.WriteLine("Product Deatils given in Table");
                        Console.WriteLine("------------------------------");
                        foreach (var data in list)
                        {
                            Console.WriteLine(data.ProductId + "  " + data.UserId + "  " + data.Rating + "  " + data.Review + "  " + data.IsLike);
                        }
                        break;
                    case 2:
                       Operation operation= new Operation();
                        operation.RetreiveTopRecords(list);
                        break;
                        case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
