

namespace RollABoll
{
    class GameInitializer
    {
        public GameInitializer(Data data, Controllers controllers)
        {
            var inputInitializer = new InputInitializer();
            var playerFactory = new PlayerFactory(data.playerData);
            var playerInitializer = new PlayerInitializer(playerFactory, inputInitializer.GetInput());
            controllers.Add(inputInitializer);
            controllers.Add(playerInitializer);
            controllers.Add(new InputContoller(inputInitializer.GetInput()));
            controllers.Add(playerInitializer.GetController());
            
        }
    }
}
