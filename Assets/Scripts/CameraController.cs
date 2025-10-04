using UnityEngine;

public class c : MonoBehaviour
{
    public Transform FollowTarget, LookTarget;
    public float FollowSpeed = 10f;


    //lateupdate is called instead of regualr update to avoid jittery movement
    private void LateUpdate()
    {
        Vector3 targetPostion = FollowTarget.position;
        transform.position = Vector3.Lerp(transform.position, targetPostion, FollowSpeed * Time.deltaTime);
        //lerp makes the movement smooth
        transform.LookAt(LookTarget);
    }
}
