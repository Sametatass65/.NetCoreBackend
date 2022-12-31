using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFavoriteDal : EfEntityRepositoryDal<Favorite, NortwindContext>, IFavoriteDal
    {
        public List<FavoriteProductsDto> GetFavoriteProducts(int userId)
        {
            using (var context = new NortwindContext())
            {
                var result = from f in context.Favorities
                             join p in context.Products
                                 on f.ProductId equals p.ProductId
                             where  userId == f.UserId
                             select new FavoriteProductsDto 
                                { 
                                 ProductId = p.ProductId ,
                                 CategoryId = p.CategoryId,
                                 FavorityId = f.Id,
                                 ProductName = p.ProductName
                                };
                return result.ToList();

            }
        }
    }
}
