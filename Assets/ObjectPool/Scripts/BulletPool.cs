using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public static BulletPool SharedInstance;

    [Header("Gun")]
    public List<GameObject> pooledGuns;
    public GameObject gunsToPool;
    public int gunsAmountToPool;

    [Header("Catapult")]
    public List<GameObject> pooledCatapult;
    public GameObject catapultToPool;
    public int catapultAmountToPool;

    [Header("Missile")]
    public List<GameObject> pooledMissile;
    public GameObject missileToPool;
    public int missileAmountToPool;
    
    void Awake() 
    {
        SharedInstance = this;
    }
    void Start()
    {
        pooledGuns = new List<GameObject>();
        GameObject a;
        for (int i = 0; i < gunsAmountToPool; i++)
        {
            a = Instantiate(gunsToPool);
            a.SetActive(false);
            pooledGuns.Add(a);
        }
        
        pooledCatapult = new List<GameObject>();
        GameObject b;  
        for (int i = 0; i < catapultAmountToPool; i++)
        {
            b = Instantiate(catapultToPool);
            b.SetActive(false);
            pooledCatapult.Add(b);
        }
        
        pooledMissile = new List<GameObject>();
        GameObject c;
        for (int i = 0; i < missileAmountToPool; i++)
        {
            c = Instantiate(missileToPool);
            c.SetActive(false);
            pooledMissile.Add(c);
        }
    }


    public GameObject GetPooledGuns()
    {
        for (int i = 0; i < gunsAmountToPool; i++)
        {
            if (!pooledGuns[i].activeInHierarchy)
            {
                return pooledGuns[i];
            }
        }
        return null;
    }
    public GameObject GetPooledCatapult()
    {
        for (int i = 0; i < catapultAmountToPool; i++)
        {
            if (!pooledCatapult[i].activeInHierarchy)
            {
                return pooledCatapult[i];
            }
        }
        return null;
    }
    public GameObject GetPooledMissile()
    {
        for (int i = 0; i < missileAmountToPool; i++)
        {
            if (!pooledMissile[i].activeInHierarchy)
            {
                return pooledMissile[i];
            }
        }
        return null;
    }
}
