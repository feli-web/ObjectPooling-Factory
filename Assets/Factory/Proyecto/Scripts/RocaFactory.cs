using UnityEngine;

public class RocaFactory : Factory
{
    private GameObject rocaPrefab;

    public RocaFactory(GameObject prefab)
    {
        rocaPrefab = prefab;
    }

    public override GameObject CreateObject()
    {
        return GameObject.Instantiate(rocaPrefab);
    }
}
