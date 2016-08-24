using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Helpers
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false)]
    public sealed class EnumValidateExistsAttribute : DataTypeAttribute
    {
        public EnumValidateExistsAttribute(Type enumType)
            : base("Enumeration")
        {
            this.EnumType = enumType;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (this.EnumType == null)
            {
                throw new InvalidOperationException("Type cannot be null");
            }
            if (!this.EnumType.GetTypeInfo().IsEnum)
            {
                throw new InvalidOperationException("Type must be an enum");
            }
            if (!Enum.IsDefined(EnumType, value))
            {
                return new ValidationResult(string.Format("The field {0} value is not allowed", validationContext.DisplayName));
            }
            return ValidationResult.Success;
        }

        public Type EnumType
        {
            get;
            set;
        }
    }
}
