using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class customer : MonoBehaviour
{
    public GameObject custie;
    
    string[] custName = new string[] { "Asep", "Cecep", "Apip", "Yono", "Ningsih", "Iteung", "Surti", "Jaka" };
    string[] type = new string[] { "mild", "med", "bold" };
    string[] coffee = new string[] { "aeropress", "espresso" };
    string displayedName;
    string displayedType;
    string displayedCof;
    string displayedText;
    public bool status = false;


    [SerializeField] private Text custNama, Cof;

    #region Singleton
    public static customer Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        displayedName = custName[Random.Range(0, 7)];
        displayedType = type[Random.Range(0, 2)];
        displayedCof = coffee[Random.Range(0, 1)];
        displayedText = "I want a cup of " + displayedCof +"\n" + "Please make a " + displayedType + " one :)";
        custNama.text = displayedName;
        Cof.text = displayedText;
    }

    // Update is called once per frame

    public void StartGame()
    {
        SceneManager.LoadScene(2);
        Main_Game.Instance.AddName(displayedName);
        Main_Game.Instance.AddType(displayedType);
       
    }
}
