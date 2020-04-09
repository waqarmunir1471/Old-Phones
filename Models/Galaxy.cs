using System;
namespace Old_Phones.Models {
    public class Galaxy : Phone, IRingable {
        public Galaxy (string versionNumber, int batteryPercentage, string carrier, string ringTone) : base (versionNumber, batteryPercentage, carrier, ringTone) { 
            
        }
        public string Ring () {
            // your code here
            string Ringtone = "Doooo Doo Doooo Do DOoo Dooo";
            return Ringtone;
        }

        public string Unlock () {
            // your code here
            string Unlock = $"Galaxy {vNumber} Unlocked with Finger Print Scanner";
            return Unlock;
        }
        public override void DisplayInfo () {
            Console.WriteLine ($"Galaxy : {vNumber}\nBattery Percentage : {bpercent}\nCarrier : {phoneCarrier}\nRingtone : {phoneTone}");
            // your code here            
        }
    }

}