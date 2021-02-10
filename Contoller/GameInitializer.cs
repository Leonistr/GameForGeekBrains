

namespace RollABoll
{
    class GameInitializer
    {
        public GameInitializer(Data data, Controllers controllers)
        {
            var inputInitializer = new InputInitializer();
            var playerFactory = new PlayerFactory(data.playerData);
            var playerInitializer = new PlayerInitializer(playerFactory, inputInitializer.GetInput());
            var BonusFactory = new GoodBonusFactory(data.GoodBonusDatas);
            var GoodBonusInitializer = new GoodBonusInitializer(BonusFactory);
            controllers.Add(GoodBonusInitializer);
            controllers.Add(GoodBonusInitializer.GetControllers());
            controllers.Add(inputInitializer);
            controllers.Add(playerInitializer);
            controllers.Add(new InputContoller(inputInitializer.GetInput()));
            controllers.Add(playerInitializer.GetController());
            
        }
    }
}
