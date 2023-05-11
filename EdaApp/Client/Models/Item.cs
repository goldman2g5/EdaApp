namespace EdaApp.Client.Models
{
    public class Item
    {
        public string name;
        public int price;
        public string img;
        public string description;
        public string sale;
        public bool isnew;

        public string getpng() => name + ".png";
    }
}
