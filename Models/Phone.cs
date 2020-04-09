namespace Old_Phones.Models
{
    public abstract class Phone 
{
    private string _versionNumber;
    private int _batteryPercentage;
    private string _carrier;
    private string _ringTone;
    public string vNumber{
        get{
            return _versionNumber;
        }
    }
    public int bpercent{
        get{
            return _batteryPercentage;
        }
    }
    public string phoneCarrier{
        get{
            return _carrier;
        }
    }
    public string phoneTone{
        get{
            return _ringTone;
        }
    }
    public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone){
        _versionNumber = versionNumber;
        _batteryPercentage = batteryPercentage;
        _carrier = carrier;
        _ringTone = ringTone;
}
    // abstract method. This method will be implemented by the subclasses
    public abstract void DisplayInfo();
    // public getters and setters removed for brevity. Please implement them yourself
}
        
}