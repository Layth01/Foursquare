using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FoursquareDemo.Models
{
    public class FoursquareVenues
    {
        public Meta meta { get; set; }
        public Response response { get; set; }
    }

    public class Meta
    {
        public int code { get; set; }
        public string requestId { get; set; }
    }

    public class Response
    {
        public Suggestedfilters suggestedFilters { get; set; }
        public int suggestedRadius { get; set; }
        public string headerLocation { get; set; }
        public string headerFullLocation { get; set; }
        public string headerLocationGranularity { get; set; }
        public int totalResults { get; set; }
        public Suggestedbounds suggestedBounds { get; set; }
        public Group[] groups { get; set; }
    }

    public class Suggestedfilters
    {
        public string header { get; set; }
        public Filter[] filters { get; set; }
    }

    public class Filter
    {
        public string name { get; set; }
        public string key { get; set; }
    }

    public class Suggestedbounds
    {
        public Ne ne { get; set; }
        public Sw sw { get; set; }
    }

    public class Ne
    {
        public float lat { get; set; }
        public float lng { get; set; }
    }

    public class Sw
    {
        public float lat { get; set; }
        public float lng { get; set; }
    }

    public class Group
    {
        public string type { get; set; }
        public string name { get; set; }
        public Item[] items { get; set; }
    }

    public class Item
    {
        public Reasons reasons { get; set; }
        public Venue venue { get; set; }
        public Tip[] tips { get; set; }
        public string referralId { get; set; }
    }

    public class Reasons
    {
        public int count { get; set; }
        public Item1[] items { get; set; }
    }

    public class Item1
    {
        public string summary { get; set; }
        public string type { get; set; }
        public string reasonName { get; set; }
    }

    public class Venue
    {
        public string id { get; set; }
        public string name { get; set; }
        public Contact contact { get; set; }
        public Location location { get; set; }
        public Category[] categories { get; set; }
        public bool verified { get; set; }
        public Stats stats { get; set; }
        public float rating { get; set; }
        public string ratingColor { get; set; }
        public int ratingSignals { get; set; }
        public Beenhere beenHere { get; set; }
        public Hours hours { get; set; }
        public Photos photos { get; set; }
        public Herenow hereNow { get; set; }
        public Featuredphotos featuredPhotos { get; set; }
        public string url { get; set; }
        public Price price { get; set; }
        public bool allowMenuUrlEdit { get; set; }
        public bool hasMenu { get; set; }
        public Menu menu { get; set; }
        public Venuepage venuePage { get; set; }
        public bool venueRatingBlacklisted { get; set; }
        public string storeId { get; set; }
        public Delivery delivery { get; set; }
    }

    public class Contact
    {
        public string twitter { get; set; }
        public string facebook { get; set; }
        public string facebookUsername { get; set; }
        public string facebookName { get; set; }
        public string phone { get; set; }
        public string formattedPhone { get; set; }
    }

    public class Location
    {
        public string address { get; set; }
        public string crossStreet { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
        public Labeledlatlng[] labeledLatLngs { get; set; }
        public int distance { get; set; }
        public string cc { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string[] formattedAddress { get; set; }
        public string postalCode { get; set; }
    }

    public class Labeledlatlng
    {
        public string label { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
    }

    public class Stats
    {
        public int checkinsCount { get; set; }
        public int usersCount { get; set; }
        public int tipCount { get; set; }
    }

    public class Beenhere
    {
        public int count { get; set; }
        public bool marked { get; set; }
        public int lastCheckinExpiredAt { get; set; }
    }

    public class Hours
    {
        public bool isOpen { get; set; }
        public bool isLocalHoliday { get; set; }
        public string status { get; set; }
    }

    public class Photos
    {
        public int count { get; set; }
        public Group1[] groups { get; set; }
    }

    public class Group1
    {
        public string type { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public Item2[] items { get; set; }
    }

    public class Item2
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public User user { get; set; }
        public string visibility { get; set; }
    }

    public class User
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public Photo photo { get; set; }
    }

    public class Photo
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Herenow
    {
        public int count { get; set; }
        public string summary { get; set; }
        public Group2[] groups { get; set; }
    }

    public class Group2
    {
        public string type { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public object[] items { get; set; }
    }

    public class Featuredphotos
    {
        public int count { get; set; }
        public Item3[] items { get; set; }
    }

    public class Item3
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public User1 user { get; set; }
        public string visibility { get; set; }
    }

    public class User1
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public Photo1 photo { get; set; }
    }

    public class Photo1
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Price
    {
        public int tier { get; set; }
        public string message { get; set; }
        public string currency { get; set; }
    }

    public class Menu
    {
        public string type { get; set; }
        public string label { get; set; }
        public string anchor { get; set; }
        public string url { get; set; }
        public string mobileUrl { get; set; }
        public string externalUrl { get; set; }
    }

    public class Venuepage
    {
        public string id { get; set; }
    }

    public class Delivery
    {
        public string id { get; set; }
        public string url { get; set; }
        public Provider provider { get; set; }
    }

    public class Provider
    {
        public string name { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
        public string pluralName { get; set; }
        public string shortName { get; set; }
        public Icon icon { get; set; }
        public bool primary { get; set; }
    }

    public class Icon
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Tip
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public string canonicalUrl { get; set; }
        public Likes likes { get; set; }
        public bool logView { get; set; }
        public int agreeCount { get; set; }
        public int disagreeCount { get; set; }
        public Todo todo { get; set; }
        public User2 user { get; set; }
        public Photo3 photo { get; set; }
        public string photourl { get; set; }
        public string url { get; set; }
        public string lastVoteText { get; set; }
        public int lastUpvoteTimestamp { get; set; }
    }

    public class Likes
    {
        public int count { get; set; }
        public object[] groups { get; set; }
        public string summary { get; set; }
    }

    public class Todo
    {
        public int count { get; set; }
    }

    public class User2
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public Photo2 photo { get; set; }
        public string type { get; set; }
    }

    public class Photo2
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Photo3
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public Source source { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string visibility { get; set; }
    }

    public class Source
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
