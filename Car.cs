namespace StaticExamples
{
    /// <summary>
    /// A very simple representation of a car
    /// </summary>
    public class Car
    {
        #region Instance fields
        private string _licensePlate;
        private int _price;

        public static int CarCount;
        public static int PlateCount;
        public static int PriceCount;

        #endregion
        public static int _PrintUsageStats;

        #region Constructor
        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
            CarCount = +1;
        }
        #endregion

        #region Properties
        public string LicensePlate
        {
            get {PlateCount = +1; return _licensePlate; }
            set {PlateCount = +1; _licensePlate = value; }
            
        }
        public int Price
        {
            get {PriceCount = +1; return _price; }
            set {PriceCount = +1; _price = value; }
            
        } 

        public static int _Carcount { get => CarCount; }
        public static int _PlateCount { get => PlateCount; }
        public static int _PriceCount { get => PriceCount; }
        public static void PrintUsageStats()
        {
        System.Console.WriteLine($"Carcount = {_Carcount} Platecount = {_PlateCount} Pricecount = {_PriceCount}");

        }

        #endregion
    }
}