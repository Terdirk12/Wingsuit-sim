using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject Coin;
    float timer;
    float speedTimer = 0.5f;
    int boostingForwards;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        boostingForwards = PlayerPrefs.GetInt("boostingForwards");
        timer += Time.deltaTime;
        if (timer > (1.5f - (speedTimer * Time.deltaTime)))
        {
            int RanX = Random.Range(1, 20);
            int RanY = Random.Range(5, 10);
            int RanZ = Random.Range(1, 14);
            timer = 0;
            Instantiate(Coin, new Vector3(this.transform.position.x + RanX, this.transform.position.y + RanY, this.transform.position.z + RanZ), Quaternion.identity);
        }
    }
}
