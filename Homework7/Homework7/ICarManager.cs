public interface ICarManager
{
    void Add();
    void Display();
    void Search(string name);
    void Delete(int id);
    void Sort();
    void Edit(int id);
    bool IsEmpty();
}