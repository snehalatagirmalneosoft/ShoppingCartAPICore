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
    public class SubCategoryService: ISubCategoryService
    {
        IUnitOfWork _unitOfWork;
        private readonly IMapperFactory _mapperFactory;
        public SubCategoryService(IUnitOfWork unitOfWork, IMapperFactory mapperFactory)
        {
            _unitOfWork = unitOfWork;
            _mapperFactory = mapperFactory;
        }

        public List<STP_GetAllSubCategories> GetSubCategoryList()
        {
            var list = _unitOfWork.subCategoryRepository.GetSubCategoryList();
            return list;
        }

        public STP_GetSubCategoryDetails GetSubCategoryById(int SubCategoryId)
        {
            var list = _unitOfWork.subCategoryRepository.GetSubCategoryDetail(SubCategoryId);
            return list;
        }

        public int DeleteSubCategory(int SubCategoryId)
        {
            int result = _unitOfWork.subCategoryRepository.DeleteSubCategory(SubCategoryId);
            _unitOfWork.Commit();
            return result;
        }

        public int AddSubCategory(SubCategoryDTO model)
        {
            int result = 0;
            try
            {
                if (model != null)
                {
                    model.CreatedBy = 2;
                    model.CreatedOn = DateTime.Now;
                    model.IsActive = true;
                }
                var category = _mapperFactory.IMapper.Map<SubCategoryDTO, SubCategory>(model);
                result = _unitOfWork.subCategoryRepository.AddSubCategory(category);
                _unitOfWork.Commit();
               
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int UpdateSubCategory(SubCategoryDTO model)
        {
            int result = 0;
            try
            {
                if (model != null)
                {
                    model.CreatedBy = 2;
                    model.CreatedOn = DateTime.Now;
                    model.ModifiedBy = 2;
                    model.ModifiedOn = DateTime.Now;
                }
                var category = _mapperFactory.IMapper.Map<SubCategoryDTO, SubCategory>(model);
                result = _unitOfWork.subCategoryRepository.UpdateSubCategory(category);
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
