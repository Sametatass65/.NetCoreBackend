using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.Validation.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [SecuredOperation("product.add,admin")]
        //[ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
           /* ProductValidator validationRules = new ProductValidator();
            ValidationTool.Validate(validationRules, product);*/
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
            
        }

        public IResult Delete(Product product)
        {
            
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }
        [CacheAspect]
        public IDataResult<List<Product>> GetAll()
        {
            return new DataSuccessResult<List<Product>>(_productDal.GetAll(),Messages.ProductGetAll);
        }

        public IDataResult<List<Product>> GetByCategoryId(int categoryId)
        {
            return new DataSuccessResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == categoryId).ToList(),Messages.ProductGetByCategoryId);
        }

        public IDataResult<Product> GetById(int id)
        {
            return new DataSuccessResult<Product>(_productDal.Get(p => p.ProductId == id), Messages.ProductGetById);
        }
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
