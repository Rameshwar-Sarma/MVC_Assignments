using System;

namespace SingltonDesignPattern

{
    internal class Program
    {
        /// <summary>
        /// Main method is sused to create an instance and execute for a Singleton Class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        { 
             // creating a key for the room
             RoomKey key = RoomKey.getRoomKey();

            // user1 requestedto use the room
             key.useRoom();

            // user2 requested to use the room, while user1 using the room
             key.useRoom();

            // the user who is using the room (i.e. user1) released the room
             key.releaseRoom();

            // user 2 requested and occupies the room
             key.useRoom();

            // user 2 released the room 
             key.releaseRoom();
        
            Console.ReadLine();
        }
    }
}
