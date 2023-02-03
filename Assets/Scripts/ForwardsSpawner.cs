using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardsSpawner : MonoBehaviour
{
    public GameObject Forwardspeed;
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
        float randomTime = Random.Range(25f, 45f);
        if (timer > (randomTime - (speedTimer * Time.deltaTime)))
        {
            int RanX = Random.Range(1, 20);
            int RanY = Random.Range(5, 10);
            int RanZ = Random.Range(1, 14);
            timer = 0;
            Instantiate(Forwardspeed, new Vector3(this.transform.position.x + RanX, this.transform.position.y + RanY, this.transform.position.z + RanZ), Quaternion.identity);
        }
    }
    public void ToggleForwardSpawner()
    {
        gameObject.SetActive(true);
    }
}
