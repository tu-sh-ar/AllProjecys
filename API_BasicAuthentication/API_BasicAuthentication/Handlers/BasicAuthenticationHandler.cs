using API_BasicAuthentication.Model;
using API_BasicAuthentication.NewFolder;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace API_BasicAuthentication.Handlers
{   
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>

    {
       
        UserContext _context;
        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
                ILoggerFactory logger,
                UrlEncoder encoder,
                ISystemClock clock,UserContext userContext) : base(options, logger, encoder, clock)
        {
           _context = userContext;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            
            if (!Request.Headers.ContainsKey("Authorization"))
                //return AuthenticateResult.NoResult();
                return AuthenticateResult.Fail("AUTH header not found");
            try
            {
                var authenticationHeaderValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var bytes = Convert.FromBase64String(authenticationHeaderValue.Parameter);
                string[] credentials = Encoding.UTF8.GetString(bytes).Split(":");
                string userName = credentials[0];
                string password = credentials[1];
                Console.WriteLine("Success {0} {1} ",userName,password);
                UserRecord user = _context.userRecords.Where(user => user.UserName == userName && user.Password == password).FirstOrDefault();

                if (userName == null)
                    return AuthenticateResult.Fail("Inavlid Username Or Password");

                else
                {
                    // claims are pieces of information asserted about a subject. For example, an ID token (which is always a JWT) can contain a claim called name that asserts that the name
                    // of the user authenticating is "John Doe". In a JWT, a claim appears as a name/value pair where the name is always a string and the value can be any JSON value
                    var claims = new[] { new Claim(ClaimTypes.Name, user.UserName) };
                    var identity = new ClaimsIdentity(claims,Scheme.Name);
                    var principle = new ClaimsPrincipal(identity);
                    var ticket = new AuthenticationTicket(principle,Scheme.Name);

                    return AuthenticateResult.Success(ticket);
                }
            }
            catch (Exception ex)
            {
                return AuthenticateResult.Fail(ex.Message);
            }

            return AuthenticateResult.Fail("Need to implement");
        }
    }
}



