using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelmetSpawner : MonoBehaviour
{
    public GameObject Helmet;
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
        float randomTime = Random.Range(10f, 15f);
        if (timer > (randomTime - (speedTimer * Time.deltaTime)))
        {
            int RanX = Random.Range(5, 15);
            int RanY = Random.Range(6, 9);
            int RanZ = Random.Range(3, 11);
            timer = 0;
            Instantiate(Helmet, new Vector3(this.transform.position.x + RanX, this.transform.position.y + RanY, this.transform.position.z + RanZ), Quaternion.identity);
        }
    }
    public void ToggleHelmetSpawner()
    {
        gameObject.SetActive(true);
    }
}
