using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenuScript : MonoBehaviour
{
    [SerializeField]
    public UpgradeMenu upgradeMenu;
    [SerializeField]
    public playerMovement player;
    [SerializeField]
    public Score scoreclass;

    public Text scoreText;
    public Text highScoreText;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleEndMenu(float score)
    {
        gameObject.SetActive(true);
        scoreText.text = "Your Score: " + ((int)score).ToString();
        highScoreText.text = "Highscore: " + (int)PlayerPrefs.GetFloat("Highscore");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void UpgradeMenu()
    {
        upgradeMenu.ToggleUpgradeMenu(player.money);
    }
}
