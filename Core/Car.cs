using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBiding
{
    public class Car
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime TimeAuctionStart { get; set; }
        public DateTime TimeAuctionEnd { get; set; }
        public string LinkToAuction { get; set; }
        public string Info { get; set; }
        public List<String> Images { get; set; }
        public string ImageMini { get; set; }

        public Car(int iD, string title, DateTime timeAuctionStart, DateTime timeAuctionEnd, string linkToAuction, string info, List<string> images)
        {
            this.ID = iD;
            this.Title = title;
            this.TimeAuctionStart = timeAuctionStart;
            this.TimeAuctionEnd = timeAuctionEnd;
            this.LinkToAuction = linkToAuction;
            this.Info = info;
            this.Images = images;
            this.ImageMini = Images[0];
        }

        public Car(int iD, string title, DateTime timeAuctionStart, DateTime timeAuctionEnd)
        {
            this.ID = iD;
            this.Title = title;
            this.TimeAuctionStart = timeAuctionStart;
            this.TimeAuctionEnd = timeAuctionEnd;
        }

        public Car()
        {

        }
    }

    
}
