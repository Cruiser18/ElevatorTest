

public class ButtonClickedEvent : Event {

    public readonly int floorNumber;

    public ButtonClickedEvent(int floorNumber)
    {
        this.floorNumber = floorNumber;
        this.eventType = (int)events.buttonClicked;
    }
}
