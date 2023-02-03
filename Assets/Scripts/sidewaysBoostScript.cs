using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidewaysBoostScript : MonoBehaviour
{
    float baseSpeed = 20;
    public float speed, speedIncrease;
    int boostingForwards;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        boostingForwards = PlayerPrefs.GetInt("boostingForwards");
        if (boostingForwards == 1) speedIncrease = 10;
        else speedIncrease = 0;

        speed = baseSpeed + speedIncrease;
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("boostingSideways", 1);
            Destroy(this.gameObject);
        }
    }
}
