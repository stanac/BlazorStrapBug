namespace BlazorStrapBug;

class Model
{
    public Model(string name)
    {
        Name = name;
    }

    public bool IsSelected { get; set; }
    public string Name { get; set; } = "";
}