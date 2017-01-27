namespace PartialViewsExample.Models
{
    public sealed class ShirtOrderViewModel
    {
        public int Id { get; set; }
        public string ShirtName { get; set; }
    }

    public sealed class Order
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
    }

    // Common in all pages
    public class CartShirtViewModel
    {
        public ShirtOrderViewModel ShirtOrderViewModel { get; set; }
        public Order Order { get; set; }
    }

    public sealed class HomePageViewModel : CartShirtViewModel
    {
        public string WelcomeMessage { get; set; }

        public HomePageViewModel()
        {
            Order = new Order
            {
                Id=1,
                OrderName = "Home Order"
            };

            ShirtOrderViewModel= new ShirtOrderViewModel
            {
                Id = 1,
                ShirtName = "Home shirt"
            };

            WelcomeMessage = "welcome to home";
        }
    }

}