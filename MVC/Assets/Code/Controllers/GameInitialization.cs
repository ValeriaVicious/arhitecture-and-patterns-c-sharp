

namespace MVC
{
    internal sealed class GameInitialization
    {
        public GameInitialization(Controllers controllers, Data data)
        {
            var playerFactory = new PlayerFactory(data.Player);
            var inputInitialization = new InputInitialization();
            var playerInitialization = new PlayerInitialization(playerFactory, data.Player.Position);

            var enemyFactory = new EnemyFactory(data.Enemy);
            var enemyInitiallization = new EnemyInitialization(enemyFactory);

            controllers.Add(inputInitialization);
            controllers.Add(playerInitialization);
            controllers.Add(enemyInitiallization);

            controllers.Add(new InputController(inputInitialization.GetInput()));
            controllers.Add(new MoveController(inputInitialization.GetInput(), playerInitialization.GetPlayer(), data.Player));
            controllers.Add(new EnemyMoveController(enemyInitiallization.GetMoveEnemies(),
                playerInitialization.GetPlayer()));
        }
    }
}
