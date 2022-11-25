using Microsoft.Azure.KeyVault.Models;
using RealEstate.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactService _contactService;

        public ContactManager(IContactService contactService)
        {
            _contactService = contactService;
        }

        public List<Contact> GetList()
        {
            return _contactService.GetList();
        }

        public void TDelete(Contact t)
        {
            _contactService.TDelete(t);
        }

        public Contact TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Contact t)
        {
           _contactService.TInsert(t);
        }

        public void TUpdate(Contact t)
        {
            _contactService.TUpdate(t);
        }
    }
}
