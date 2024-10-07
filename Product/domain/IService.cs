
namespace test.api.domain
{
    public interface IService<TModel> where TModel : IModel
    {
        Task<TModel> Execute(int CategoryId);

    }
}