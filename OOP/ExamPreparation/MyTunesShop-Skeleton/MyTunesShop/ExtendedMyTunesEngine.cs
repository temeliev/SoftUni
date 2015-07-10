namespace MyTunesShop
{
    using System;
    using System.Linq;
    using System.Text;

    using MyTunesShop.Interfaces;
    using MyTunesShop.Models;

    public class ExtendedMyTunesEngine : MyTunesEngine
    {
        protected override void ExecuteInsertCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "song_to_album":
                    var album = this.media.FirstOrDefault(p => p is Album && p.Title == commandWords[2]) as Album;
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }

                    var songInAlbum = this.media.FirstOrDefault(x => x is Song && x.Title == commandWords[3]) as Song;

                    if (songInAlbum == null)
                    {
                        this.Printer.PrintLine("The song does not exist in the database.");
                        return;
                    }

                    album.Songs.Add(songInAlbum);
                    this.Printer.PrintLine(
                        "The song {0} has been added to the album {1}.",
                        songInAlbum.Title,
                        album.Title);
                    break;
                case "member_to_band":
                    var band = this.performers.FirstOrDefault(x => x is Band && x.Name == commandWords[2]) as Band;
                    if (band == null)
                    {
                        this.Printer.PrintLine("The band does not exist in the database.");
                        return;
                    }

                    string member = commandWords[3];
                    band.AddMember(member);
                    this.Printer.PrintLine(string.Format("The member {0} has been added to the band {1}.", member, band.Name));
                    break;
                default: base.ExecuteInsertCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteInsertMediaCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "album":
                    var perform = this.performers.FirstOrDefault(p => p.Name == commandWords[5]) as Performer;
                    if (perform == null)
                    {
                        this.Printer.PrintLine("The performer does not exist in the database.");
                        return;
                    }

                    var album = new Album(
                        commandWords[3],
                        decimal.Parse(commandWords[4]),
                        perform,
                        commandWords[6],
                        int.Parse(commandWords[7]));

                    this.media.Add(album);
                    this.mediaSupplies.Add(album, new SalesInfo());
                    this.Printer.PrintLine("Album {0} by {1} added successfully", album.Title, perform.Name);
                    break;
                default:
                    base.ExecuteInsertMediaCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteSupplyCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "album":
                    var album = this.media.FirstOrDefault(x => x is Album && x.Title == commandWords[2]);
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }

                    this.mediaSupplies[album].Supply(int.Parse(commandWords[3]));
                    this.Printer.PrintLine("{0} items of album {1} successfully supplied.", int.Parse(commandWords[3]), album.Title);
                    break;
                default:
                    base.ExecuteSupplyCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteSellCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "album":
                    var album = this.media.FirstOrDefault(x => x is Album && x.Title == commandWords[2]);
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }

                    this.mediaSupplies[album].Sell(int.Parse(commandWords[3]));
                    this.Printer.PrintLine("{0} items of album {1} successfully sold.", int.Parse(commandWords[3]), album.Title);
                    break;
                default:
                    base.ExecuteSellCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteReportMediaCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "album":
                    var album = this.media.FirstOrDefault(s => s is IAlbum && s.Title == commandWords[3]) as IAlbum;
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }
                    this.Printer.PrintLine(this.GetAlbumReport(album));
                    break;
                default:
                    base.ExecuteReportMediaCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteReportPerformerCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "band":
                    var band = this.performers.FirstOrDefault(p => p is Band && p.Name == commandWords[3]) as Band;
                    if (band == null)
                    {
                        this.Printer.PrintLine("The band does not exist in the database.");
                        return;
                    }

                    this.Printer.PrintLine(this.GetBandReport(band));
                    break;
                default:
                    base.ExecuteReportPerformerCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteRateCommand(string[] commandWords)
        {
            switch (commandWords[0])
            {
                case "rate":
                    var song = this.media.FirstOrDefault(s => s is ISong && s.Title == commandWords[2]) as ISong;
                    if (song == null)
                    {
                        this.Printer.PrintLine("The song does not exist in the database.");
                        return;
                    }
                    song.PlaceRating(int.Parse(commandWords[3]));
                    this.Printer.PrintLine("The rating has been placed successfully.");
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteInsertPerformerCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "band":
                    var band = new Band(commandWords[3]);
                    this.InsertPerformer(band);
                    break;
                default:
                    base.ExecuteInsertPerformerCommand(commandWords);
                    break;
            }
        }

        private string GetAlbumReport(IAlbum album)
        {
            var albumSalesInfo = this.mediaSupplies[album];
            StringBuilder albumInfo = new StringBuilder();
            albumInfo.AppendFormat("{0} ({1}) by {2}", album.Title, album.Year, album.Performer.Name).AppendLine()
                .AppendFormat("Genre: {0}, Price: ${1:F2}", album.Genre, album.Price).AppendLine()
                .AppendFormat("Supplies: {0}, Sold: {1}", albumSalesInfo.Supplies, albumSalesInfo.QuantitySold).AppendLine();

            if (album.Songs.Count == 0)
            {
                albumInfo.Append("No songs");
            }
            else
            {
                albumInfo.AppendLine("Songs: ");
                int count = 0;
                foreach (var song in album.Songs)
                {
                    albumInfo.Append(String.Format("{0} ({1})\n", song.Title, song.Duration));
                    count++;
                    if (count == album.Songs.Count)
                    {
                        albumInfo = new StringBuilder(albumInfo.ToString().TrimEnd('\n'));
                    }
                }
            }

            return albumInfo.ToString();
        }

        private string GetBandReport(Band band)
        {
            StringBuilder bandInfo = new StringBuilder();
            bandInfo.AppendFormat("{0}: {1}", band.Name, string.Join(", ", band.Members)).AppendLine();

            if (band.Songs.Count == 0)
            {
                bandInfo.Append("no songs");
            }
            else
            {
                bandInfo.AppendFormat("{0}", string.Join("; ", band.Songs.OrderBy(x => x.Title).Select(x => x.Title)));
            }

            return bandInfo.ToString();
        }
    }
}
