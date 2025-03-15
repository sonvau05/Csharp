using System;

public class ConcreteCar : Car
{
    public override bool Validate()
    {
        if (Id <= 0) throw new Exception("ID phải lớn hơn 0");
        if (string.IsNullOrWhiteSpace(Name)) throw new Exception("Tên không được để trống");
        if (string.IsNullOrWhiteSpace(Brand)) throw new Exception("Hãng không được để trống");
        if (Price < 0) throw new Exception("Giá không được âm");
        if (Quantity < 0) throw new Exception("Số lượng không được âm");
        return true;
    }
}