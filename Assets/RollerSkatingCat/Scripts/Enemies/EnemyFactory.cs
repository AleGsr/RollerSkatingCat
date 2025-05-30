using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject ratPrefab;
    public GameObject batPrefab;
    public GameObject gargoylePrefab;

    public Enemy CreateEnemy(EnemyType type, Vector2 position)
    {
        GameObject instance = null;

        switch (type)
        {
            case EnemyType.Rat:
                instance = Instantiate(ratPrefab, position, Quaternion.identity);
                break;
            case EnemyType.Bat:
                instance = Instantiate(batPrefab, position, Quaternion.identity);
                break;
            case EnemyType.Gargoyle:
                instance = Instantiate(gargoylePrefab, position, Quaternion.identity);
                break;
        }

        Enemy enemy = instance.GetComponent<Enemy>();
        enemy.Init();

        return enemy;

    }

}
