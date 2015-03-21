namespace MobilePhoneLibrary
{
    public class Display
    {
        private double size;
        private string numberOfColors;

        public string NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }

        public double Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}
