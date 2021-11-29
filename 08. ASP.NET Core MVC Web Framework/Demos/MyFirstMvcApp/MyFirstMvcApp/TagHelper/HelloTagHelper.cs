using Microsoft.AspNetCore.Razor.TagHelpers;
using MyFirstMvcApp.Services;

namespace MyFirstMvcApp.TagHelper 
{
    [HtmlTargetElement("h1", Attributes = "greeting-name")]
    [HtmlTargetElement("h2")]
    [HtmlTargetElement("h3")]
    [HtmlTargetElement("h4")]
    [HtmlTargetElement("h5")]
    [HtmlTargetElement("h5")]
    public class HelloTagHelper : TagHelper
    {
        private readonly IUsersService usersService;

        public HelloTagHelper(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public string GreetingName { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("Stefi", this.GreetingName);
            output.Content.SetContent(this.GreetingName);
            output.PreElement.SetContent(this.GreetingName);
            output.PostElement.SetContent(this.usersService.GetCount().ToString());
        }
    }
}
