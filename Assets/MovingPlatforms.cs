using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 1.0f;

    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = pointB.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
        {
            if (targetPosition == pointA.position)
                targetPosition = pointB.position;
            else
                targetPosition = pointA.position;
        }
    }
}
