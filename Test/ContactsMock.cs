using apiContacts.Data.Interfaces;
using apiContacts.DTOs;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class ContactsMock
    {
        public Mock<IContacts> _contacts { get; set;}
        public ContactsMock()
        {
            _contacts = new Mock<IContacts>();
            Setup();
        }
        private void Setup()
        {
            _contacts.Setup(x => x.Insert_Contact(It.IsAny<ContactCrearDTO>())).Returns(ContactStub.contact1);
            _contacts.Setup(x => x.Del_Contact(It.Is<int>(p => p.Equals(10)))).Returns(false);
            _contacts.Setup(x => x.Del_Contact(It.Is<int>(p => p.Equals(1)))).Returns(true);
        }
    }
}
