using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.MicrosoftAccount;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

[ApiController]
[Route("auth")]
public class AuthController : ControllerBase
{
    [HttpGet("{provider}")]
public IActionResult Login(string provider)
{
    if (provider.ToLower() == "google") provider = "Google";
    if (provider.ToLower() == "facebook") provider = "Facebook";
    if (provider.ToLower() == "microsoft") provider = "Microsoft";

    var redirectUrl = Url.Action("ExternalLoginCallback", "Auth");
    var properties = new AuthenticationProperties { RedirectUri = redirectUrl };
    return Challenge(properties, provider);
}


    [HttpGet("callback")]
    public async Task<IActionResult> ExternalLoginCallback()
    {
        var result = await HttpContext.AuthenticateAsync("Cookies");
        if (!result.Succeeded) return Unauthorized();

        var claims = result.Principal?.Claims;
        var userData = new
        {
            Name = claims?.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value,
            Email = claims?.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value,
            Token = await HttpContext.GetTokenAsync("Cookies", "access_token")
        };

        return Ok(userData);
    }
}
