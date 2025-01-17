using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalController : MonoBehaviour
{
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        num = 0;
    }

    public void ClickBubble(){
        Debug.Log("Hello World:" + num);
        num++;
    }

    public void RemoveCover(){
        GameObject cover = GameObject.Find("Cover").gameObject;
        cover.SetActive(false);
    }
}
