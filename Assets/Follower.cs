using UnityEngine;

public class CubeFollowPlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;

    void Update()
    {
        if (player != null)
        {
            Vector3 targetPosition = player.position;
            targetPosition.y = transform.position.y + 5;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}
