using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChange : MonoBehaviour
{
    public ScriptHandler source;
    public int colorId;
    public List<Color> colors = new List<Color>()
    {
        new Color(0.4433962f, 0.4433962f, 0.4433962f,1),
        new Color(1, 0.1933962f, 0.1933962f,1),
        new Color(1, 0.7538046f, 0f,1),
        new Color(0.5930026f, 1, 0f,1),
        new Color(0, 1, 0.07460141f,1),
        new Color(0, 1, 0.5598161f,1),
        new Color(0, 0.5439868f, 1,1),
        new Color(0.3038616f, 0f, 1,1),
        new Color(1, 0f, 0.5054851f,1),
        new Color(0.9550543f, 0.9803922f, 0f,1),
        new Color(1, 0.1072823f, 0,1)
    };

    private void Start()
    {
        colorId = 0;
    }

    public void Change()
    {
        colorId++;
        source.playerColor.color = colors[colorId];
        source.player.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
    public void ReChange()
    {
        colorId--;
        source.playerColor.color = colors[colorId];
        source.player.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }
}
