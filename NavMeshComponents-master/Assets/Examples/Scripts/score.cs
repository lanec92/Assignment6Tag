using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;
    public static int scr = 0;

    void Update()
    {
        scoreText.text = scr.ToString();
    }
}