using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorApp.Models;
using System.Collections.Generic;
using System;

namespace VendorApp.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
    //Arrange
    string name = "Test Category";
    Vendor newVendor = new Vendor(name);

    //Act
    string result = newVendor.Name;

    //Assert
    Assert.AreEqual(name, result);
    }
  }
}