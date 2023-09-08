using System;

namespace DesignPattern
{
    /// <summary>
    /// The Singleton class is sealed and it has a private constructor, 
    /// so that any other class cannot inherit and can create only one object for the class.
    /// </summary>
    public sealed class Singleton
    {
        // a null instance created for Singleton
        public static Singleton singletonObj = null;
        bool _isAvailable;

        /// <summary>
        /// the instance invoking the private constructor useing GetInstance Method
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            if (singletonObj == null)
            {
                singletonObj = new Singleton();
            }
            else
            {
                throw new Exception("This is Singleton Design Pattern");
            }
            return singletonObj;
        }

        /// <summary>
        /// Private Constructor of Singleton class to Initialize the singletonObj
        /// </summary>
        /// <exception cref="Exception"></exception>
        Singleton()
        {
            // Set up the room singletonObj
            this._isAvailable = true;
        }

        public void UsePattern()
        {
            if (this._isAvailable)
            {
                Console.WriteLine("Using the Pattern");
                this._isAvailable = false;
            }
            else
            {
                Console.WriteLine("Design Pattern is already in use");
            }
        }
        public void ReleasePattern()
        {
            Console.WriteLine("Releasing the Design Pattern");
            this._isAvailable = true;
        }
    }
}
