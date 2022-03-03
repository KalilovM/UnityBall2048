using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public ScriptHandler script;
    private Vector3 offset,vec;  

    void Start ()
    {
        offset = new Vector3(0, script.cam.transform.position.y, script.cam.transform.position.z) - new Vector3(0, script.player.transform.position.y, script.player.transform.position.z);
    }

    void LateUpdate ()
    {
        vec = new Vector3(0, 0, script.player.transform.position.z);
        script.cam.transform.position = vec + offset;
    }
    
}
