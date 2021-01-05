using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class waterbar : MonoBehaviour
{
    public Image Fill;
    public float barChangeSpeed = 1;
    public Text countdownDisplay;
    float maxBarValue = 100;
    float currentBarValue;
    bool barIsDecreasing;
    bool BarON;

    void Start()
    {
        currentBarValue = 0;
        barIsDecreasing = false;
        BarON = true;
    }

    public void startbar()
    {
        StartCoroutine(UpdateBar());
    }

    IEnumerator UpdateBar()
    {
        while(BarON)
        {
            if(!barIsDecreasing)
            {
                currentBarValue += barChangeSpeed;
                if(currentBarValue >= maxBarValue)
                {
                    barIsDecreasing = true;
                }
            }
            if (barIsDecreasing)
            {
                currentBarValue -= barChangeSpeed;
                if (currentBarValue <= 0)
                {
                    barIsDecreasing = false;
                }
            }

            float fill = currentBarValue / maxBarValue;
            Fill.fillAmount = fill;
            yield return new WaitForSeconds(0.02f);

            if(Input.GetKeyDown("space"))
            {
                BarON = false;
                if(currentBarValue>95)
                {
                    countdownDisplay.text = "Mantappu!";
                } else
                {
                    countdownDisplay.text = "Gagal";
                }
                countdownDisplay.fontSize = 125;
                countdownDisplay.gameObject.SetActive(true);
            }            
        }
        yield return null;
    }
}
