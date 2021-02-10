using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS133FINALPROJECT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ClientsLeave_IfItsAClient_ReturnsTrue()
        
        {

            //Arrange
            Restaurant restaurant = new Restaurant();

            User newClient = new User();
            newClient.IsClient = true;
            newClient.UserName = "First Client";


            Clan newClan = new Clan();
            newClan.ClanName = "Next Client";

            newClient.ClanInfo = newClan;

            restaurant.CurrentUser = newClient;
            //Act
            User newLeft = new User();
            newLeft.IsClient = true;
            newLeft.UserName = "Six Client";

            Clan newClanLeft = new Clan();
            newClanLeft.ClanName = "Nine Client";
            newLeft.ClanInfo = newClanLeft;
            bool PeopleIntoTheQueue = restaurant.ClientsLeave(newClient);

            //Assert
            Assert.IsTrue(PeopleIntoTheQueue);

        }
    }
}
