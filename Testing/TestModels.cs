using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SpookifyApi.Models;
using NUnit.Framework;

namespace TestAdminAPI
{
    [TestClass]
    public class ModelsTests
    {
        [TestMethod]
        public void UserModelValidation_RequiredFieldNotCompleted_ExceptionThrown()
        {
            var user = new UserModel
            {
                UserId = 1,
                Username = "validName",
                Password = "vailPassword123",
                Role = UserRole.Normal
            };
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(user, null, null);
            var isValid = Validator.TryValidateObject(user, validationContext, validationResults);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(isValid);
        }
    }
}