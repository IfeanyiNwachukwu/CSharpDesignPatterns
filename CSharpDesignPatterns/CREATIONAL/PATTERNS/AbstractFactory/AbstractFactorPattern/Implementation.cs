using System.Runtime.CompilerServices;

namespace AbstractFactorPattern
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface IShoppingCartPurchaseFactory
    {
        //object 1
        IDiscountService CreateDiscountService();
        //object 2
        IShippingCostsService CreateShippingCostsService();
    }
    /// <summary>
    /// AbstractProduct
    /// </summary>
    public interface IDiscountService
    {
        int DiscountPercentage { get; }
    }
    /// <summary>
    /// Abstract Product
    /// </summary>
    public interface IShippingCostsService
    {
        decimal ShippigCosts { get; }
    }
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class BelgiumDiscountService : IDiscountService
    {
        public int DiscountPercentage => 20;
    }
    /// <summary>
    /// Concrete product
    /// </summary>
    public class FranceDiscountService : IDiscountService
    {
        public int DiscountPercentage => 10;
    }
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class BelgiumShippingCostsService : IShippingCostsService
    {
        public decimal ShippigCosts => 20;
    }

    /// <summary>
    /// Concrete Product
    /// </summary>
    public class FranceShippingCostsService : IShippingCostsService
    {
        public decimal ShippigCosts => 25;
    }
    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new BelgiumDiscountService();
        }

    
        public IShippingCostsService CreateShippingCostsService()
        {
            return new BelgiumShippingCostsService();
        }
    }

    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class FranceCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new FranceDiscountService();
        }


        public IShippingCostsService CreateShippingCostsService()
        {
            return new FranceShippingCostsService();
        }
    }
    /// <summary>
    /// Client class
    /// </summary>
    public class ShoppingCart
    {
        private readonly IDiscountService _discountService;
        private readonly IShippingCostsService _shippingCostsService;
        private int _orderCosts;

        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
           _discountService = factory.CreateDiscountService();
           _shippingCostsService = factory.CreateShippingCostsService();
           _orderCosts = 200;
        }

        public void CalculateCosts()
        {
            Console.WriteLine($"Total costs = " +
                $"{_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippigCosts}");
        }

    }



}
