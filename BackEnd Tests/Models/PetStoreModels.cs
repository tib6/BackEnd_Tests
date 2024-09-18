namespace BackEnd_Tests.Models
{

    public class AddPetShopRequest
    {
        public int id { get; set; }
        public Category category { get; set; }
        public string name { get; set; }
        public List<string> photoUrls { get; set; }
        public List<Tag> tags { get; set; }
        public string status { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Tag
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class AddPetShopResponse
    {
        public int id { get; set; }
        public Category category { get; set; }
        public string name { get; set; }
        public string[] photoUrls { get; set; }
        public Tag[] tags { get; set; }
        public string status { get; set; }
    }

}
