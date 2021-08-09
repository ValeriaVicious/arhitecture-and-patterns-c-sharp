

namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class GameInitiallization
    {
        #region ClassLifeCycles

        public GameInitiallization(ControllersHandler controllersHandler, GameConfig data)
        {
            ServiceLocator.SetService<IViewService>(new ViewViewServices());
            var inputInitialization = new InputInitialization();
            var playerInitialization = new PlayerInitialization(data.PlayerConfig);
            var enemyInitialization = new EnemyInitialization(data.EnemyConfig);
            var enemiesSpawnerInitialization = new EnemiesSpawnerInitialization(data.EnemySpawnerConfig);

            controllersHandler.Add(enemiesSpawnerInitialization);
            controllersHandler.Add(enemyInitialization);
 
            controllersHandler.Add(playerInitialization);
            controllersHandler.Add(inputInitialization);

            controllersHandler.Add(new InputController(inputInitialization.GetInput(), inputInitialization.GetFire(),
                inputInitialization.GetAcceleration()));
            controllersHandler.Add(new MoveController(inputInitialization.GetInput(),
                playerInitialization.Move));
            controllersHandler.Add(new ShootController(inputInitialization.GetFire(),
                playerInitialization.Shoot));
            controllersHandler.Add(new HealthController(playerInitialization.Player));
            controllersHandler.Add(new EnemiesSpawner(data.EnemySpawnerConfig, enemyInitialization.Enemy, data.EnemyConfig));
        }

        #endregion
    }
}