using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);
        Task<ProductViewModel> GetById(int productId, string languageId);

        Task<bool> UpdatePrice(int productId,decimal newPrice);

        Task<bool> UpdateStock(int productId,int addedQuantity);

        Task AddViewCount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        Task<int> AddImages(int productId, ProductImageViewModel productImage);
        Task<int> RemoveImages(int imageId);
        Task<int> UpdateImages(int imageId, ProductImageViewModel productImage);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
