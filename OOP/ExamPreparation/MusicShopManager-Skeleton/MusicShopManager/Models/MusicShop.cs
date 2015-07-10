namespace MusicShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using MusicShopManager.Interfaces;

    public class MusicShop : IMusicShop
    {
        private string name;

        public MusicShop(string name)
        {
            this.Name = name;
            this.Articles = new List<IArticle>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The Name is required.");
                }

                this.name = value;
            }
        }

        public IList<IArticle> Articles { get; private set; }


        public void AddArticle(IArticle article)
        {
            this.Articles.Add(article);
        }

        public void RemoveArticle(IArticle article)
        {
            this.Articles.Remove(article);
        }

        public string ListArticles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("===== {0} =====", this.Name));
            if (this.Articles.Count == 0)
            {
                sb.AppendLine("The shop is empty. Come back soon.");
            }
            else
            {
                var microfones = this.Articles.Where(x => x is Microphone);
                if (microfones.Any())
                {
                    sb.AppendLine("----- Microphones -----");
                    foreach (var item in microfones.OrderBy(x => x.Make).ThenBy(x => x.Model))
                    {
                        sb.Append(item);
                    }
                }

                var drums = this.Articles.Where(x => x is Drums);
                if (drums.Any())
                {
                    sb.AppendLine("----- Drums -----");
                    foreach (var item in drums.OrderBy(x => x.Make).ThenBy(x => x.Model))
                    {
                        sb.Append(item);
                    }
                }

                var elGuitars = this.Articles.Where(x => x is ElectricGuitar);
                if (elGuitars.Any())
                {
                    sb.AppendLine("----- Electric guitars -----");
                    foreach (var item in elGuitars.OrderBy(x => x.Make).ThenBy(x => x.Model))
                    {
                        sb.Append(item);
                    }
                }

                var acGuitars = this.Articles.Where(x => x is AcousticGuitar);
                if (acGuitars.Any())
                {
                    sb.AppendLine("----- Acoustic guitars -----");
                    foreach (var item in acGuitars.OrderBy(x => x.Make).ThenBy(x => x.Model))
                    {
                        sb.Append(item);
                    }
                }

                var bassGuitars = this.Articles.Where(x => x is BassGuitar);
                if (bassGuitars.Any())
                {
                    sb.AppendLine("----- Bass guitars -----");
                    foreach (var item in bassGuitars.OrderBy(x => x.Make).ThenBy(x => x.Model))
                    {
                        sb.Append(item);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
