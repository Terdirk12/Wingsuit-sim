using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    [SerializeField]
    public DeathMenuScript deathMenu;
    [SerializeField]
    public Score score;
    public Text moneyText, helmetText;
    public int money = 0, helmetCount, boostingSideways, helmet;
    public float speed = 5, timer;
    public bool death = false, invinciblity = false;

    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("totalmoney");
        helmet = PlayerPrefs.GetInt("Helmet");  
    }

    // Update is called once per frame
    void Update()
    {
        helmetCount = PlayerPrefs.GetInt("helmetCount");
        boostingSideways = PlayerPrefs.GetInt("boostingSideways");
        moneyText.text = "money: " + PlayerPrefs.GetInt("totalmoney");
        helmetText.text = "Helmets: " + helmetCount;
        bool moving = false;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            moving = true;
        }

        if (moving)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
                transform.rotation = Quaternion.AngleAxis(2, Vector3.back);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.forward * speed * Time.deltaTime;
                transform.rotation = Quaternion.AngleAxis(2, Vector3.right);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.back * speed * Time.deltaTime;
                transform.rotation = Quaternion.AngleAxis(2, Vector3.left);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
                transform.rotation = Quaternion.AngleAxis(2, Vector3.forward);
            }

        }
        else
        {
            moving = false;
            transform.rotation = Quaternion.AngleAxis(1, Vector3.forward);
            transform.rotation = Quaternion.AngleAxis(1, Vector3.right);
            transform.rotation = Quaternion.AngleAxis(1, Vector3.left);
            transform.rotation = Quaternion.AngleAxis(1, Vector3.back);
        }

        if (boostingSideways == 1)
        {
            speed = 10;
        }
        else
        {
            speed = 5;
        }

        if (invinciblity)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                invinciblity = false;
            }
        }

        if (Input.GetKey(KeyCode.R))
        {
            money = 0;
            PlayerPrefs.SetInt("totalmoney", 0);
            PlayerPrefs.SetInt("Helmet", 0);
            PlayerPrefs.SetInt("Forwards", 0);
            PlayerPrefs.SetInt("Sideways", 0);
            PlayerPrefs.SetInt("boostingForwards", 0);
            PlayerPrefs.SetInt("boostingSideways", 0);
            PlayerPrefs.SetInt("helmetCount", 0);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Rock")
        {
            if (helmetCount != 0 && !invinciblity)
            {
                invinciblity = true;
                Destroy(collision.gameObject);
                helmetCount--;
                PlayerPrefs.SetInt("helmetCount", helmetCount);
            }
            else if (!invinciblity)
            {
                transform.position = new Vector3(95, 60, 0);
                death = true;
                deathMenu.ToggleEndMenu(score.score);
            }
        }
    }
}
