using API_BasicAuthentication.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using API_BasicAuthentication.NewFolder;

namespace API_BasicAuthentication.Controllers
{
    
    public class WeatherForecastController : ControllerBase
    {
        private readonly JWTSettings _jwtSettings;
        private UserContext _userContext;
       
        public WeatherForecastController(IOptions<JWTSettings> jwtsettings,UserContext userContext)
        {
            _jwtSettings = jwtsettings.Value;
            _userContext = userContext;
        }
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        [Authorize]
        [HttpGet("Get")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

        }
        [HttpGet("Login")]
        public async Task<ActionResult<UserRecord>> Login([FromBody]UserRecord user)
        {
            
            UserRecord userWithToken = new UserRecord() ;
            if (user == null)
            {
                return BadRequest("User is null");
            }
            userWithToken.UserName = user.UserName;
            userWithToken.Password = user.Password;
            
            user = _userContext.userRecords.Where(u => u.UserName == user.UserName && user.Password == u.Password).FirstOrDefault();
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSettings.SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserName)
                }),
                Expires = DateTime.UtcNow.AddMonths(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)

            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            userWithToken.Token = tokenHandler.WriteToken(token);

            return userWithToken;
        }
    }
}