using UnityEngine;

public class ArbustoFactory : Factory
{
    private GameObject arbustoPrefab;

    public ArbustoFactory(GameObject prefab)
    {
        arbustoPrefab = prefab;
    }

    public override GameObject CreateObject()
    {
        return GameObject.Instantiate(arbustoPrefab);
    }
}
