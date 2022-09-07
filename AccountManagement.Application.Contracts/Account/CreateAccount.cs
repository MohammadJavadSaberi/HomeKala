using AccountManagement.Application.Contracts.Role;
using Microsoft.AspNetCore.Http;
using OuroFramework.Application;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Application.Contracts.Account
{
    public class CreateAccount
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        public string FullName { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]       
        public string UserName { get; set; }
        
        [Required(ErrorMessage = ValidationMessages.Required)]
        public string PassWord { get; set; }
        
        [Required(ErrorMessage = ValidationMessages.Required)]
        public string Mobile { get; set; }
        public IFormFile ProfilePicture { get; set; }

        //[Range(1, 100, ErrorMessage = ValidationMessages.Required)]
        public int RoleId { get; set; }
        public List<RoleViewModel> Roles { get; set; }
    }
}
