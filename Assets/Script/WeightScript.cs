using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeightScript : MonoBehaviour
{
    public Text WeightText;

    public void SetText(string text)
    {
        WeightText.text = text;
    }
}
