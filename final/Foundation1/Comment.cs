public class Comment
{
    public string _commenterName;
    public string _commentText;

    public Comment()
    {

    }

    public void DisplayComment()
    {
        Console.WriteLine($"Name of Commenter: {_commenterName}\nComment: {_commentText}");
        Console.WriteLine();
    }
}