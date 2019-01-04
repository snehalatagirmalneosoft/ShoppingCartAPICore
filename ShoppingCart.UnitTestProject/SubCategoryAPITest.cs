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
    public class SubCategoryAPITest
    {
        ISubCategoryService subCategoryService;

        #region SuccessTest

        [TestMethod]
        public void GetSubCategoryListSuccessTest()
        {
            // Arrange
            SubCategoryAPIController controller = new SubCategoryAPIController(subCategoryService);

            //Act
            var response = controller.GetSubCategoryList();

            // Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GetSubCategoryByIdSuccessTest()
        {
            // Arrange
            SubCategoryAPIController controller = new SubCategoryAPIController(subCategoryService);

            // Act
            int SubCategoryId = 19;
            var response = controller.GetSubCategoryById(SubCategoryId);

            // Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void AddSubCategorySuccessTest()
        {
            // Arrange
            SubCategoryAPIController controller = new SubCategoryAPIController(subCategoryService);

            // Act
            SubCategoryDTO category = new SubCategoryDTO();
            category.CategoryId = 14;
            category.SubCategoryName = "test";
            category.CreatedBy = 2;
            category.CreatedOn = DateTime.Now;
            category.IsActive = true;

            var response = controller.AddSubCategory(category);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data saved", response);
        }

        [TestMethod]
        public void UpdateSubCategorySuccessTest()
        {
            // Arrange
            SubCategoryAPIController controller = new SubCategoryAPIController(subCategoryService);

            // Act
            SubCategoryDTO category = new SubCategoryDTO();
            category.CategoryId = 14;
            category.SubCategoryId = 1044;
            category.SubCategoryName = "tests";
            category.CreatedBy = 2;
            category.CreatedOn = DateTime.Now;
            category.ModifiedBy = 2;
            category.ModifiedOn = DateTime.Now;
            category.IsActive = true;

            var response = controller.UpdateSubCategory(category);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data updated", response);
        }

        public void DeleteSubCategorySuccessTest()
        {
            // Arrange
            SubCategoryAPIController controller = new SubCategoryAPIController(subCategoryService);

            // Act
            int SubCategoryId = 1044;

            var response = controller.DeleteSubCategory(SubCategoryId);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data deleted", response);
        }

        #endregion

        #region FailureTest

        [TestMethod]
        public void GetSubCategoryListFailureTest()
        {
            // Arrange
            SubCategoryAPIController controller = new SubCategoryAPIController(subCategoryService);

            // Act
            var response = controller.GetSubCategoryList();

            // Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GetSubCategoryByIdFailureTest()
        {
            // Arrange
            SubCategoryAPIController controller = new SubCategoryAPIController(subCategoryService);

            // Act
            int SubCategoryId = 19;
            var response = controller.GetSubCategoryById(SubCategoryId);

            // Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void AddSubCategoryFailureTest()
        {
            // Arrange
            SubCategoryAPIController controller = new SubCategoryAPIController(subCategoryService);

            // Act
            SubCategoryDTO category = new SubCategoryDTO();
            category.CategoryId = 14;
            category.SubCategoryName = "test";
            category.CreatedBy = 2;
            category.CreatedOn = DateTime.Now;
            category.IsActive = true;

            var response = controller.AddSubCategory(category);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data not saved", response);
        }

        [TestMethod]
        public void UpdateSubCategoryFailureTest()
        {
            // Arrange
            SubCategoryAPIController controller = new SubCategoryAPIController(subCategoryService);

            // Act
            SubCategoryDTO category = new SubCategoryDTO();
            category.CategoryId = 14;
            category.SubCategoryId = 1044;
            category.SubCategoryName = "tests";
            category.CreatedBy = 2;
            category.CreatedOn = DateTime.Now;
            category.ModifiedBy = 2;
            category.ModifiedOn = DateTime.Now;
            category.IsActive = true;

            var response = controller.UpdateSubCategory(category);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data not updated", response);
        }

        public void DeleteSubCategoryFailureTest()
        {
            // Arrange
            SubCategoryAPIController controller = new SubCategoryAPIController(subCategoryService);

            // Act
            int SubCategoryId = 19;

            var response = controller.DeleteSubCategory(SubCategoryId);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data not deleted", response);
        }

        #endregion   
    }
}
