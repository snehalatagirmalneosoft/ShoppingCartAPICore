using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart.API.Controllers;
using ShoppingCart.BAL.Interfaces;
using ShoppingCart.DTO.DTO;

namespace ShoppingCart.UnitTest
{
    [TestClass]
    public class ProductAPITest
    {
        IProductService productService;

        #region SuccessTest

        [TestMethod]
        public void GetProductListSuccessTest()
        {
            // Arrange
            ProductAPIController controller = new ProductAPIController(productService);

            //Act
            var response = controller.GetProductList();

            // Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GetProductByIdSuccessTest()
        {
            // Arrange
            ProductAPIController controller = new ProductAPIController(productService);

            // Act
            int ProductId = 16;
            var response = controller.GetProductById(ProductId);

            // Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void AddProductSuccessTest()
        {
            // Arrange
            ProductAPIController controller = new ProductAPIController(productService);

            // Act
            ProductDTO product = new ProductDTO();
            product.SubCategoryId = 1025;
            product.ProductName = "dyd";
            product.CreatedOn = Convert.ToDateTime("12/13/2018");
            product.CreatedBy = 4;
            product.Price = 100;
            product.ProductDescription = "sf";
            product.IsActive = true;
            product.Quantity = 5;

            var response = controller.AddProduct(product);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data saved", response);
        }

        [TestMethod]
        public void UpdateSubCategorySuccessTest()
        {
            // Arrange
            ProductAPIController controller = new ProductAPIController(productService);

            // Act
            ProductDTO product = new ProductDTO();
            product.ProductId = 1;
            product.SubCategoryId = 1025;
            product.ProductName = "dyd";
            product.ModifiedOn = Convert.ToDateTime("12/13/2018");
            product.ModifiedBy = 4;
            product.Price = 100;
            product.ProductDescription = "sf";
            product.IsActive = true;
            product.Quantity = 5;

            var response = controller.UpdateProduct(product);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data updated", response);
        }

        public void DeleteProductSuccessTest()
        {
            // Arrange
            ProductAPIController controller = new ProductAPIController(productService);

            // Act
            int ProductId = 1;

            var response = controller.DeleteProduct(ProductId);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data deleted", response);
        }

        #endregion

        #region FailureTest

        [TestMethod]
        public void GetProductListFailureTest()
        {
            // Arrange
            ProductAPIController controller = new ProductAPIController(productService);

            // Act
            var response = controller.GetProductList();

            // Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GetProductByIdFailureTest()
        {
            // Arrange
            ProductAPIController controller = new ProductAPIController(productService);

            // Act
            int ProductId = 16;
            var response = controller.GetProductById(ProductId);

            // Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void AddProductFailureTest()
        {
            // Arrange
            ProductAPIController controller = new ProductAPIController(productService);

            // Act
            ProductDTO product = new ProductDTO();
            product.SubCategoryId = 1025;
            product.ProductName = "dyd";
            product.CreatedOn = Convert.ToDateTime("12/13/2018");
            product.CreatedBy = 4;
            product.Price = 100;
            product.ProductDescription = "sf";
            product.IsActive = true;
            product.Quantity = 5;

            var response = controller.AddProduct(product);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data not saved", response);
        }

        [TestMethod]
        public void UpdateProductFailureTest()
        {
            // Arrange
            ProductAPIController controller = new ProductAPIController(productService);

            // Act
            ProductDTO product = new ProductDTO();
            product.ProductId = 1;
            product.SubCategoryId = 1025;
            product.ProductName = "dyd";
            product.ModifiedOn = Convert.ToDateTime("12/13/2018");
            product.ModifiedBy = 4;
            product.Price = 100;
            product.ProductDescription = "sf";
            product.IsActive = true;
            product.Quantity = 5;

            var response = controller.UpdateProduct(product);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data not updated", response);
        }

        public void DeleteProductFailureTest()
        {
            // Arrange
            ProductAPIController controller = new ProductAPIController(productService);

            // Act
            int ProductId = 1;

            var response = controller.DeleteProduct(ProductId);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data not deleted", response);
        }

        #endregion   
    }
}
