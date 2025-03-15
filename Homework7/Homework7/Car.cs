public abstract class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public abstract bool Validate();
    public override string ToString() => $"ID: {Id}, Tên: {Name}, Hãng: {Brand}, Giá: {Price}, SL: {Quantity}";
}