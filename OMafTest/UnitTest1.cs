using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OMAF.Controllers;
using OMAF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OMafTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Validate_Aircraft()
        {
            //Arrange
            var aircraft = new Aircraft
            {
                MCN = "GC7115600",
                Buno = "168661",
                SysReason = "35 hrs",
                InitiateDate = DateTime.Now,
            };

            //Act
            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(aircraft, new ValidationContext(aircraft), validationResults, true);

            //Assert
            Assert.IsTrue(actual, "Expected validation to succeed.");
            Assert.AreEqual(0, validationResults.Count, "Unexpected number of validation errors.");
        }
        [TestMethod]
        public void Validate_Person()
        {
            //Arrange
            var person = new IdentityUser
            {
                Email = "goweb@outlook.com",
                UserName = "gow3busa",
                PasswordHash = "Pa55word"
            };

            //Act
            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(person, new ValidationContext(person), validationResults, true);

            //Assert
            Assert.IsTrue(actual, "Expected validation to succeed.");
            Assert.AreEqual(0, validationResults.Count, "Unexpected number of validation errors.");
        }
    }
}
