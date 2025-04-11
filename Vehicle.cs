namespace LexiconOvning3;

abstract class Vehicle
{
    public Vehicle()
    {
         VehicleHandler.vehicles.Add(this);
        
    }
    public Vehicle(string brand,string model, int year, double weight)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.weight = weight;
        VehicleHandler.vehicles.Add(this);
    }
    public string VehicleType = "";
    private string brand;
    private string model;
    private int year;
    private double weight;
    private const int MinCharacters = 2;
    private const int MaxCharacters = 20;
    private const int YearCarWasInvented = 1886;


    public string Brand {
        get 
        { return brand; }
        set
        {
            if (value.Length >= 2 && value.Length <= 20) brand = value;
            else throw new ArgumentException(wrongAmountOfCharactersMessage(value.Length, "brand"));
        }
    }
    public string Model
    {
        get
        { return model; }
        set
        {
            if (2 <= value.Length && value.Length <= 20) model = value;
            else throw new ArgumentException(wrongAmountOfCharactersMessage(value.Length, "model"));
        }
    }
    public int Year
    {
        get
        { return year; }
        set
        {
            if (value >= YearCarWasInvented && value <= DateTime.Now.Year) year = value;
            else throw new ArgumentException(yearOutOfBounds(value));
        }
    }

    private string yearOutOfBounds(int value)
    {
        return $"Although time travel is cool, it creates an unveildy amount of paradoxes. Don't try to create the car {(value < YearCarWasInvented ? "before it was even invented" : "in the future")}.";        
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value > 0) weight = value;
            else throw new ArgumentException("A car with a negative weight is not supported by our current laws of physics, please enter a positive weight. (or become a mad scientist, maybe you can write new laws?)");
        }
    }

    private string wrongAmountOfCharactersMessage(int length, string about)
    {
        string fewOrMany;
        string leastOrMost;
        string minOrMax;
        if(length < MinCharacters)
        {
            fewOrMany = "few";
            leastOrMost = "atleast";
            minOrMax = MinCharacters.ToString();
        }
        else
        {
            fewOrMany = "many";
            leastOrMost = "atmost";
            minOrMax = MaxCharacters.ToString();
        }
            return $"To {fewOrMany} characters in {about} name, needs to be {leastOrMost} {minOrMax} characters";
    }
    public abstract void StartEngine();

    public virtual void Stats()
    {
        Console.WriteLine($"Brand: {brand}\nModel: {model}\nYear of manufacture: {year}\nWeight: {weight} kg");
    }

    public override string ToString()
    {
        return VehicleType.ToString();
    }
}
