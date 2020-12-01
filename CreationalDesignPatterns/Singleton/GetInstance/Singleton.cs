﻿namespace GetInstance
{
    public class Singleton
    {
        // eager loading
        //private readonly Singleton instance = new Singleton();
        private static Singleton instance;

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
