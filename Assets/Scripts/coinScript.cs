using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    [SerializeField]
    public playerMovement player;
    float baseSpeed = 20;
    int money;
    public float speed, speedIncrease;
    int boostingForwards;
    // Start is called before the first frame update
    void Start()
    {
        boostingForwards = PlayerPrefs.GetInt("boostingForwards");
    }

    // Update is called once per frame
    void Update()
    {
        money = PlayerPrefs.GetInt("totalmoney");

        if (boostingForwards == 1) speedIncrease = 10;
        else speedIncrease = 0;

        speed = baseSpeed + speedIncrease;
        transform.position += Vector3.right * speed * Time.deltaTime;
        transform.Rotate(0, 1f, 0, Space.Self);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            money++;
            PlayerPrefs.SetInt("totalmoney", money);
            Destroy(this.gameObject);
        }
    }
}
