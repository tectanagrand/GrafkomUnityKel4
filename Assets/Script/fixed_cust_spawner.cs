using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixed_cust_spawner : MonoBehaviour
{
    private float nextSpawnTime;

    [SerializeField] private GameObject customerPrefab;
    [SerializeField] private float spawnDelay = 10;
    public List<GameObject> listCustie;

    

    // Update is called once per frame
    void Update()
    {
        if(ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        nextSpawnTime += Time.time + spawnDelay;
        GameObject obj = (GameObject)Instantiate(customerPrefab, transform);
        listCustie.Add(obj);
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}
