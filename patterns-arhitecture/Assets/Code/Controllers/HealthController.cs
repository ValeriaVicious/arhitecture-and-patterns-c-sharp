namespace MonkeyInTheSpace.GeekBrains
{
    internal class HealthController : ICleanup
    {
        private Player player;

        public HealthController(Player player)
        {
            this.player = player;
        }
    }
}