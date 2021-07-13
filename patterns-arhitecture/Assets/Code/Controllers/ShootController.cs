namespace MonkeyInTheSpace.GeekBrains
{
    internal class ShootController : IController
    {
        private IUserFireProxy userFireProxy;
        private IShoot shoot;

        public ShootController(IUserFireProxy userFireProxy, IShoot shoot)
        {
            this.userFireProxy = userFireProxy;
            this.shoot = shoot;
        }
    }
}