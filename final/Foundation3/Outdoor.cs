public class Outdoor :Event
{
    //Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
     private string _gatherings;
     private string _limitedAttendance;
     private string _weatherForecast;
     private string _location;

     public Outdoor(string eventType, string eventInfo, string title, string date, 
                     string address, string time, string description, string location) : 
                     base(eventType, eventInfo, title, date, address, time, description)
     {
        _location = location;
        
     }

     public string GetGathering(string gatherings)
     {
        return _gatherings = gatherings;
     }

     public string GetLimitedAttendance(string attendees)
     {
        return _limitedAttendance = attendees;
     }

     public string GetWeather(string weather)
     {
        return _weatherForecast = weather;
     }
}