using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class waterbar : MonoBehaviour
{
    public Image Fill;
    public float barChangeSpeed = 1;
    public int countdown;
    public Text countdownDisplay;
    public PouringCountdown retry;
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

            if(Input.GetMouseButtonDown(0))
            {
                BarON = false;
                if(currentBarValue>90)
                {
                    countdownDisplay.fontSize = 100;
                    countdownDisplay.text = "Berhasil!";
                    countdownDisplay.gameObject.SetActive(true);
                }
                else
                {
                    countdownDisplay.fontSize = 100;
                    countdownDisplay.text = "Gagal, coba lagi!";
                    countdownDisplay.gameObject.SetActive(true);
                    yield return new WaitForSeconds(1f);
                    countdownDisplay.fontSize = 200;
                    while (countdown > 0)
                    {
                        countdownDisplay.text = countdown.ToString();

                        yield return new WaitForSeconds(1f);

                        countdown--;
                    }
                    countdownDisplay.gameObject.SetActive(false);
                    countdown = 3;
                    BarON = true;
                    UpdateBar();
                }
            }            
        }
        yield return null;
    }
}
