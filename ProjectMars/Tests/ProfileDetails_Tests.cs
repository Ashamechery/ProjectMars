using NUnit.Framework;
using ProjectMars.Utilities;

namespace ProjectMars.Pages
{
    [TestFixture]
    public class ProfileDetails_Tests : CommonDriver
    {
        [Test]
        public void CreateProfileDetails_Test()
            {
            //Profile create page object initialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.CreateProfileDetails(driver,"dummy");
            }
        [Test]
        public void EditProfileDetails_Test()
        {
            //edit
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditProfileDetails(driver,"dummy");
            }
        [Test]
        public void DeleteProfileDetails_Test()

            {
            //delete
            ProfilePage profilePageObj = new ProfilePage();
             profilePageObj.DeleteProfileDetails(driver);

            }
       }
}
