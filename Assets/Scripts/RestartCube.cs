using UnityEngine;

public class RestartCube : MonoBehaviour
{
    public ScriptHandler script;
    private GameObject clone, clone1;

    private void Start()
    {
        RestartLevel();
    }

    public void RestartLevel()
    {
        Destroy(clone1);
        if(script.menu.level2)
            clone1 = Instantiate(script.levelBase2);
        else if(script.menu.level3)
            clone1 = Instantiate(script.levelBase3);
        else
            clone1 = Instantiate(script.levelBase1);
        clone1.SetActive(true);
        script.player.transform.position = script.playerPos;
        script.menu.menu.SetActive(true);
        script.menu.mainMenu.SetActive(true);
        script.playerMove.rb.velocity = Vector3.zero;
        script.playerMove.rb.constraints = RigidbodyConstraints.FreezeAll;
        script.playerMove.rb.constraints = RigidbodyConstraints.None;
        script.playerPoints = 2;
        script.player.transform.localScale = new Vector3(1, 1, 1);
        script.playerText.text = script.playerPoints.ToString();
        script.playerChange.colorId = 0;
        script.playerColor.color = script.playerChange.colors[script.playerChange.colorId];
    }
}
