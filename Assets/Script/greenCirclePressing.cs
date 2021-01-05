using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class greenCirclePressing : MonoBehaviour
{
    public Rigidbody2D greencircle;
    public Rigidbody2D redcircle;
    public Rigidbody2D whitecircle;
    public bool CircleStop;

    [SerializeField] private float decScale;
    [SerializeField] private float eachklik;
    public Ease anim;



// Start is called before the first frame update
void Start()
    {

        CircleStop = true;
        StartCoroutine(gamesystem());
        greencircle.transform.DOMoveY(-0.78f, 1f);
        redcircle.transform.DOScale(2.834135f, 1f);
        whitecircle.transform.DOScale(1.838273f, 1f);
        //redcircle.transform.DOScale(2.834135f, 1f).SetEase(anim).From(1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("clicked");
            whitecircle.transform.localScale -= new Vector3(eachklik, eachklik, 0);
            if (whitecircle.transform.localScale.x <= greencircle.transform.localScale.x)
            {
                Debug.Log("Success");
                CircleStop = false;
                Main_Game.Instance.Koin += 10;
                SceneManager.LoadScene(1);
            }
        }

    }

    private IEnumerator gamesystem()
    {
        float x;
        while(CircleStop)
        {
            
            if(whitecircle.transform.localScale.x <= redcircle.transform.localScale.x)
            {
                whitecircle.transform.localScale += new Vector3(decScale, decScale, 0);
                yield return new WaitForSeconds(0.1f);
            }
            
            
            Debug.Log("currently running");
            yield return null;
        }
        Debug.Log("run");
    }
}
