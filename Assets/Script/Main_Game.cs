using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_Game : MonoBehaviour
{
    public GameObject ScrollView, Canvas;
    public static Main_Game Instance;
    private string custName;
    private string cofType;
    public int Koin = 0;


    [SerializeField] private float timer;
    public Text timerBox;
    public Text KoinBox;
    public int Highscore = 0;

    private void Awake()
    {

       
        timerBox = GameObject.Find("timer").GetComponent<Text>();
        timerBox.text = timer.ToString();
        Make_Instance();

        if(PlayerPrefs.HasKey("Highscore"))
        {
            Highscore = PlayerPrefs.GetInt("Highscore");
        }
    }

    private void Make_Instance()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(ScrollView);
            DontDestroyOnLoad(Canvas);

            
        }
        else
        {
            Destroy(gameObject);
            
        }
    }

    public string AddName(string Name)
    {
        custName = Name;
        Debug.Log(custName);
        return custName;
    }

    public string AddType(string Type)
    {
        cofType = Type;
        Debug.Log(cofType);
        return cofType;
    }



    public int grinderIndicator()
    {
        int x = 0;
        if(cofType.Equals("mild"))
        {
            x = 9;
        }
        else if (cofType.Equals("med"))
        {
            x = 5;
        }
        else if (cofType.Equals("bold"))
        {
            x = 2;
        }
        return x;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        timerBox.text = Mathf.Round(timer).ToString();
        if(timer <= 0)
        {
            
            if(Highscore < Koin)
            {
                Highscore = Koin;
                PlayerPrefs.SetInt("Highscore", Highscore);
                PlayerPrefs.Save();
                
            }
        }
        KoinBox.text = Koin.ToString();
        if (SceneManager.GetActiveScene().buildIndex == 1 )
        {
            ScrollView.SetActive(true);
        }
        else if(SceneManager.GetActiveScene().buildIndex != 1 && ScrollView.activeInHierarchy == true)
        {
            ScrollView.SetActive(false);
        }
        else if(timer == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
