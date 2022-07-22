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
      Category.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}