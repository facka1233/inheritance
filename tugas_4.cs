public class Person 
{
    public string name { get; set; }
    public int age { get; set; }
    public Person (string nama,int umur)
    {
       name = nama;
        age = umur;
    }
    public string getname()
    {
        return name;
 
    }
    public int getage()
    {
        return age;
    }


    public void getnameandage()
    {
        Console.WriteLine("The person has name: {0} and age: {1}", getname(), getage());
 }
}
public class Teacher : Person
{
    public Teacher(string nama, int umur, string NIK, string matkul) : base(nama, umur)
    {
    }

    public string teacherid { get; set; }
    public string subject { get; set; }
}
public class Student : Person
{
    public Student(string nama, int umur, string nim, string mail) : base(nama, umur)
    {
    }

    public string studentid { get; set; }
    public string email { get; set; }
}
public class program
{
    static void Main(string[] args)
    {
        Person person = new Person ("Mike", 20);
        person.getnameandage();

        Teacher teacher = new Teacher("Thomas", 30, "1233", "math");
        teacher.getnameandage();

        Student student = new Student("Sara", 19, "123", "sara@gmail.com");
        student.getnameandage();

        Console.ReadKey(); 
    }
}
