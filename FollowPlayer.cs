using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;

    public Vector3 offset;

    public Quaternion rotationOffset;
    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;
    }
}
