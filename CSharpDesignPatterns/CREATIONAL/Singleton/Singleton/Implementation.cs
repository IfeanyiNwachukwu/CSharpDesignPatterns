﻿namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        //Laz<T>
        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());
        /// <summary>
        /// Instance
        /// </summary>
        public static Logger Instance
        {
            get
            {
               return _lazyLogger.Value;
            }
        }
        protected Logger()
        {

        }

        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
