using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class grinder_num : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_Text grinder_text;
    private pivot_handle Pivot;
    int grindernumber;
    public GameObject Success;
    public GameObject Buttonon;
    public GameObject Buttonoff;

    public int indicateSuc;
    private void Awake()
    {
        Pivot = GameObject.FindObjectOfType<pivot_handle>();
        grindernumber = Pivot.pass_num();
        indicateSuc = Main_Game.Instance.grinderIndicator();
    }
    public void Pop(){
		Buttonon.SetActive(false);
		Buttonoff.SetActive(true);
	}
    public void Push(){
		Buttonon.SetActive(true);
		Buttonoff.SetActive(false);
	}
	public void Resume(){
		Success.SetActive(false);
	}
	public void Pressing(){
		SceneManager.LoadScene(4);
	}

    // Update is called once per frame
    void Update()
    { 
        Debug.Log("test" + grindernumber);
        grinder_text.text = grindernumber.ToString();
        if(grindernumber == indicateSuc) Success.SetActive(true);
        grindernumber = Pivot.grindCount;
    }
}
