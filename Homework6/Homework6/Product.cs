public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public override string ToString() => $"ID: {Id}, Tên: {Name}, Giá: {Price}, SL: {Quantity}";
}