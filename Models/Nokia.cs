using System;
namespace Old_Phones.Models {
    public class Nokia : Phone, IRingable 
    {
        public Nokia (string versionNumber, int batteryPercentage, string carrier, string ringTone) : base (versionNumber, batteryPercentage, carrier, ringTone) { }
        public string Ring() {
            // your code here
            string ringTone="Tana tan tan tana tan tan tana tan tan taaaaaaaaaan";
            return ringTone;
        }
        public string Unlock() {
            // your code here
            string Unlock = "Please Enter your Code To Unlock your phone";
            return Unlock;
        }
        public override void DisplayInfo () {
            // your code here            
            Console.WriteLine ($"Nokia : {vNumber}\nBattery Percentage : {bpercent}\nCarrier : {phoneCarrier}\nRingtone : {phoneTone}");

        }
    }

}