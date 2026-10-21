using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7, -9);
    private Vector3 offset2 = new Vector3(0, 7, 9);

    // LateUpdate is called once per frame after all Update methods have been called
    void LateUpdate()
    {
        if (player.CompareTag("Player1"))
        {
            transform.position = player.transform.position + offset;
        }
        else
        {
            transform.position = player.transform.position + offset2;

        }
    }
}
