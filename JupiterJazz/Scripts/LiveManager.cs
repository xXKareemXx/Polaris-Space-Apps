using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LiveManager : MonoBehaviour
{
    public TextMeshProUGUI lives_textholder;
    public static int lives_count = 5;
    public GameObject gameOver_panel;
    public TextMeshProUGUI sorry_out_of_textholder;
    string sorry_out_of_message = "Sorry, You Are Out of Lives.";
    public GameObject game_panel;

    // Update is called once per frame
    void Update()
    {
        lives_textholder.text = lives_count.ToString();
        if (lives_count == 0)
        {
            Time.timeScale = 0;
            sorry_out_of_textholder.text = sorry_out_of_message;
            gameOver_panel.SetActive(true);
            game_panel.SetActive(false);
        }
    }
}
