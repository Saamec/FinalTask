
using System.Dynamic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

BinaryFormatter formatter = new BinaryFormatter();


using (var fs = new FileStream("C:\\Users\\Admin\\Desktop\\Students.dat", FileMode.OpenOrCreate))
{
    Student [] newStudent = (Student[])formatter.Deserialize(fs);
    Console.WriteLine("Объект десериализован");
    //Console.WriteLine($"Имя: {newStudent.Name} --- Группа: {newStudent.Group} --- Дата рождения: {newStudent.DateOfBirth}");
}
Console.ReadLine();

[Serializable]
public class Student
{
    internal string Name { get; set; }
    internal string Group { get; set; }
    internal DateTime DateOfBirth { get; set; }

    public Student(string name, string group, DateTime dateofbirth)
    {
        Name = name;
        Group = group;
        DateOfBirth = dateofbirth;
    }
}