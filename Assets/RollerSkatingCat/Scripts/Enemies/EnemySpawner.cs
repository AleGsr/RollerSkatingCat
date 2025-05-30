using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyFactory factory;

    void Start()
    {
        factory.CreateEnemy(EnemyType.Rat, new Vector2(0, 0));
        factory.CreateEnemy(EnemyType.Bat, new Vector2(2, 0));
        factory.CreateEnemy(EnemyType.Gargoyle, new Vector2(4, 0));
    }
}
