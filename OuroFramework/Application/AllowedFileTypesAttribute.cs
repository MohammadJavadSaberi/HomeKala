using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace OuroFramework.Application
{
    public class AllowedFileTypesAttribute : ValidationAttribute, IClientModelValidator
    {
        private readonly string[] _fileTypes;
        public AllowedFileTypesAttribute(string[] fileTypes)
        {
            _fileTypes = fileTypes;
        }
        public override bool IsValid(object value)
        {
            var file = value as IFormFile;
            if (file == null) return true;
            string fileExtension = Path.GetExtension(file.FileName);
            return _fileTypes.Contains(fileExtension);
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-allowedFileTypes", ErrorMessage);
        }
    }
}
