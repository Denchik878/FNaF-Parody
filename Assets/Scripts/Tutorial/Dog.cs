public class Dog : Animal
{
    public Dog father;
    public Animal enemy;
    public Dog(int age, string name)
    {
        this.age = age;
        this.name = name;
    }

    public override string ToString()
    {
        return name;
    }
}