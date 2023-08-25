using System;

namespace SingltonDesignPattern
{
    public sealed class RoomKey
    {
        // a null insstance created for RoomKey
        public static RoomKey key = null;

        // variables declared for RoomKey, use of variables explained by their variable names
        int roomNumber;
        bool isAvailable;

        /// <summary>
        /// the instance invoking the private constructor useing getInstance Method
        /// </summary>
        /// <returns></returns>
        public static RoomKey getRoomKey()
        {
            if (key == null)
            {
                key = new RoomKey();
            }
            else
            {
                throw new Exception("This is Singleton class");

            }
            return key;
        }

        /// <summary>
        /// Private Constructor of RoomKey class to Initialize the key
        /// </summary>
        /// <exception cref="Exception"></exception>
        RoomKey()
        {
            // Set up the room key
            this.roomNumber = 101;
            this.isAvailable = true;
        }

        /// <summary>
        /// this method makes the user to use the room with the help of key
        /// </summary>
        public void useRoom()
        {
            if (this.isAvailable)
            {
                Console.WriteLine($"Using room {this.roomNumber}");

                this.isAvailable = false;
            }
            else
            {
                Console.WriteLine($"Room {this.roomNumber} is already in use");
            }
        }

        /// <summary>
        /// this method releases the room from the user
        /// </summary>
        public void releaseRoom()
        {
            Console.WriteLine($"Releasing room {this.roomNumber}");

            this.isAvailable = true;
        }
    }
}
