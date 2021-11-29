using System;
using System.Collections.Generic;
using System.Text;
using MyFirstMvcApp.Filters;
using MyFirstMvcApp.Services;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Xuniut;

namespace MyFirstMvcApp.Tests
{
    [Fact]
    public class MyAuthorizedFilterAttributeTests
    {
        public void OnAuthorizationShouldCallGetUsernamesIfThereAreUsers()
        {
            var serviceMock = new Mock<IUsersService>();
            serviceMock.Setup(x => x.GetCount()).Returns(1);
            //serviceMock.Setup(x => x.LatestUsername(It.Is<string>(x => x.StartsWith("X")))).Returns("stefikocheva2005@gmail.com");
            //serviceMock.Setup(x => x.LatestUsername(It.IsAny<string>())).Returns("stefikocheva2005@gmail.com");
            //serviceMock.Setup(x => x.LatestUsername("email")).Returns("stefikocheva2005@gmail.com");
            //serviceMock.Setup(x => x.LatestUsername("username")).Returns("AStefi");
            var attribute = new OnAuthorizeFilterAttribute(serviceMock.Object);

            var actionContextMock = new Mock<ActionContext>();

            //attribute.OnAuthorization(new AuthorizationFilterContext(
            //    new ActionContext() { HttpContext = new MyHttpContetx(), 
            //        RouteData = new RouteData(),
            //    ActionDescriptor = new ActionDescriptor()}, 
            //    new List<IFilterMetadata>()));

            attribute.OnAuthorization(new AuthorizationFilterContext(
                new ActionContext() { HttpContext = new MyHttpContetx(), 
                    RouteData = new RouteData(),
                ActionDescriptor = new ActionDescriptor()}, 
                new List<IFilterMetadata>()));

            serviceMock.Verify(x => x.GetUsernames(), Times.Once);
            //serviceMock.Verify(x => x.GetUsernames(), Times.Exactly(2)); // way to fail
        }

        public class MyHttpContetx : HttpContext
        {
            public MyHttpContetx()
                : base()
            {
            }

            public override IFeatureCollection Features => throw new NotImplementedException();
            
            public override HttpRequest Request => throw new NotImplementedException();
            
            public override HttpResponse Response => throw new NotImplementedException();
            
            public override ConnectionInfo Connection => throw new NotImplementedException();
            
            public override WebSocketManager WebSockets => throw new NotImplementedException();
            
            public override AuthenticationManager Authentication => throw new NotImplementedException();
            
            public override ClaimsPrincipal User => throw new NotImplementedException();
            
            public override IDictionary<object, object> items => throw new NotImplementedException();
            
            public override IServiceProvider RequestServices => throw new NotImplementedException();

            public override CancellationToken RequestAborted => throw new NotImplementedException();

            public override string TraceIdentifier => throw new NotImplementedException();
            
            public override ISession Session => throw new NotImplementedException();
            
            public override void Abort()
            {
                throw new Notimplementedexception();
            }
        }

        // Not needed
        //public class MyTestUserService : IUsersService
        //{
        //    public bool Executed { get; private set; }
        //
        //    public string GetCount()
        //    {
        //        return 1;
        //    }
        //
        //    public string GetUsernames()
        //    {
        //        Executed = true;
        //        return new List<string>();
        //    }
        //
        //    public string LatestUsername(string orderBy = "username")
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }   //
}
