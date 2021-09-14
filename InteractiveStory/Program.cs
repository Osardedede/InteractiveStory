using System;

Console.WriteLine("Holy shit did you see the class of that bank robery we did?, Bwt what chould I call you?");
string name = Console.ReadLine();
name = name.ToLower();

Console.WriteLine($"Ok {name} Let's se if you are as of a good get away driver as they say. Left or right turn?");
string direction_one = Console.ReadLine();
direction_one = direction_one.ToLower();

if( direction_one == "left"){
Console.WriteLine("Ok towards the city, Not the move I would've made but your the driver.");
Console.WriteLine($"Now {name} do we go down in the tunnels or to the airport");
string direction = Console.ReadLine();
direction = direction.ToLower();
if (direction == "airport") 
{
    // Console.WriteLine($"");
}
}
if( direction_one == "right"){
    Console.WriteLine("Nice, Away from the city away from the cops!");
    Console.WriteLine($"Now {name} should we drive ofroad or on road?");
    string road = Console.ReadLine();
    road = road.ToLower();
    if(road == "ofroad"){
Console.WriteLine($"Now you will realy be put on the test, try to not hit any trees or rocks, but I think we got away.");
Console.WriteLine($"good job {name}!");
Console.ReadLine();
    }


    if(road == "on road"){
Console.WriteLine($"It will take a while to loose the cops but mayby this was the right choice.");
Console.WriteLine("But it was hard to escape the cops on the open road, and was an easy target for the chopper that was folowing you. YOU WERE COUGHT. ");
}
else
{
     Console.WriteLine("U CRASHED AND DIED");

}

}
else
{
    Console.WriteLine("U CRASHED AND DIED");
}

Console.ReadLine();
