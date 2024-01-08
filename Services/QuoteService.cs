using Inclass1_RM.Models;
using System;

namespace Inclass1_RM.Services
{
    public class QuoteService : IQuoteService
    {
        private List<Quote> _quotes;
        private Random _random;

        public QuoteService()
        {
           _random = new Random();
            _quotes = new List<Quote>()
            {
                new Quote() { Text = "The future belongs to those who believe in the beauty of their dreams", Author = "Eleanor Roosevelt" },
                new Quote() { Text = "The way to get started is to quit talking and begin doing.", Author = "Walt Disney" },
                new Quote() { Text = "If you set your goals ridiculously high and it's a failure, you will fail above everyone else's success.", Author = "James Cameron" },
                new Quote() { Text = "The only thing we have to fear is fear itself.", Author = "Franklin D. Roosevelt" },
                new Quote() { Text = "Well done is better than well said.", Author = "Benjamin Franklin" },
                new Quote() { Text = "Life is a succession of lessons which must be lived to be understood.", Author = "Ralph Waldo Emerson" },
                new Quote() { Text = "Life is made of ever so many partings welded together.", Author = "Charles Dickens" },
                new Quote() { Text = "Life is trying things to see if they work.", Author = "Ray Bradbury" },
                new Quote() { Text = "I find that the harder I work, the more luck I seem to have.", Author = "Thomas Jefferson" },
                new Quote() { Text = "Everything you can imagine is real.", Author = "Pablo Picasso" }

            };
        }

        public Quote GetRandomQuote()
        {
            var randomIndex = _random.Next(0, _quotes.Count);
            var quote = _quotes[randomIndex];
            return quote;

        }
    }
}
