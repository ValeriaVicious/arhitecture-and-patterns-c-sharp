

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

            controllersHandler.Add(enemyInitialization);

            controllersHandler.Add(playerInitialization);
            controllersHandler.Add(inputInitialization);

            controllersHandler.Add(new InputController(inputInitialization.GetInput(), inputInitialization.GetFire(),
                inputInitialization.GetAcceleration()));
            controllersHandler.Add(new MoveController(inputInitialization.GetInput(),
                playerInitialization.Move));
            controllersHandler.Add(new EnemyMoveController(enemyInitialization.Move()));
            controllersHandler.Add(new ShootController(inputInitialization.GetFire(),
                playerInitialization.Shoot, playerInitialization.Player, data.PlayerConfig.ShootCoolDown));
            controllersHandler.Add(new HealthController(playerInitialization.Player, data.PlayerConfig.PlayerHP));
            controllersHandler.Add(new EnemiesSpawnerInitialization(enemyInitialization.GetEnemies()));
       
        }

        #endregion
    }
}