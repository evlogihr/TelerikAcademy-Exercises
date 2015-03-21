namespace MobilePhoneLibrary
{
    using System;

    public class Call
    {
        private DateTime dateTime;

        public Call()
        {
            this.dateTime = DateTime.Now;
        }

        public string Time
        {
            get
            {
                return this.dateTime.ToString("HH:mm:ss");
            }
        }

        public string Date
        {
            get
            {
                return this.dateTime.ToString("dd/MM/yyyy");
            }
        }

        public string DialedPhone { get; set; }

        public uint Duration { get; set; }

        public override string ToString()
        {
            return string.Format("Dialed: {0} - Duration : {1} - Date: {2}", this.DialedPhone, this.Duration, this.Date);
        }
    }
}
