namespace BackEnd_Test.Base
{
    public class TestSettings
    {
        private static readonly Settings settings;
        static TestSettings()
        {
            settings ??= new Settings();
        }
       
        //Pet
        public static string BaseUrlPetStore => settings.GetConfig().PetStore.baseURL.ToString();
        public static string GetPetStore => settings.GetConfig().PetStore.getPet.ToString();
        public static string AddPetPetStore => settings.GetConfig().PetStore.addPet.ToString();
        public static string UpdatePetPetStore => settings.GetConfig().PetStore.updatePet.ToString();
        public static string GetPetByStatusPetStore => settings.GetConfig().PetStore.getPetByStatus.ToString();

    }
}
