using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1,10)]
    public float smooth = 1;
    

    // Update is called once per frame
    private void FixedUpdate()
    {
        Follow();
    }

    void Follow(){
        Vector3 targetPosition = target.position+offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, targetPosition, smooth*Time.fixedDeltaTime);
        transform.position = smoothPos;
    }
}
 