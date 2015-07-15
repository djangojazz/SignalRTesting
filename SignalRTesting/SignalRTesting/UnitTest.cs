﻿using System;
using System.Core;
using SignalRChat;
using Microsoft.AspNet.SignalR.Hubs;
using Moq;
using System.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestLibrary
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void HubsAreMockableViaDynamic()
        {
            bool sendCalled = false;
            var hub = new ChatHub();
            var mockClients = new Mock<IHubCallerConnectionContext<dynamic>>();
            hub.Clients = mockClients.Object;
            dynamic all = new ExpandoObject();
            all.broadcastMessage = new Action<string, string>((name, message) =>
            {
                sendCalled = true;
            });
            mockClients.Setup(m => m.All).Returns((ExpandoObject)all);
            hub.Send("TestUser", "TestMessage");
            Assert.IsTrue(sendCalled);
        }
    }
}
