
using AventStack.ExtentReports.Tests.Parallel;

namespace BackEnd_Tests.Tests.PetsStore
{
    [TestFixture, Category("PetShop"), Category("Jenkins")]
    public class PetStrore_Tests : BaseFixture
    {
        enum Status
        {
            available,
            pending,
            sold
        }

        [Test]
        public void AddPet_HappyFlow()
        {
            var category = new Category()
            {
                id = 1,
                name = "Test",
            };

            List<string> photoList = new List<string>();
            photoList.Add("url1");
            photoList.Add("url2");

            var tag1 = new Tag()
            {
                id = 1,
                name = "Tag1",
            }; 
            var tag2 = new Tag()
            {
                id = 2,
                name = "Tag2",
            };

            List<Tag> tags = new List<Tag>();
            tags.Add(tag1);
            tags.Add(tag2);

            var body = new AddPetShopRequest()
            {
                id = 101,
                category = category,
                name = "Tstname",
                photoUrls = photoList,
                tags = tags,
                status = Status.available.ToString()
            };

            var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            var uri = new Uri($"{TestSettings.BaseUrlPetStore}{TestSettings.AddPetPetStore}");
            var response = HttpClientBasic.SendPostAsync<AddPetShopResponse>(uri, content).Result;
            Assert.Multiple(() =>
            {
                Assert.That(response.category.name, Is.EqualTo(category.name));

            });
        }
        [Test]
        public void test()
        {
            Assert.Fail();
        }
    }
}
