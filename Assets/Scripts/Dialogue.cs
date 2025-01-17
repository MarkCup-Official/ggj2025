using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : Script
{
    public TextData[] text;

    public int loopPoint;

    public TextDisplay textDisplay;

    private int nowText = 0;

    public override void Enter()
    {
        base.Enter();
        nowText = 0;
        waiting = 0;
    }

    private float waiting = 0;

    private void Update()
    {
        if (textDisplay.IsPlaying)
        {
            return;
        }
        if (nowText < text.Length)
        {
            waiting += Time.deltaTime;
            if (nowText==0|| waiting > text[nowText-1].waitingTime)
            {
                waiting=0;
                textDisplay.Display(text[nowText].text);

                nowText+=1;
            }
        }
        else{
            nowText=loopPoint;
        }
    }
}

[Serializable]
public class TextData
{
    public string text;
    public float waitingTime=1;
}