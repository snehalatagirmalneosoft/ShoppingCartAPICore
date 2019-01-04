using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ShoppingCart.BAL.Interfaces;
using ShoppingCart.BAL.Mapper;
using ShoppingCart.Data.Models;
using ShoppingCart.DTO.DTO;
using ShoppingCart.Repository.Interfaces;
using ShoppingCartArchitecture.Data.Models;

namespace ShoppingCart.BAL.BusinessService
{
   public class ProductService: IProductService
    {
        IUnitOfWork _unitOfWork;
        private readonly IMapperFactory _mapperFactory;
        public ProductService(IUnitOfWork unitOfWork, IMapperFactory mapperFactory)
        {
            _unitOfWork = unitOfWork;
            _mapperFactory = mapperFactory;
        }

        public List<STP_ShowAllProductList> GetProductList()
        {
            var list = _unitOfWork.productRepository.GetProductList();
            return list;
        }

        public STP_ProductDetails GetProductById(int ProductId)
        {
            var list = _unitOfWork.productRepository.GetProductDetail(ProductId);
            return list;
        }

        public int DeleteProduct(int ProductId)
        {
            int result = _unitOfWork.productRepository.DeleteProduct(ProductId);
            _unitOfWork.Commit();
            return result;
        }

        public int AddProduct(ProductDTO model)
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
                DataTable tempProductImages = new DataTable();
                DataColumn dc = new DataColumn("TempId", typeof(int));   //creating first column of datatable
                tempProductImages.Columns.Add(dc);
                dc = new DataColumn("ImageUrl", typeof(String));         //creating second column of datatable 
                tempProductImages.Columns.Add(dc);

                var product = _mapperFactory.IMapper.Map<ProductDTO, Product>(model);
                result = _unitOfWork.productRepository.AddProduct(product, tempProductImages);
                _unitOfWork.Commit();

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int UpdateProduct(ProductDTO model)
        {
            int result = 0;
            try
            {
                if (model != null)
                {
                    model.ModifiedBy = 4;
                    model.ModifiedOn = DateTime.Now;
                }
                DataTable tempProductImages = new DataTable();
                DataColumn dc = new DataColumn("TempId", typeof(int));   //creating first column of datatable
                tempProductImages.Columns.Add(dc);
                dc = new DataColumn("ImageUrl", typeof(String));         //creating second column of datatable 
                tempProductImages.Columns.Add(dc);

                var product = _mapperFactory.IMapper.Map<ProductDTO, Product>(model);
                result = _unitOfWork.productRepository.UpdateProduct(product, tempProductImages);
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
