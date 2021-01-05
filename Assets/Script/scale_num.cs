using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scale_num : MonoBehaviour
{
    public Text numberText;
    public float animationTime = 1.5f;

    private float currentNumber = 0;
    private float desiredNumber;
    
    public GameObject Buttonon;
    public GameObject Buttonoff;
    public GameObject Success;

    public void AddToNumber(float value)
    {
        currentNumber += value;
        numberText.text = currentNumber.ToString("0.0");
        Debug.Log(currentNumber);
        if(currentNumber > 3.399 && currentNumber <3.45){
			//Debug.Log("Sukses");
			Success.SetActive(true);
		}
    }

    public void DecreaseToNumber(float value)
    {
        if(currentNumber > 0.1)
            currentNumber -= value;
        numberText.text = currentNumber.ToString("0.0");
        Debug.Log(currentNumber);
        if(currentNumber > 3.399 && currentNumber <3.45)
			Success.SetActive(true);
    }
    public void Pop(){
		Buttonon.SetActive(false);
		Buttonoff.SetActive(true);
	}
    public void Push(){
		Buttonon.SetActive(true);
		Buttonoff.SetActive(false);
	}
	public void Grinding(){
		SceneManager.LoadScene(3);
	}
}
