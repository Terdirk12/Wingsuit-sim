using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawning : MonoBehaviour
{
    public List<GameObject> rockList;

    float timer;
    float speedTimer = 0.5f;
    float spawnTime;
    int boostingForwards;
    // Start is called before the first frame update
    void Start()
    {
        boostingForwards = PlayerPrefs.GetInt("boostingForwards");
        spawnTime = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (boostingForwards == 1)
        {
            spawnTime = 1.5f;
        }
        timer += Time.deltaTime;
        if (timer > (spawnTime - (speedTimer * Time.deltaTime)))
        {
            timer = 0;
            Instantiate(rockList[Random.Range(0, rockList.Count)], this.transform.position, Quaternion.identity);
        }


    }
}
