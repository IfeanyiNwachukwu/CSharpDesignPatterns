namespace BuilderPattern
{
    /// <summary>
    /// Product Class
    /// </summary>
   public class WebHost
   {
        public string Environment { get; set; }
        public string Server { get; set; }
        public bool  UseHttps  { get; set; }

        public void Run()
        {
            Console.WriteLine($"Running web host in { Environment } environment on {Server}.");
            if ( UseHttps )
            {
                Console.WriteLine("Using HTTPS.");
            }
        }
   }
    /// <summary>
    /// Builder Class
    /// </summary>
    public class WebHostBuilder
    {
        private WebHost _host;

        public WebHostBuilder()
        {
            _host = new WebHost();
        }

        public WebHostBuilder UseEnvironment (string environment)
        {
            _host.Environment = environment;
            return this;
        }

        public WebHostBuilder UseServer(string server)
        {
            _host.Server = server;
            return this;
        }

        public WebHostBuilder UseHttps (bool useHttps)
        {
            _host.UseHttps = useHttps;
            return this;
        }

        public WebHost Build()
        {
            return _host;
        }
    }
}
