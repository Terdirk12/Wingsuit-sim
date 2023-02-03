using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerHandler : MonoBehaviour
{
    int forwards, helmet, sideways, boostingForwards, boostingSideways, boostingHelmet, helmetCount;
    float timerForwardBoost = 3.5f, timerSidewaysBoost = 5f;

    [SerializeField]
    public ForwardsSpawner ForwardsSpawner;
    [SerializeField]
    public SidewaysSpawner SidewaysSpawner;
    [SerializeField]
    public HelmetSpawner HelmetSpawner;
    // Start is called before the first frame update
    void Start()
    {
        forwards = PlayerPrefs.GetInt("Forwards");
        helmet = PlayerPrefs.GetInt("Helmet");
        sideways = PlayerPrefs.GetInt("Sideways");
    }

    // Update is called once per frame
    void Update()
    {
        if (forwards == 1)
        {
            ForwardsSpawner.ToggleForwardSpawner();
        }
        if (helmet >= 1)
        {
            HelmetSpawner.ToggleHelmetSpawner();
        }
        if (sideways == 1)
        {
            SidewaysSpawner.ToggleSidewaySpawner();
        }

        boostingForwards = PlayerPrefs.GetInt("boostingForwards");

        if (boostingForwards == 1)
        {
            timerForwardBoost -= Time.deltaTime;
            if (timerForwardBoost <= 0)
            {
                PlayerPrefs.SetInt("boostingForwards", 0);
                timerForwardBoost = 3.5f;
            }
        }

        boostingSideways = PlayerPrefs.GetInt("boostingSideways");

        if (boostingSideways == 1)
        {
            timerSidewaysBoost -= Time.deltaTime;
            if (timerSidewaysBoost <= 0)
            {
                PlayerPrefs.SetInt("boostingSideways", 0);
                timerSidewaysBoost = 5f;
            }
        }

        boostingHelmet = PlayerPrefs.GetInt("boostingHelmet");

        if (boostingHelmet == 1)
        {
            helmetCount = PlayerPrefs.GetInt("helmetCount");
            helmetCount++;
            PlayerPrefs.SetInt("helmetCount", helmetCount);
            PlayerPrefs.SetInt("boostingHelmet", 0);
        }
    }
}
