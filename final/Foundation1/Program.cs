using System;

class Program
{
    static void Main(string[] args)
    {   
        List<string> vidList = new List<string>();
        
        Console.WriteLine("Hello Foundation1 World!");
        Video video1 = new Video();
        Comment comment1 = new Comment();
        video1._title = "Preparation for the Second Coming";
        video1._author = "Dallin H. Oaks, General Conference";
        video1._length = "1045";
        comment1._commenterName = "Haddie";
        comment1._commentText = "That was a beautiful video. What an amazing temple in the desert.";
        video1.DisplayInfo();
        comment1.DisplayComment();
        
        
        //Console.WriteLine();
        Video video2 = new Video();
        Comment comment2 = new Comment();
        video2._title = "Richmond Virginia Temple Completed";
        video2._author = "Church Newsroom";
        video2._length = "282";
        comment2._commenterName = "TiffaneeO";
        comment2._commentText = "This temple is amazing.";
        video2.DisplayInfo();
        comment2.DisplayComment();
        //video.VideoList();

        // Console.WriteLine();
        Video video3 = new Video();
        Comment comment3 = new Comment();
        video3._title = "Mesa Arizona Temple Renovation Complete";
        video3._author = "Church Newsroom";
        video3._length = "662";
        comment3._commenterName = "MikeO";
        comment3._commentText = "How beautifule is this temple";
        video3.DisplayInfo();
        comment3.DisplayComment();
        video3.VideoList();

        //Console.WriteLine();
        Video video4 = new Video();
        Comment comment4 = new Comment();
        video4._title = "Salt Lake Temple Renovation: September 2020 Update";
        video4._author = "Church Newsroom";
        video4._length = "307";
        comment4._commenterName = "Rubie";
        comment4._commentText = "I went downtown and saw how much working was being done.\n I was shocked at what is being done to the church sites. It will be a beautiful sit when completed.";
        video4.DisplayInfo();
        comment4.DisplayComment();
        //video.VideoList();

        //Console.WriteLine();
        Video video5 = new Video();
        Comment comment5 = new Comment();
        video5._title = "Our Strengths Can Become Our DownFall";
        video5._author = "Dallin H. Oaks";
        video5._length = "265";
        comment5._commenterName = "Ellie";
        comment5._commentText = "This was a wonderful message from Elder Oaks.";
        video5.DisplayInfo();
        comment5.DisplayComment();

        
    }
}