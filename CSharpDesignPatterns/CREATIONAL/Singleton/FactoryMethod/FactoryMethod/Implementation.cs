namespace FactoryMethod
{
    /// <summary>
    /// Product
    /// </summary>
    public abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }
        public override string ToString() => GetType().Name;
       
    }
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class CountryDiscountService : DiscountService
    {
        //b/c string value should not be changed after the obect has been constructed
        private readonly string _countryIdentifier;

        public CountryDiscountService(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }
        public override int DiscountPercentage
        {
            get
            {
                switch (_countryIdentifier)
                {
                    case "NG":
                        return 50;
                       
                    case "BE":
                        return 30;
                    default:
                        return 10;
                }
            }
        }
    }

    /// <summary>
    /// Concrete Product
    /// </summary>
    public class CodeDiscountService : DiscountService
    {
        //b/c string value should not be changed after the obect has been constructed
        private readonly Guid _code;

        public CodeDiscountService(Guid code)
        {
            _code = code;
        }
        public override int DiscountPercentage
        {
            // each code returns the same fixed percentage
            get => 15;
        }
    }

    /// <summary>
    /// Creator
    /// </summary>
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryIdentifier;

        public CountryDiscountFactory(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryIdentifier);
        }
    }

    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _code;

        public CodeDiscountFactory(Guid code)
        {
            _code = code;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_code);
        }
    }
}
