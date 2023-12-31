using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody enemyRb;
    private GameObject player;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }

        Vector3 lookDirection = (player.transform.position - enemyRb.transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }
}
