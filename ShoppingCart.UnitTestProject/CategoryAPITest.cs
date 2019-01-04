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
    public class CategoryAPITest
    {
        ICategoryService categoryService;

        #region SuccessTest

        [TestMethod]
        public void GetCategoryListSuccessTest()
        {
            // Arrange
            CategoryAPIController controller = new CategoryAPIController(categoryService);

            //Act
            var response = controller.GetCategoryList();

            // Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GetSubCategoryByIdSuccessTest()
        {
            // Arrange
            CategoryAPIController controller = new CategoryAPIController(categoryService);

            // Act
            int CategoryId = 19;
            var response = controller.GetCategoryById(CategoryId);

            // Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void AddCategorySuccessTest()
        {
            // Arrange
            CategoryAPIController controller = new CategoryAPIController(categoryService);

            // Act
            CategoryDTO category = new CategoryDTO();
            category.CategoryName = "test";
            category.CreatedBy = 4;
            category.CreatedOn = DateTime.Now;
            category.IsActive = true;

            var response = controller.AddCategory(category);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data saved", response);
        }

        [TestMethod]
        public void UpdateCategorySuccessTest()
        {
            // Arrange
            CategoryAPIController controller = new CategoryAPIController(categoryService);

            // Act
            CategoryDTO category = new CategoryDTO();
            category.CategoryId = 14;
            category.CategoryName = "tests";
            category.CreatedBy = 4;
            category.CreatedOn = DateTime.Now;
            category.ModifiedBy = 4;
            category.ModifiedOn = DateTime.Now;
            category.IsActive = true;

            var response = controller.UpdateCategory(category);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data updated", response);
        }

        public void DeleteCategorySuccessTest()
        {
            // Arrange
            CategoryAPIController controller = new CategoryAPIController(categoryService);

            // Act
            int CategoryId = 28;

            var response = controller.DeleteCategory(CategoryId);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data deleted", response);
        }

        #endregion

        #region FailureTest

        [TestMethod]
        public void GetCategoryListFailureTest()
        {
            // Arrange
            CategoryAPIController controller = new CategoryAPIController(categoryService);

            // Act
            var response = controller.GetCategoryList();

            // Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GetCategoryByIdFailureTest()
        {
            // Arrange
            CategoryAPIController controller = new CategoryAPIController(categoryService);

            // Act
            int SubCategoryId = 19;
            var response = controller.GetCategoryById(SubCategoryId);

            // Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void AddCategoryFailureTest()
        {
            // Arrange
            CategoryAPIController controller = new CategoryAPIController(categoryService);

            // Act
            CategoryDTO category = new CategoryDTO();
            category.CategoryName = "test";
            category.CreatedBy = 4;
            category.CreatedOn = DateTime.Now;
            category.IsActive = true;

            var response = controller.AddCategory(category);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data not saved", response);
        }

        [TestMethod]
        public void UpdateCategoryFailureTest()
        {
            // Arrange
            CategoryAPIController controller = new CategoryAPIController(categoryService);

            // Act
            CategoryDTO category = new CategoryDTO();
            category.CategoryId = 29;
            category.CategoryName = "tests";
            category.CreatedBy = 4;
            category.CreatedOn = DateTime.Now;
            category.ModifiedBy = 4;
            category.ModifiedOn = DateTime.Now;
            category.IsActive = true;

            var response = controller.UpdateCategory(category);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data not updated", response);
        }

        public void DeleteCategoryFailureTest()
        {
            // Arrange
            CategoryAPIController controller = new CategoryAPIController(categoryService);

            // Act
            int SubCategoryId = 29;

            var response = controller.DeleteCategory(SubCategoryId);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("Data not deleted", response);
        }

        #endregion   
    }
}
