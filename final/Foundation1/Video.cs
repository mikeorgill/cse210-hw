
public class Video
{
    public string _title = "";
    public string _author = "";
    public string _length = "";
    public List<string> videoList = new List<string>();

    public Video()
    {

    }

    public List<string> VideoList()
    {   
        string title = _title;
        string author = _author;
        string length = _length;

        videoList.Add(title);
        videoList.Add(author);
        videoList.Add(length);
        
        return videoList;
    }
    public void DisplayInfo()
    {   
        VideoList();
        Console.WriteLine($"Video: {_title}\nAuthor: {_author}\nLength: {_length}");
    }

    public void DisplayList()
    {
        Console.WriteLine($"Video List: {videoList}");
    }
}