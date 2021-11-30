using System;
using Xunit;

namespace PasswordValidationSR.Tests
{
    public class PasswordValidatorShould
    {
        [Fact]
        public void HaveMinimun8Characters()
        {
            var password = "12345678";
            
            Assert.True(PasswordValidator.Validate(password));
        }
    }
}