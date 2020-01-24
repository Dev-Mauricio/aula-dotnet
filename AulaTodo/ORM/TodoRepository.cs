using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.Extensions.Configuration;

namespace ORM
{
    public class TodoRepository : RepositoryConector, Interfaces.ITodoRepository
    {
        public TodoRepository(IConfiguration config) : base(config)
        {

        }
        public void Add(ToDo obj)
        {
            throw new NotImplementedException();
        }

        public ToDo Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDo> GetAll()
        {
            throw new NotImplementedException();
        }

        public void remove(ToDo obj)
        {
            throw new NotImplementedException();
        }

        public void Update(ToDo obj)
        {
            throw new NotImplementedException();
        }
    }
}
