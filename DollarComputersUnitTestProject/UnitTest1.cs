﻿using System;
using COMP123_S2019_Assignment5.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DollarComputersUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThatSelectFormHasLoadedDataSource()
        {
            // arrange
            SelectForm selectForm;

            // act
            selectForm = new SelectForm();

            // assert

            Assert.IsTrue(selectForm.HasLoadedDataSource());
        }
    }
}
