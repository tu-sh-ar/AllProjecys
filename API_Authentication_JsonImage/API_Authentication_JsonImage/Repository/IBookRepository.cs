using API_Authentication_JsonImage.Models;
namespace API_Authentication_JsonImage.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Books>> Get();//Threading.Tasks.Task
        Task<Books> Get(int id);
        Task<UploadCustomerImageModel> GetImg(int id);
        Task<Books> Create(Books book);
        Task Update(Books book);
        Task Delete(int id);

        
    }
}
