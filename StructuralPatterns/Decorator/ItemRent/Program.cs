﻿namespace ItemRent
{
    using System;

    using Decorator.Common;

    public class Program
    {
        public static void Main()
        {
            //Create book
            var book = new Book(Constants.DisplayMicrosoft, Constants.DisplayAspNetCore, 10);
            book.Display();

            //Create video
            var video = new Video(Constants.DisplayNetConference, Constants.DisplayBlazor, 120, 22);
            video.Display();

            Console.WriteLine(PrintMessages.MakingBorrowable, nameof(video).ToLower());

            var borrowableVideo = new BorrowableLibraryItem(video);
            borrowableVideo.BorrowItem(Constants.FirstTestUser);
            borrowableVideo.BorrowItem(Constants.SecondTestUser);

            borrowableVideo.Display();

            borrowableVideo.ReturnItem(Constants.FirstTestUser);

            Console.WriteLine(PrintMessages.ReturnItem, Constants.FirstTestUser, nameof(video).ToLower());
            borrowableVideo.Display();
        }
    }
}
