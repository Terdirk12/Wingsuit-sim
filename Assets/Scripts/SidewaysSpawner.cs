using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidewaysSpawner : MonoBehaviour
{
    public GameObject Sidewayspeed;
    float timer;
    float speedTimer = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float randomTime = Random.Range(15f, 25f);
        if (timer > (randomTime - (speedTimer * Time.deltaTime)))
        {
            int RanX = Random.Range(1, 20);
            int RanY = Random.Range(5, 10);
            int RanZ = Random.Range(1, 14);
            timer = 0;
            Instantiate(Sidewayspeed, new Vector3(this.transform.position.x + RanX, this.transform.position.y + RanY, this.transform.position.z + RanZ), Quaternion.identity);
        }
    }
    public void ToggleSidewaySpawner()
    {
        gameObject.SetActive(true);
    }
}
