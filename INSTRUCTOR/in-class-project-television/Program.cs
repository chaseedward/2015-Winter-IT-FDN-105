// File: tv.cs

class Television
{
    private int channel = 0;
    private int volume = 0;

    public bool IsOn
    {
        get { return isOn; }
        set { isOn = value; }
    }

    private bool isOn = false;

    public int Volume
    {
        get { return volume; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                volume = value;
            }
        }
    }

    public void IncreaseVolume()
    {
        volume++; // this is bad
        Volume++; // this good
    }

    public int Channel
    {
        get { return channel; }
        set
        {
            if (value > 0 && value < 50)
            {
                channel = value;
            }
        }
    }
}

class TestTV
{
    static void Main()
    {
        Television tv = new Television();

        if (!tv.IsOn)
        {
            tv.IsOn = true;
        }

        tv.Channel = 3;

        tv.Volume++;
        tv.Volume = tv.Volume + 1;

        tv.Volume++;
        tv.Volume--;
        tv.Volume--;

        tv.IsOn = false;
    }
}