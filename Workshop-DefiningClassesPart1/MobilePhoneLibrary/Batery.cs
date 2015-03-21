using System.Text;
namespace MobilePhoneLibrary
{
    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType bateryType;

        public BatteryType BateryType
        {
            get { return bateryType; }
            set { bateryType = value; }
        }        

        public int HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        public int HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Model == null)
            {
                result.AppendLine("no batery");
            }
            else
            {
                result.AppendLine(
                    string.Format("Model: {0}", this.Model));
                result.AppendLine(
                    string.Format("Battery Type: {0}", this.BateryType));
                result.AppendLine(
                    string.Format("Hours Idle: {0}", this.HoursIdle));
                result.AppendLine(
                    string.Format("Hours Talk: {0}", this.HoursTalk));
            }

            return result.ToString();
        }
    }
}
