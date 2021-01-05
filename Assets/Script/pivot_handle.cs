using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class pivot_handle : MonoBehaviour
{
    public Camera cam ;
    public Rigidbody2D rb;
    public float distance;
    Vector2 mousePos ;
    bool isHeld = false;
    public int grindCount = 3;
    int[] arrCount = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };


    private void OnMouseDown()
    {
        isHeld = true;
    
    }
        

    private void OnMouseUp()
    {
        isHeld = false;
        Debug.Log("OnMouseUp");
    }
    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (isHeld)
        {
            
        }
    }
    private void FixedUpdate()
    {
        if (isHeld)
        {
            Vector2 lookDir = mousePos - rb.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
            rb.rotation = angle;
            Debug.Log("OnMouseDown");
            RaycastHit2D hitInfo = Physics2D.Raycast(transform.up, mousePos, distance);
            Debug.DrawLine(transform.up, mousePos);

            if (hitInfo.collider != null)
            {
                if (hitInfo.collider.CompareTag("indicator_0"))
                {
                    grindCount = arrCount[0];
                    Debug.Log(grindCount);
                }
                if (hitInfo.collider.CompareTag("indicator_1"))
                {
                    grindCount = arrCount[1];
                    Debug.Log(grindCount);
                }
                if (hitInfo.collider.CompareTag("indicator_2"))
                {
                    grindCount = arrCount[2];
                    Debug.Log(grindCount);
                }
                if (hitInfo.collider.CompareTag("indicator_3"))
                {
                    grindCount = arrCount[3];
                    Debug.Log(grindCount);
                }
                if (hitInfo.collider.CompareTag("indicator_4"))
                {
                    grindCount = arrCount[4];
                    Debug.Log(grindCount);
                }
                if (hitInfo.collider.CompareTag("indicator_5"))
                {
                    grindCount = arrCount[5];
                    Debug.Log(grindCount);
                }
                if (hitInfo.collider.CompareTag("indicator_6"))
                {
                    grindCount = arrCount[6];
                    Debug.Log(grindCount);
                }
                if (hitInfo.collider.CompareTag("indicator_7"))
                {
                    grindCount = arrCount[7];
                    Debug.Log(grindCount);
                }
                if (hitInfo.collider.CompareTag("indicator_8"))
                {
                    grindCount = arrCount[8];
                    Debug.Log(grindCount);
                }
                if (hitInfo.collider.CompareTag("indicator_9"))
                {
                    grindCount = arrCount[9];
                    Debug.Log(grindCount);
                }
                if (hitInfo.collider.CompareTag("indicator_10"))
                {
                    grindCount = arrCount[10];
                    Debug.Log(grindCount);
                }
                if (hitInfo.collider.CompareTag("indicator_11"))
                {
                    grindCount = arrCount[11];
                    Debug.Log(grindCount);
                }
            }
        }
    }

    public int pass_num()
    {
        return grindCount;
    }
}
