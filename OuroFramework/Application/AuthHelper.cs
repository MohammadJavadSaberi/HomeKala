using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace OuroFramework.Application
{
    public class AuthHelper : IAuthHelper
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public AuthHelper(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public string GetCurrentAccountRole
        {
            get
            {
                if (IsAuthentication())
                    return _contextAccessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Role).Value;
                return null;
            }
        }
        public AuthViewModel GetCurrentAccountInfo
        {
            get
            {
                var res = new AuthViewModel();
                if (!IsAuthentication())
                    return res;

                var claims = _contextAccessor.HttpContext.User.Claims.ToList();
                res.Id = int.Parse(claims.FirstOrDefault(p => p.Type == "AccountId").Value);
                res.Fullname = claims.FirstOrDefault(p => p.Type == ClaimTypes.Name).Value;
                res.Username = claims.FirstOrDefault(p => p.Type == "Username").Value;
                res.RoleId = int.Parse(claims.FirstOrDefault(p => p.Type == ClaimTypes.Role).Value);
                return res;
            }
        }

        public bool IsAuthentication()
        {
            var claims = _contextAccessor.HttpContext.User.Claims.ToList();
            return claims.Count > 0;
        }

        public void Signin(AuthViewModel account)
        {
            //var permissions = JsonConvert.SerializeObject(account.Permissions);
            var claims = new List<Claim>
            {
                new Claim("AccountId", account.Id.ToString()),
                new Claim(ClaimTypes.Name, account.Fullname),
                new Claim(ClaimTypes.Role, account.RoleId.ToString()),
                new Claim("Username", account.Username)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(7)
            };

            _contextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
        }

        public void SignOut()
        {
            _contextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}
