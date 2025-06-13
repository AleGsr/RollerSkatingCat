using UnityEngine;

public class CollectibleDirector : MonoBehaviour
{
    public CollectibleConfig config;
    public CollectibleBuilder builder;

    void Start()
    {
        if (config == null || builder == null)
        {
            Debug.LogError("Config o Builder no asignados.");
            return;
        }

        builder.SetConfig(config);
        builder.BuildCollectibles();
    }
}
