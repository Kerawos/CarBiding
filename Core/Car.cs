using CarBiding.Core;
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
        public IEnumerable<Image> Images { get; set; }
        
        public Image ImageMini { get; set; }

        public Car(int iD, string title, DateTime timeAuctionStart, DateTime timeAuctionEnd, string linkToAuction, string info, List<Image> images)
        {
            this.ID = iD;
            this.Title = title;
            this.TimeAuctionStart = timeAuctionStart;
            this.TimeAuctionEnd = timeAuctionEnd;
            this.LinkToAuction = linkToAuction;
            this.Info = info;
            this.Images = images;
            if (Images.Any())
                this.ImageMini = Images.First();
            else
                this.ImageMini = new Image("");
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
