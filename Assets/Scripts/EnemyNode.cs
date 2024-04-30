using System;
using UnityEngine;
using UnityEngine.Events;

public class EnemyNode : MonoBehaviour
{
    public EnemyActions[] enemyActions;
    public Enemy currentEnemy;
    public float minTime;
    public float maxTime;
    private float timer;
    private float randomTime;
    public void MoveToPoint(Transform point)
    {
        currentEnemy.transform.position = point.position;

    }
    public void Move(EnemyNode node)
    {
        print("Я сброшу на вас 250 тысячь тонн тротилла");
        node.currentEnemy = currentEnemy;
        currentEnemy.transform.position = node.transform.position;
        currentEnemy.transform.rotation = node.transform.rotation;
        currentEnemy = null;
    }
    private void Start()
    {
        randomTime = UnityEngine.Random.Range(2, 5);
        if (currentEnemy != null)
        {
            currentEnemy.transform.position = transform.position;
        }
    }
    private void Update()
    {
        if (currentEnemy != null)
        {
            timer += Time.deltaTime;
            if(timer >= randomTime)
            {
                timer = 0;
                enemyActions[UnityEngine.Random.Range(0, enemyActions.Length)].onAction.Invoke();
            }
        }
    }
}
[Serializable]
public class EnemyActions
{
    public UnityEvent onAction;

}