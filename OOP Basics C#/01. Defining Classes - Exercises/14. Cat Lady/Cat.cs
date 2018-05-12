public class Cat
{
    public Cat(string name, string breed, double characteristicValue)
    {
        this.Name = name;
        this.Breed = breed;
        this.CharacteristicValue = characteristicValue;
    }

    public string Name { get; }

    public string Breed { get; }

    public double CharacteristicValue { get; }

    public override string ToString()
    {
        if (this.Breed == "Cymric")
        {
            return $"{this.Breed} {this.Name} {this.CharacteristicValue:F2}";
        }
        else
        {
            return $"{this.Breed} {this.Name} {(int)this.CharacteristicValue}";
        }
    }
}