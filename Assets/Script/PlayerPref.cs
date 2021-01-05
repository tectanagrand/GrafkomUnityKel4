using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPref : MonoBehaviour
{
    public Text Highscore;
    // Start is called before the first frame update
    void Start()
    {
        Highscore.text = "Highscore :" + PlayerPrefs.GetInt("Highscore").ToString();
    }
}

