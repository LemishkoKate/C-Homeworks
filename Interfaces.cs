interface IRemoteControl
{
    void TurnOn();
    void TurnOff();
    void SetChannel(int channel);
}

class TvRemoteControl : IRemoteControl
{
    private bool isOn = false;
    private int currentChannel = 1;

    public void TurnOn()
    {
        isOn = true;
        Console.WriteLine("Телевізор увімкнено");
    }

    public void TurnOff()
    {
        isOn = false;
        Console.WriteLine("Телевізор вимкнено");
    }

    public void SetChannel(int channel)
    {
        if (!isOn)
        {
            Console.WriteLine("Телевізор вимкнено, увімкніть його спочатку!");
            return;
        }
        currentChannel = channel;
        Console.WriteLine($"Телевізор перемкнено на канал {currentChannel}");
    }
}

class RadioRemoteControl : IRemoteControl
{
    private bool isOn = false;
    private int currentChannel = 1;

    public void TurnOn()
    {
        isOn = true;
        Console.WriteLine("Радіо увімкнено");
    }

    public void TurnOff()
    {
        isOn = false;
        Console.WriteLine("Радіо вимкнено");
    }

    public void SetChannel(int channel)
    {
        if (!isOn)
        {
            Console.WriteLine("Радіо вимкнено, увімкніть його спочатку!");
            return;
        }
        currentChannel = channel;
        Console.WriteLine($"Радіо перемкнено на канал {currentChannel}");
    }
}

interface IValidator
{
    bool Validate(string input);
}

class EmailValidator : IValidator
{
    public bool Validate(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return false;

        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(input, pattern);
    }
}

class PasswordValidator : IValidator
{
    public bool Validate(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 6)
            return false;

        bool hasDigit = false;
        foreach (char c in input)
            if (char.IsDigit(c)) hasDigit = true;

        return hasDigit;
    }
}

class Program
{
    static void Main()
    {
        IRemoteControl tv = new TvRemoteControl();
        tv.TurnOn();
        tv.SetChannel(5);
        tv.TurnOff();

        IRemoteControl radio = new RadioRemoteControl();
        radio.TurnOn();
        radio.SetChannel(101);
        radio.TurnOff();

        Console.WriteLine();

        IValidator emailValidator = new EmailValidator();
        string email = "test@example.com";
        Console.WriteLine($"Email {email} valid? {emailValidator.Validate(email)}");

        IValidator passwordValidator = new PasswordValidator();
        string password = "pass123";
        Console.WriteLine($"Password {password} valid? {passwordValidator.Validate(password)}");
    }
}
