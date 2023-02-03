using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour
{
    int boostingForwards, boostingSideways;
    Color colorStartForward = Color.red;
    Color colorEndForward = Color.green;
    Color colorStartSideways = Color.red;
    Color colorEndSideways = Color.blue;

    float duration = 1.0f;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        boostingForwards = PlayerPrefs.GetInt("boostingForwards");
        boostingSideways = PlayerPrefs.GetInt("boostingSideways");

        if (boostingForwards == 1)
        {
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            rend.material.color = Color.Lerp(colorStartForward, colorEndForward, lerp);
        }
        else if (boostingSideways == 1)
        {
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            rend.material.color = Color.Lerp(colorStartSideways, colorEndSideways, lerp);
        }
        else
        {
            rend.material.color = colorStartSideways;
        }

    }
}
