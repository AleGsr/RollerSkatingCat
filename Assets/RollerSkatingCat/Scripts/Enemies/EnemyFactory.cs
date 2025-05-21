using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject ratPrefab;
    public GameObject batPrefab;
    public GameObject gargoylePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateEnemy(string type, Vector3 position)
    {
        GameObject enemy = null;

        switch (type)
        {
            case "Rat":
                enemy = Instantiate(ratPrefab, position, Quaternion.identity);
                break;
            case "Bat":
                enemy = Instantiate(batPrefab, position, Quaternion.identity);
                break;
            case "Gargoyle":
                enemy = Instantiate(gargoylePrefab, position, Quaternion.identity);
                break;
        }
    }

}
