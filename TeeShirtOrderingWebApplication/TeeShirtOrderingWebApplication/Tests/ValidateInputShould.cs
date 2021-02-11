using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeeShirtOrderingWebApplication.Tests
{
    [TestClass]
    public class ValidateInputShould
    {
            [TestMethod]
            public void DetectNulllOrder()
            {   //Arrange
                var order = new Order();
                var validate = new Model.ValidateInput();

                //Act
                Boolean isValid = validate.IsOrderDataNotNull(order);

                //Assert
                Assert.IsFalse(isValid);
            }
        }
    }

