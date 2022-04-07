using ExitGames.Client.Photon;

namespace MyClient.Events
{
    public interface OnEventEvent
    {
        bool OnEvent(EventData eventData);
    }
}
