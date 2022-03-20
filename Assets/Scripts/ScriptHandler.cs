using TMPro;
using UnityEngine;

public class ScriptHandler : MonoBehaviour
{
    public GameObject player, cam,levelBase1,levelBase2,levelBase3; 
    public Vector3 playerPos;
    public RestartCube restart;
    public MenuController menu;
    public GameObject finish1;
    public PlayerMove playerMove;
    public LevelScore levelScore;
    public int playerPoints;
    public TextMeshPro playerText;
    public PlayerChange playerChange;
    public Material playerColor;
    private void Start()
    {
        playerColor = player.GetComponent<Renderer>().material;
        playerPos = player.transform.position;
    }
}
