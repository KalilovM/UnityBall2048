using UnityEngine;

public class PointEnter : MonoBehaviour
{
    public int stars = 0;
    public void Collect(GameObject go)
    {
        source.playerPoints *= 2;
        source.playerChange.Change();
        source.playerText.text = source.playerPoints.ToString();
        go.gameObject.SetActive(false);
    }
    public ScriptHandler source;
    private void OnTriggerEnter(Collider other)
    {
        // git ignore
        if (other.gameObject.TryGetComponent(out RestartCube1 restartCube))
        {
            source.restart.RestartLevel();
        }
        if (other.gameObject.TryGetComponent(out Finish finish))
        {

            stars = source.playerPoints / 512;
            source.levelScore.LevelStars(stars,source.levelScore.Level1stars);
            source.restart.RestartLevel();
        }
        if (other.gameObject.TryGetComponent(out Enemy enemyObj))
        {
            if (source.playerPoints > 2)
            {
                source.playerPoints /= 2;
                source.playerChange.ReChange();
            }
                
            source.playerText.text = source.playerPoints.ToString();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Point pointObj))
        {
            if (pointObj.pointInt == source.playerPoints)
            {
                Collect(pointObj.gameObject);
            }
        }
        if(collision.gameObject.TryGetComponent(out Trap trapObj))
        {
            if (trapObj.trapInt > source.playerPoints)
            {
                trapObj.Deactivate();
            }
        }
    } 
}
