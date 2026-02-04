using System.Diagnostics;

namespace Domain.Department.ValueObjects;

public sealed record DepartmentPath
{
    public const char separator = '.';
    private DepartmentPath(string value)
    {
     Value = value;
    }

    public string Value { get; }

    public static DepartmentPath Create (string path)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            throw new ArgumentNullException ("Ошибка! В строке пути ничего нет");
        }
        return new DepartmentPath(path);
        


    }
    

}