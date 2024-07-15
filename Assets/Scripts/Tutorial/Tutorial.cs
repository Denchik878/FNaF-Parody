using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class Tutorial : MonoBehaviour
{
    private void Start()
    {
        Cat cat = new Cat();
        cat.age = 3;
        cat.name = "Пушыстый ";

        Dog dog = new Dog();
        dog.age = 5;
        dog.name = "Rex";
        

        Dog dog2 = new Dog();
        dog2.age = 3;
        dog2.name = "Tex";
        dog2.father = dog;
        dog2.enemy = cat;

        print(dog2.father);
    }
}
