using UnityEngine;

public class ArbolFactory : Factory
{
    private GameObject arbolPrefab;

    public ArbolFactory(GameObject prefab)
    {
        arbolPrefab = prefab;
    }

    public override GameObject CreateObject()
    {
        return GameObject.Instantiate(arbolPrefab);
    }
}
