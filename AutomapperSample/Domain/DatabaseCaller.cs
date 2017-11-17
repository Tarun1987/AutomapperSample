using AutoMapper;
using AutomapperSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutomapperSample.Domain
{
    public class DatabaseCaller
    {

        private readonly IList<Customer> _customers = new List<Customer> {
             new Customer { Age = 10, Created = DateTime.Now, CreatedBy = "API", DOB = DateTime.Now, Email = "test1@gmail.com", FirstName = "User1", Id = 1, LastName = "Last", Updated = DateTime.Now, UpdatedBy = "API"  },
             new Customer { Age = 20, Created = DateTime.Now, CreatedBy = "API", DOB = DateTime.Now, Email = "test2@gmail.com", FirstName = "User2", Id = 2, LastName = "Last", Updated = DateTime.Now, UpdatedBy = "API"  },
             new Customer { Age = 30, Created = DateTime.Now, CreatedBy = "API", DOB = DateTime.Now, Email = "test3@gmail.com", FirstName = "User3", Id = 3, LastName = "Last", Updated = DateTime.Now, UpdatedBy = "API"  },
             new Customer { Age = 40, Created = DateTime.Now, CreatedBy = "API", DOB = DateTime.Now, Email = "test4@gmail.com", FirstName = "User4", Id = 4, LastName = "Last", Updated = DateTime.Now, UpdatedBy = "API"  },
             new Customer { Age = 50, Created = DateTime.Now, CreatedBy = "API", DOB = DateTime.Now, Email = "test5@gmail.com", FirstName = "User5", Id = 5, LastName = "Last", Updated = DateTime.Now, UpdatedBy = "API"  },
             new Customer { Age = 60, Created = DateTime.Now, CreatedBy = "API", DOB = DateTime.Now, Email = "test6@gmail.com", FirstName = "User6", Id = 6, LastName = "Last", Updated = DateTime.Now, UpdatedBy = "API"  },
        };


        public CustomerDto GetCustomerById(int Id)
        {
            var customer = _customers.FirstOrDefault(x => x.Id == Id);
            return Mapper.Map<CustomerDto>(customer);
        }


        public IList<CustomerDto> GetAllCustomers()
        {
            var _customerDtos = new List<CustomerDto>();
            foreach (var customer in _customers)
            {
                _customerDtos.Add(Mapper.Map<CustomerDto>(customer));
            }
            return _customerDtos;
        }

        public int GetMaxId()
        {
            return _customers.Max(x => x.Id);
        }


        public bool SaveCustomer(CustomerDto customerDto)
        {
            try
            {
                var customer = Mapper.Map<Customer>(customerDto);
                _customers.Add(customer);
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}