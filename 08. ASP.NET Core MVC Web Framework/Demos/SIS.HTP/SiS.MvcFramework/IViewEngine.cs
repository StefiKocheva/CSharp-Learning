namespace SIS.MvcFramework
{
    public interface IViewEngine // What can do the View Engine.
    {
        string GetHtml(string templateHtml, object model, string user);
    }
}
