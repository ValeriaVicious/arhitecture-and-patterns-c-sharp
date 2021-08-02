

namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class GameInitiallization
    {
        #region ClassLifeCycles

        public GameInitiallization(ControllersHandler controllersHandler, GameConfig data)
        {
            var inputInitialization = new InputInitialization();
            var playerInitialization = new PlayerInitialization(data.PlayerConfig);
            var enemiesSpawnerInitialization = new EnemiesSpawnerInitialization(data.EnemySpawnerConfig);

            controllersHandler.Add(enemiesSpawnerInitialization);
            controllersHandler.Add(playerInitialization);
            controllersHandler.Add(inputInitialization);

            controllersHandler.Add(new InputController(inputInitialization.GetInput(), inputInitialization.GetFire()));
            controllersHandler.Add(new MoveController(inputInitialization.GetInput(),
                playerInitialization.Move));
            controllersHandler.Add(new ShootController(inputInitialization.GetFire(),
                playerInitialization.Shoot));
            controllersHandler.Add(new HealthController(playerInitialization.Player));
        }

        #endregion
    }
}