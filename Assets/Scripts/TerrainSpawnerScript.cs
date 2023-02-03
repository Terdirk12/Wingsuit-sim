using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawnerScript : MonoBehaviour
{
    public GameObject Terrain;
    float terrainTimer;
    float spawnTime = 22.5f;
    int boostingForwards;
    // Start is called before the first frame update
    void Start()
    {
        boostingForwards = PlayerPrefs.GetInt("boostingForwards");
        terrainTimer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (boostingForwards == 1)
        {
            spawnTime = 15f;
        }

        terrainTimer += Time.deltaTime;
        if (terrainTimer > spawnTime)
        {
            terrainTimer = 0;
            Instantiate(Terrain, this.transform.position, Quaternion.identity);
        }
    }
}
