using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptManager : MonoBehaviour
{
    public static ScriptManager Instance;
    public ScriptManager()
    {
        if (Instance != null)
        {
            Debug.LogWarning("Replacing existing instance.");
        }
        Instance = this;
    }

    public int NowID { get; private set; }

    public ScriptData[] scriptData;

    

    public void NextScript()
    {
        if (NowID + 1 < scriptData.Length)
        {
            scriptData[NowID].script.Exit();
            scriptData[NowID + 1].script.Enter();
            NowID += 1;
        }
        else
        {
            Debug.LogWarning("Script is ending");
        }
    }

    public void ToScript(int id)
    {
        if (id < scriptData.Length && id >= 0)
        {
            scriptData[NowID].script.Exit();
            scriptData[NowID + 1].script.Enter();
            NowID = id;
        }
        else
        {
            Debug.LogError("id is out of range");
        }
    }

    private void Awake(){
        NowID=0;
        if(scriptData.Length>0)
            scriptData[NowID].script.Enter();
    }
}

[Serializable]
public struct ScriptData
{
    public string name;
    public Script script;
}

public class Script:MonoBehaviour
{
    public virtual void Enter()
    {
        enabled=true;
    }
    public virtual void Exit()
    {
        enabled=false;
    }
}