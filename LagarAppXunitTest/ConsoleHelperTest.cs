using System;
using DocumentFormat.OpenXml.Wordprocessing;
using LagarAppE04.ProductHelper;
using LagarAppE04.Helpers;
using Xunit;

namespace LagarAppXunitTest
{
    public class ConsoleHelperTest
    {
        [Fact]
        public void NewProductShouldBeAsExpected()
        {
            //Arrange
            Product testProduct = new Product();
            //Act

           // testProduct.Price = -10;
            //Assert
            Assert.Throws<ArgumentNullException>(() => testProduct.Price=-10);
        }
    }
}
