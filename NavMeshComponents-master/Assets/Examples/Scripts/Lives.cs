using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public Text livesText;
    public static int lives = 3;

    void Update()
    {
        livesText.text = lives.ToString();

        if (lives <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
