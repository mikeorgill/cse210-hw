using System.Collections.Generic;

class Reference{
    public string scripture = " ";
    public static string _reference(){
    
    //Nephi 1:1
    string verse1 = @"1 Nephi 1:1, I, Nephi, having been aborn of bgoodly cparents, therefore I was dtaught somewhat 
in all the learning of my father; and having seen many eafflictions in the course of my days, nevertheless, 
having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness 
and the mysteries of God, therefore I make a frecord of my proceedings in my days."; 
    // 1 Nephi 10:6       
    string verse2 = @"1 Nephi 10:6, Wherefore, all mankind were in a alost and in a bfallen state, and ever 
would be save they should rely on this Redeemer.";
    // 1 Nephi 10:7    
    string verse3 = @"1 Nephi 10:7, And he spake also concerning a aprophet who should come before the Messiah, 
to prepare the way of the Lord";
    // Jarom 1:9
    string verse4 = @"Jarom 1:9, And thus being prepared to meet the Lamanites, they did not prosper against us. 
But the word of the Lord was verified, which he spake unto our fathers, saying that: aInasmuch as 
ye will keep my commandments ye shall bprosper in the land.";
    //Mormon 4:3
    string verse5 = @"Mormaon 4:3, And the remainder did flee and join the inhabitants of the city Teancum. 
Now the city Teancum lay in the borders by the seashore; and it was also near the city aDesolation.";
    
    Random rand = new Random();
    int randVerse = rand.Next(1, 5);

    string scripture = " ";

        if (randVerse == 1) {
                scripture = verse1;
        }
        else if (randVerse == 2){
                 scripture = verse2 + verse3;
        }
        else if (randVerse == 3){
                 scripture = verse3;
        }
        else if (randVerse == 4){
                 scripture = verse4;
        }
        else if (randVerse == 5){
                scripture = verse5;
        }
         
        return scripture;
    }

}
