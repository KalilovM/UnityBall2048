using UnityEngine;

public class MenuController : MonoBehaviour
{
    public bool isGameStarted,level1,level2,level3;
    public GameObject mainMenu, levelSelect,menu,touchScreen;

    public void Start()
    {
        isGameStarted = false;
    }

    public void LevelSelect()
    {
        menu.SetActive(false);
        levelSelect.SetActive(true);
    }

    public void GameStart()
    {
        levelSelect.SetActive(false);
        touchScreen.SetActive(true);
        menu.SetActive(false);
    }

    public void Level1()
    {
        levelSelect.SetActive(false);
        touchScreen.SetActive(true);
        menu.SetActive(false);
    }
    public void Level2()
    {
        levelSelect.SetActive(false);
        touchScreen.SetActive(true);
        menu.SetActive(false);
    }
    public void Level3()
    {
        levelSelect.SetActive(false);
        touchScreen.SetActive(true);
        menu.SetActive(false);
    }

    public void Update()
    {
        if (touchScreen.activeSelf)
        {
            if (Input.anyKey)
            {
                isGameStarted = true;
                touchScreen.SetActive(false);
                mainMenu.SetActive(false);
            }
        }

        if (mainMenu.activeSelf)
        {
            isGameStarted = false;
        }
    }
}
