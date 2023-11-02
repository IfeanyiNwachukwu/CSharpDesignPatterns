using AbstractFactorPattern;

Console.Title = "Abstract Factory";

var belgiumShoppingCartPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();

var shoppingCartForBelgium = new ShoppingCart(belgiumShoppingCartPurchaseFactory);

var franceShoppingCartPurchaseFactory = new FranceCartPurchaseFactory();

var shoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);

shoppingCartForBelgium.CalculateCosts();

Console.ReadKey();
