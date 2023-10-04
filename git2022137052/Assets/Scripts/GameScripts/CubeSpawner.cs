using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

    public float SpawnTime = 3.0f;
    public float SpawnCheckTime = 0.0f;

    public GameObject Prefabs;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCheckTime = SpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnCheckTime -= Time.deltaTime;
        if (SpawnCheckTime <= 0.0f)
        {
            SpawnCheckTime = SpawnTime;

            GameObject Temp = (GameObject)Instantiate(Prefabs);
            Temp.transform.position = this.gameObject.transform.position;
        }
    }
}
