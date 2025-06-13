using UnityEngine;

[CreateAssetMenu(fileName = "CollectibleConfig", menuName = "Level/Collectible Config")]
public class CollectibleConfig : ScriptableObject
{
    [Header("Cantidad de cada tipo")]
    public int fishCount = 10;
    public int heartCount = 3;
    public int skateCount = 2;

    [Header("Área de generación")]
    public Vector2 startPosition = new Vector2(0, 0);
    public Vector2 endPosition = new Vector2(50, 2);

    [Header("Prefabs")]
    public GameObject fishPrefab;
    public GameObject heartPrefab;
    public GameObject skatePrefab;

    [Header("Ajuste sobre suelo")]
    public float upwardOffsetIfNearGround = 0.5f;

    [Header("Layer del suelo")]
    public LayerMask groundLayer;


}
