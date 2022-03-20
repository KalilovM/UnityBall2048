using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScore : MonoBehaviour
{
    public ScriptHandler source;
    public List<GameObject> Level1stars = new List<GameObject>();
    public List<GameObject> Level2stars = new List<GameObject>();
    public List<GameObject> Level3stars = new List<GameObject>();

    public void LevelStars(int starsNum,List<GameObject> gameObjects)
    {
        if (starsNum > 3)
            starsNum = 3;
        for (int i = 0; i < starsNum; i++)
        {
            gameObjects[i].SetActive(true);
        }
    }
}
