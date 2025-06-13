using UnityEngine;
using System.Collections.Generic;

public class CollectibleBuilder : MonoBehaviour, ICollectibleBuilder
{
    private CollectibleConfig config;
    private List<Vector2> usedPositions = new List<Vector2>();

    public void SetConfig(CollectibleConfig config)
    {
        this.config = config;
    }

    public void BuildCollectibles()
    {
        if (config == null)
        {
            Debug.LogError("No hay configuración asignada al CollectibleBuilder.");
            return;
        }

        SpawnType(config.fishPrefab, config.fishCount, limitGroup: 3, allowCluster: true);
        SpawnType(config.heartPrefab, config.heartCount, minDistance: 5f);
        SpawnType(config.skatePrefab, config.skateCount, minDistance: 5f);
    }

    private void SpawnType(GameObject prefab, int count, int limitGroup = 1, bool allowCluster = false, float minDistance = 2f)
    {
        int spawned = 0;
        int tries = 0;
        int consecutive = 0;

        while (spawned < count && tries < 1000)
        {
            tries++;
            float x = Random.Range(config.startPosition.x, config.endPosition.x);
            float y = Random.Range(config.startPosition.y, config.endPosition.y);
            Vector2 position = new Vector2(Mathf.Round(x * 2) / 2f, Mathf.Round(y * 2) / 2f);

            // Si no se permiten clusters, verifica cercanía
            if (!allowCluster && usedPositions.Exists(p => Vector2.Distance(p, position) < minDistance))
                continue;

            // Verifica cuántos peces consecutivos hay
            if (prefab == config.fishPrefab)
            {
                if (consecutive >= limitGroup)
                {
                    consecutive = 0;
                    continue;
                }
                consecutive++;
            }

            // Comprobamos si hay suelo debajo y elevamos si es necesario
            RaycastHit2D hit = Physics2D.Raycast(position, Vector2.down, 1f, config.groundLayer);
            if (hit.collider != null)
            {
                position.y += config.upwardOffsetIfNearGround;
            }

            // Verifica si ya hay algo en esa posición exacta
            if (usedPositions.Contains(position))
                continue;

            Instantiate(prefab, position, Quaternion.identity);
            usedPositions.Add(position);
            spawned++;
        }

        if (spawned < count)
            Debug.LogWarning($"{prefab.name} solo se colocaron {spawned} de {count} deseados.");
    }

}
