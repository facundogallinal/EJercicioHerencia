using System;
using Ucu.Poo.Twitter;

namespace Library
{
    public class BaseRepository
    {
        protected void TweetPhoto()
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("text", @"PathToImage.png"));
        }
    }
}