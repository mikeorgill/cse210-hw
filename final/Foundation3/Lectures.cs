public class Lectures: Event
{
    //Lectures, which have a speaker and have a limited capacity.
    private string _speaker;
    
    public Lectures(string eventType, string eventInfo, string title, string date, string address, 
                        string time, string description, string speaker) : 
                        base(eventType, eventInfo, title, date, address, time, description)
    {
        _speaker = speaker;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
}