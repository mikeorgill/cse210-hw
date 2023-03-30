public class Receptions: Event
{
    //Receptions, which require people to RSVP, or register, beforehand.
     private string _rsvp;
     private string _register;
     private string _beforehand;
     private string _receptions;

     public Receptions(string eventType, string eventInfo, string title, string date, 
                        string address, string time, string descripiton, string receptions, 
                        string rsvp, string register, string beforehand) : 
                        base(eventType, eventInfo, title, date, address, time, descripiton)
     {
        _receptions = receptions;
        _rsvp = rsvp;
        _register = register;
        _beforehand = beforehand;
     }
     public string GetReception()
     {
        return _receptions;
     }

     public string GetRsvp()
     {
        return _rsvp;
     }

     public string GetRegister()
     {
        return _register;
     }

     public string GetBeforehand()
     {
        return _beforehand;
     }

}