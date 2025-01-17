using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameManager(){
        if(Instance!=null){
            Debug.LogWarning("Replacing existing instance.");
        }
        Instance=this;
    }
    
}
