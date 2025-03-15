using System;
using System.Collections.Generic;
using System.Linq;

public class CarManager : ICarManager
{
    private List<Car> cars = new List<Car>();

    public void Add()
    {
        try
        {
            var car = new ConcreteCar
            {
                Id = ValidateInput<int>("ID: ", x => x > 0),
                Name = ValidateInput<string>("Tên: ", x => !string.IsNullOrWhiteSpace(x)),
                Brand = ValidateInput<string>("Hãng: ", x => !string.IsNullOrWhiteSpace(x)),
                Price = ValidateInput<double>("Giá: ", x => x >= 0),
                Quantity = ValidateInput<int>("SL: ", x => x >= 0)
            };
            car.Validate();
            cars.Add(car);
            Console.WriteLine("Thêm thành công!");
        }
        catch (Exception ex) { Console.WriteLine($"Lỗi: {ex.Message}"); }
    }

    public void Display() => cars.ForEach(c => Console.WriteLine(c));

    public void Search(string name) => cars.Where(c => c.Name.ToLower().Contains(name.ToLower()))
        .ToList().ForEach(c => Console.WriteLine(c));

    public void Delete(int id) => cars.Remove(cars.FirstOrDefault(c => c.Id == id));

    public void Sort() => cars = cars.OrderBy(c => c.Price).ToList();

    public void Edit(int id)
    {
        var car = cars.FirstOrDefault(c => c.Id == id);
        if (car == null) { Console.WriteLine("Không tìm thấy!"); return; }
        try
        {
            car.Name = ValidateInput<string>("Tên mới: ", x => !string.IsNullOrWhiteSpace(x));
            car.Brand = ValidateInput<string>("Hãng mới: ", x => !string.IsNullOrWhiteSpace(x));
            car.Price = ValidateInput<double>("Giá mới: ", x => x >= 0);
            car.Quantity = ValidateInput<int>("SL mới: ", x => x >= 0);
            car.Validate();
            Console.WriteLine("Sửa thành công!");
        }
        catch (Exception ex) { Console.WriteLine($"Lỗi: {ex.Message}"); }
    }

    public bool IsEmpty() => cars.Count == 0;

    private T ValidateInput<T>(string prompt, Func<T, bool> condition)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            try
            {
                T value = (T)Convert.ChangeType(input, typeof(T));
                if (condition(value)) return value;
                throw new Exception($"Dữ liệu không hợp lệ!");
            }
            catch { Console.WriteLine("Nhập lại!"); }
        }
    }
}