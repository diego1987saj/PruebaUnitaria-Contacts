using apiContacts.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{ 
    public static class ContactStub
    {
        public static ContactCrearDTO contactCrear = new ContactCrearDTO()
        {
            FirstName = "Mirko",
            LastName = "Sajama",
            Company = "ARA",
            Email = "mirk@gmail.com",
            PhoneNumber = "291-5022328"
        };

        public static ContactDTO contact1 = new ContactDTO() {
            IdContact = 1,
            FirstName = "Mirko",
            LastName = "Sajama",
            Company = "ARA",
            Email = "mirk@gmail.com",
            PhoneNumber = "291-5022328"
        };

        public static ContactDTO contact2 = new ContactDTO()
        {
            IdContact = 2,
            FirstName = "Carolina",
            LastName = "Magno",
            Company = "ARA",
            Email = "caromag@gmail.com",
            PhoneNumber = "2932-502328"
        };
    }
}
