using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    public float force;
    public float damage;
    public float rotation;

    private GameObject player;
    private Rigidbody2D rb;  
    private float timer;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            Vector3 direction = player.transform.position - transform.position;
            rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

            float rot = Mathf.Atan2(-direction.x, -direction.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rot + rotation);
        }        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 10)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (player.GetComponent<MovementPLayer>().isHittable)
            {
                other.gameObject.GetComponent<playerHealth>().health -= damage;
                Destroy(gameObject);
            }
        }

        if (other.gameObject.CompareTag("Box"))
        {
           Debug.Log("Banana choca contra caja");
           
           // Physics2D.IgnoreCollision(GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>(),GameObject.FindGameObjectWithTag("Bullet").GetComponent<Collider2D>());
        }
        
    }
}
