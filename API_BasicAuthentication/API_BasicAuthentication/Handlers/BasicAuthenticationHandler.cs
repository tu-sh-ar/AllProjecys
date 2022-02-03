using API_BasicAuthentication.Model;
using API_BasicAuthentication.NewFolder;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace API_BasicAuthentication.Handlers
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>

    {
        public readonly UserContext _context;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
                ILoggerFactory logger,
                UrlEncoder encoder,
                ISystemClock clock, UserContext context) : base(options, logger, encoder, clock)
        {
            _context = context;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("AUTH header not found");
            try
            {
                var authenticationHeaderValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var bytes = Convert.FromBase64String(authenticationHeaderValue.Parameter);
                string[] credentials = Encoding.UTF8.GetString(bytes).Split(":");
                string userName = credentials[0];
                string password = credentials[1];

                UserRecord user = (UserRecord)_context.userRecords.Where(user => user.UserName == userName && user.Password == password).FirstOrDefault();

            }
            catch (Exception ex)
            {
                return AuthenticateResult.Fail("Error Has occured");
            }

            return AuthenticateResult.Fail("Need to implement");
        }
    }
}



