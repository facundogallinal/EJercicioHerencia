using System;
using Ucu.Poo.Twitter;

namespace Library
{
    public class BaseRepository
    {
        protected void TweetPhoto(string text, string pathToImage)
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter(text, @pathToImage));
        }
    }
}