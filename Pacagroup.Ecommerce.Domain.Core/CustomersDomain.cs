using System;
using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Domain.Interface;
using Pacagroup.Ecommerce.Infraestructure.Interface;

using System.Threading.Tasks;
using System.Collections.Generic;

namespace Pacagroup.Ecommerce.Domain.Core
{
    public class CustomersDomain : ICustomerDomain
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomersDomain(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }

        #region Métodos sincronos

        public bool Insert(Customers customers)
        {
            return _customersRepository.Insert(customers);
        }

        public bool Update(Customers customers)
        {
            return _customersRepository.Update(customers);
        }

        public bool Delete(string CustomerId)
        {
            return _customersRepository.Delete(CustomerId);
        }

        public Customers Get(string CustomerId)
        {
            return _customersRepository.Get(CustomerId);
        }

        public IEnumerable<Customers> GetAll()
        {
            return _customersRepository.GetAll();
        }

        #endregion

        #region Métodos Asíncronos

        public async Task<bool> InsertAsync(Customers customers)
        {
            return await _customersRepository.InsertAsync(customers);
        }

        public async Task<bool> UpdateAsync(Customers customers)
        {
            return await _customersRepository.UpdateAsync(customers);
        }

        public async Task<bool> DeleteAsync(string CustomerId)
        {
            return await _customersRepository.DeleteAsync(CustomerId);
        }

        public async Task<Customers> GetAsync(string CustomerId)
        {
            return await _customersRepository.GetAsync(CustomerId);
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            return await _customersRepository.GetAllAsync();
        }

        #endregion
    }
}
