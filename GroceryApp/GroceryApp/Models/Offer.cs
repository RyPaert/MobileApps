namespace Models
{
    public class Offer
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public Color BgColor { get; set; }

        public Offer(string title, string description, Color bgColor, string code)
        {
            Title = title;
            Description = description;
            Code = code;
            BgColor = bgColor;
        }

        private static  readonly string[] _ightColors = new string[]
        {
            "#e1f1e7", "#dad1f9", "#ffff00", "#d0f200", "#e28083", "#7fbdc7", "#ea978d"
        };
        private static Color RandomColor => Color.FromHex(_ightColors.OrderBy(c => Guid.NewGuid()).First());

        public static IEnumerable<Offer> GetOffers()
        {
            yield return new Offer("Up to 30% off", "Enjoy up to 30% off on all products", RandomColor, "FRT30");
            yield return new Offer("Green Veg Big Sale 50% OFF", "Enjoy our big offer of 50% off on all green vegetables", RandomColor, "500FF");
            yield return new Offer("FLAT 100% OFF", "Flat Rs. 100 off on all exotic fruits and vegetables", RandomColor, "EXT100");
            yield return new Offer("25% OFF on Seasonal Fruits", "Enjoy 25% off on all seasonal fruits", RandomColor, "FRT25");
        }

    }
}
