namespace ConsoleApp1.DesignModes.Decorator;

public abstract class Beverage
{
    internal string description = "Unknown Beverage";

    public string GetDescription()
    {
        return description;
    }

    public abstract double Cost();
    public CupSize CupSize { get; set; } = CupSize.Grand;
    public CupSize GetSize() => this.CupSize;
    public void SetSize(CupSize size) => CupSize = size;

}
public enum CupSize
{
    Tall,
    Grand,
    Venti
}