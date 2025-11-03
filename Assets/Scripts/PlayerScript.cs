using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerScript : MonoBehaviour
{
    public Transform enemy;
    public float moveSpeed = 5f;

    private Transform Childcube;
    private Vector3 enemyDirection;

    private float PlayerEnemyDirection;
    void Start()
    {
        Childcube = transform.GetChild(0);

        if (Childcube != null)
        {
            Childcube.position = transform.position + transform.forward;
        }
    }

    void Update()
    {
        float moveInput = 0f;

        if (Input.GetKeyDown(KeyCode.W))
        {
            moveInput = 1f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            moveInput = -1f;
        }


        transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);

        if (enemy != null)
        {
            enemyDirection = (enemy.position - transform.position).normalized;

            PlayerEnemyDirection = Vector3.Dot(transform.forward, enemyDirection);

            Debug.DrawLine(transform.position, enemy.position, Color.red);
        }
    }
}
