namespace SIS.MvcFramework
{
    using SIS.HTTP;
    using SIS.HTTP.Response;
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography;
    using System.Text;

    public abstract class Controller
    {
        public HttpRequest Request { get; set; }

        protected HttpResponse View<T>(T viewModel = null, [CallerMemberName] string viewName = null)
            where T : class
        {
            var typeName = this.GetType().Name;
            var controllerName = this.GetType().Name.Replace("Controller", string.Empty);
            var viewPath = "Views/" + controllerName + "/" + viewName + ".html";
            return this.ViewByName<T>(viewPath, viewModel);
        }
        protected HttpResponse View(object viewModel = null, [CallerMemberName] string viewName = null)
        {
            return this.View<object>(null, viewName);
        }
        protected HttpResponse Error(string error)
        {
            return this.ViewByName<ErrorViewModel>("Views/Shared/Error.html", new ErrorViewModel { Error = error });
        }

        protected HttpResponse Redirect(string url)
        {
            return new RedirectResponse(url);
        }


        private HttpResponse ViewByName<T>(string viewPath, object viewModel)
        {
            IViewEngine viewEngine = new ViewEngine();
            var html = File.ReadAllText(viewPath);
            html = viewEngine.GetHtml(html, viewModel, this.User);

            var layout = File.ReadAllText("Views/Shared/_Layout.html");
            var bodyGuidLayout = layout.Replace("@RenderBody()", html);
            layout = viewEngine.GetHtml(html, viewModel, this.User);
            return new HtmlResponse(bodyGuidLayout);
        }

        protected bool IsUserLogedIn()
        {
            return this.User != null;
        }

        protected void SignIn(string userId)
        {
            this.Request.SessionData["UserId"] = userId;
        }

        protected void SignOut()
        {
            this.Request.SessionData["UserId"] = null;
        }

        public string User =>
            this.Request.SessionData.ContainsKey("UserId") ?
                this.Request.SessionData["UserId"] : null;
    }
}