﻿namespace DesignPatterns._01__Creatinal._1._2___Factory_Method
{
    // Abstract Product
    public abstract class DbConnector
    {
        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected string ConnectionString { get; set; }
        public abstract Connection Connect();
    }
}
