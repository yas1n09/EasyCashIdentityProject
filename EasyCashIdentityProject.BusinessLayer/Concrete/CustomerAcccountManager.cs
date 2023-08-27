using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAcccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDAL _customerAccountDAL;

        public CustomerAcccountManager(ICustomerAccountDAL customerAccountDAL)
        {
            _customerAccountDAL = customerAccountDAL;
        }

        public void TDelete(CustomerAccount t)
        {
            _customerAccountDAL.Delete(t);

        }

        public CustomerAccount TGetByID(int id)
        {
            return _customerAccountDAL.GetByID(id);
        }

        public List<CustomerAccount> TGetList()
        {
            return _customerAccountDAL.GetList();
        }

        public void TInsert(CustomerAccount t)
        {
            _customerAccountDAL.Insert(t);
        }

        public void TUpdate(CustomerAccount t)
        {
            _customerAccountDAL.Update(t);
        }
    }
}
