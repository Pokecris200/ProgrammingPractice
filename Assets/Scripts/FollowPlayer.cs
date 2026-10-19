using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7, -9);

    // LateUpdate is called once per frame after all Update methods have been called
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
