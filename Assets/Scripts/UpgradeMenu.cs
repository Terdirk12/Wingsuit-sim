using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UpgradeMenu : MonoBehaviour
{
    int money;
    public Text moneyText;
    int helmets;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        money = PlayerPrefs.GetInt("totalmoney");
        moneyText.text = "Money: " + ((int)money).ToString();
    }

    public void ToggleUpgradeMenu(int money)
    {
        gameObject.SetActive(true);
        this.money = money;
    }

    public void Helmet()
    {
        if (money >= 10)
        {
            money -= 10;
            helmets++;
            PlayerPrefs.SetInt("totalmoney", money);
            PlayerPrefs.SetInt("Helmet", helmets);
        }
    }

    public void Forwards()
    {
        if (money >= 20)
        {
            money -= 20;
            PlayerPrefs.SetInt("totalmoney", money);
            PlayerPrefs.SetInt("Forwards", 1);
        }
    }

    public void Sideways()
    {
        if (money >= 15)
        {
            money -= 15;
            PlayerPrefs.SetInt("totalmoney", money);
            PlayerPrefs.SetInt("Sideways", 1);
        }
    }
}
