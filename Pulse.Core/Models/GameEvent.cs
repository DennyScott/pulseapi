namespace Pulse.Core.Models
{
    public class GameEvent
    {
        public string Name;
        
        public GameEvent()
        {
            Name = GetType().Name;
        }
    }
}