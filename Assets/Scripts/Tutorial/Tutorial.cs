using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class Tutorial : MonoBehaviour
{
    public int a;
    public int b;   
    private void Start()
    {
        Cat cat = new Cat(3, "Пушыстый ");

        Cat cat2 = new Cat(6, "Адольф");
        cat.enemy = cat2;

        Dog dog = new Dog(5, "Rex");
        dog.enemy = cat2;
        cat2.enemy = dog;

        Dog dog2 = new Dog(3, "Tex");
        dog2.father = dog;
        dog2.enemy = cat;

        Mouse mouse = new Mouse(2, "Maus");

        print(SumNumbers(a, b));
    }
    private int SumNumbers(int a, int b)
    {
        return (a + b) * (a - b);
    }
}
