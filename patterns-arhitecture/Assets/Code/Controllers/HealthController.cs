namespace MonkeyInTheSpace.GeekBrains
{
    internal class HealthController : IController
    {
        private Player player;

        public HealthController(Player player)
        {
            this.player = player;
        }
    }
}