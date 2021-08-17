using apiContacts.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using apiContacts.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Test
{
    [TestClass]
    public class ContactoTest
    {
        private static ContactsController _controller;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            var stringBD = Guid.NewGuid().ToString();
            var inMemorySettings = new Dictionary<string, string> {
                {"ConnectionStrings:ConnString", $"{stringBD}" }
            };
            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings)
                .Build();

            Mock<IContacts> _contact = new ContactsMock()._contacts;

            _controller = new ContactsController(configuration, _contact.Object);
        }

        [TestMethod]
        public void Eliminar_Contacto_con_Exito()
        {
            
            var respuesta = _controller.Eliminar(1);

            var resultado = respuesta as StatusCodeResult;

            Assert.AreEqual(204, resultado.StatusCode);
        }

        [TestMethod]
        public void Eliminar_Contacto_Fallido()
        {

            var respuesta = _controller.Eliminar(10);

            var resultado = respuesta as ObjectResult;

            Assert.AreEqual(409, resultado.StatusCode);
        }

        [TestMethod]
        public void Eliminar_Fallido_Parametro_igual_0()
        {

            var respuesta = _controller.Eliminar(0);

            var resultado = respuesta as ObjectResult;

            Assert.AreEqual(400, resultado.StatusCode);
        }
    }
}
