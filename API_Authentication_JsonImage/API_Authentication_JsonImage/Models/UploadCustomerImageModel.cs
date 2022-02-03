using System.ComponentModel.DataAnnotations;

namespace API_Authentication_JsonImage.Models
{
    public class UploadCustomerImageModel
    {
        [Key]
        public string Id { get; set;}
        public string Description { get; set; }
        public string ImageData { get; set; }
    }
}