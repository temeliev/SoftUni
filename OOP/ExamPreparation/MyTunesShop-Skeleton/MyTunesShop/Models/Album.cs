namespace MyTunesShop.Models
{
    using System;
    using System.Collections.Generic;

    using MyTunesShop.Interfaces;

    public class Album : IAlbum
    {
        private static readonly int MinYear = DateTime.MinValue.Year;
        private static readonly int MaxYear = DateTime.Now.Year;

        private IPerformer performer;

        private string genre;

        private int year;

        private string title;

        private decimal price;

        public Album(string title, decimal price, IPerformer performer, string genre, int year)
        {
            this.Title = title;
            this.Price = price;
            this.Performer = performer;
            this.Genre = genre;
            this.Year = year;
            this.Songs = new List<ISong>();
        }

        public IPerformer Performer
        {
            get
            {
                return this.performer;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("The performer of an album is required.");
                }

                this.performer = value;
            }
        }

        public string Genre
        {
            get
            {
                return this.genre;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The genre of an album is required.");
                }

                this.genre = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }

            private set
            {
                if (value < MinYear || value > MaxYear)
                {
                    throw new ArgumentException(string.Format("The year of a song must be between {0} and {1}.", MinYear, MaxYear));
                }

                this.year = value;
            }
        }

        public IList<ISong> Songs { get; private set; }


        public void AddSong(ISong song)
        {
            this.Songs.Add(song);
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The title of an album is required.");
                }

                this.title = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price of an album must be non-negative.");
                }

                this.price = value;
            }
        }
    }
}
