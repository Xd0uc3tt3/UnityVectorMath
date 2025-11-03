using UnityEngine;
using UnityEngine.UIElements;

public class VectorAddition : MonoBehaviour
{
    public enum Axis { X, Y, Z}
    public Axis movementAxis = Axis.Y;
    public float amplitude = 1f;
    public float frecency = 1f;

    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * frecency) * amplitude;

        Vector3 newPosition = startPosition;

        if(movementAxis == Axis.X)
        {
            newPosition.x += offset;
        }
        else if (movementAxis == Axis.Y) {
            newPosition.y += offset;
        }
        else if (movementAxis == Axis.Z)
        {
            newPosition.z += offset;
        }
        else
        {
            Debug.Log("Invalid");
        }

        transform.position = newPosition;
    }
}
