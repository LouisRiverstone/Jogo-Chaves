using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] spawns = new GameObject[6];
    public GameObject sandwich;

    public void SpawnNow(){
        int rdn = Random.Range(0, 5);
        Instantiate(sandwich,spawns[rdn].transform);
    }
}
