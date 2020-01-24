using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORM
{
    public class RepositoryConector
    {
        public IConfiguration _configuration;
        public RepositoryConector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            return _configuration.GetSection("Connections").GetSection("ConnectionStringUdemy").Value;
        }
    }
}
