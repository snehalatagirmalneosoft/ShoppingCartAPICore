using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.BAL.Interfaces;
using ShoppingCart.BAL.Mapper;
using ShoppingCart.Data.Models;
using ShoppingCart.DTO.DTO;
using ShoppingCart.Repository.Interfaces;
using ShoppingCartArchitecture.Data.Models;

namespace ShoppingCart.BAL.BusinessService
{
   public class CategoryService: ICategoryService
    {
        IUnitOfWork _unitOfWork;
        private readonly IMapperFactory _mapperFactory;
        public CategoryService(IUnitOfWork unitOfWork, IMapperFactory mapperFactory)
        {
            _unitOfWork = unitOfWork;
            _mapperFactory = mapperFactory;
        }

        public List<Category> GetCategoryList()
        {
            var list = _unitOfWork.categoryRepository.GetCategoryList();
            return list;
        }

        public Category GetCategoryById(int CategoryId)
        {
            var list = _unitOfWork.categoryRepository.GetCategoryDetail(CategoryId);
            return list;
        }

        public int DeleteCategory(int CategoryId)
        {
            int result = _unitOfWork.categoryRepository.DeleteCategory(CategoryId);
            _unitOfWork.Commit();
            return result;
        }

        public int AddCategory(CategoryDTO model)
        {
            int result = 0;
            try
            {
                if (model != null)
                {
                    model.CreatedBy = 4;
                    model.CreatedOn = DateTime.Now;
                    model.IsActive = true;
                }
                var category = _mapperFactory.IMapper.Map<CategoryDTO, Category>(model);
                result = _unitOfWork.categoryRepository.AddCategory(category);
                _unitOfWork.Commit();

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int UpdateCategory(CategoryDTO model)
        {
            int result = 0;
            try
            {
                if (model != null)
                {
                    model.CreatedBy = 4;
                    model.CreatedOn = DateTime.Now;
                    model.ModifiedBy = 4;
                    model.ModifiedOn = DateTime.Now;
                }
                var category = _mapperFactory.IMapper.Map<CategoryDTO, Category>(model);
                result = _unitOfWork.categoryRepository.UpdateCategory(category);
                _unitOfWork.Commit();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return result;

        }
    }
}
