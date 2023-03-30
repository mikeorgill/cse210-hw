public class Event
{
    //Event Title, Description, Date, Time, Address.
    protected string _eventType;
    protected string _eventInfo;
    protected string _title;
    protected string _descripton;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _detail;

    public Event (string eventType, string eventInfo, string title, string date, string address, string time, string description)
    {
        _eventType = eventType;
        _eventInfo = eventInfo;
        _title = title;
        _date = date;
        _address = address;
        _descripton = description;
        _time = time;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _descripton;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public string GetAddress()
    {
        return _address;
    }

    //Standard details - Standard details - Lists the title, description, date, time, and address.
    public void SetStandardDetail()
    {   
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Descripton: {_descripton}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Adress: {_address}\n");
    }
     /*  Full details - Lists all of the above, plus type of event and information specific to that event type. 
    For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP.
    For outdoor gatherings, this includes a statement of the weather.*/
    public void DisplayFullDetail()
    {
        //Event Type
        Console.WriteLine($"Event Type: {_eventType}");
        //Info about type event.
        Console.WriteLine($"Information about Event: {_eventInfo}");
        SetStandardDetail();

    }
    //Short description - Lists the type of event, title and the date.
    public void DisplayShortDetail()
    {
        Console.WriteLine($"Event Type: {_title}");
        Console.WriteLine($"Event Title: {_title}");
        Console.WriteLine($"Date: {_date}\n");
    }
    public string GetDetail(string detail)
    {
        return _detail = detail;
    }

    public void DisplayDetail()
    {
        Console.WriteLine(_detail);
    }

   


    


}