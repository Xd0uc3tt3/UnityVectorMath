using UnityEngine;

public class VectorAddition3rdCube : MonoBehaviour
{
    public Transform cubeA;
    public Transform cubeB;

    void Update()
    {
        transform.position = cubeA.position + cubeB.position;
    }
}
