namespace SIS.HTTP
{
    using System;
    using System.Text;

    public class ResponseCookie : Cookie
    {
        public ResponseCookie(string name, string value)
            : base(name, value) // Because I extend Cookie, I can't let the base constructor to be not called when I don't have default constructor and here I must put the name and the value.
        {
            this.Path = "/"; // Deffault path of the cookie.
            this.SameSite = SameSiteType.None; // Deffault same site.
            this.Expires = DateTime.UtcNow.AddDays(30); // Better to be none minus value (example: yesterday or even previous second), because the browser will imediatly delete the cookie, so we set a deffault value of 30 days after now.
        }

        public string Domain { get; set; } // Domain defines the website that the cookie belongs to.

        public string Path { get; set; } // The URL path where the cookie is valid.

        public DateTime? Expires { get; set; } // Defines the date the browser should delete the cookie. By deffault are deleted after the end of the session.

        public long? MaxAge { get; set; } // Interval of seconds before the cookie is deleted.

        public bool Secure { get; set; } // Tells the browser to use the cookie only via secure/encrypted connections.

        public bool HttpOnly { get; set; } // Defines that the cookie cannot be accessed via client-side scripting languages (exampe: JS).

        public SameSiteType SameSite { get; set; } // Same site of the cookie has some types.

        public override string ToString()
        {
            StringBuilder cookieBuilder = new StringBuilder();

            cookieBuilder.Append($"{this.Name}={this.Value}");

            if (this.MaxAge.HasValue)
            {
                cookieBuilder.Append($"; Max-Age=" + this.MaxAge.Value.ToString());
            }
            else if (this.Expires.HasValue)
            {
                cookieBuilder.Append($"; Expires=" + this.Expires.Value.ToString("R"));
            }

            if (!string.IsNullOrWhiteSpace(this.Domain))
            {
                cookieBuilder.Append($"; Domain=" + this.Domain);
            }

            if (!string.IsNullOrWhiteSpace(this.Path))
            {
                cookieBuilder.Append($"; Path=" + this.Path);
            }

            if (this.Secure)
            {
                cookieBuilder.Append($"; Secure");
            }

            if (this.HttpOnly)
            {
                cookieBuilder.Append($"; HttpOnly");
            }

            cookieBuilder.Append("; SameSite=" + this.SameSite.ToString());

            return cookieBuilder.ToString();
        }
    }
}