using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    public float xStart;
    public float xEnd;
    public float yStart;
    public float yEnd;
    public AudioSource shootingEffect;

    private GameObject player;
    private GameObject enemy;
    private float timer; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {      
        timer += Time.deltaTime;

        if (timer > 1)
        {
            timer = 0;
            Shoot();
        }        
    }

    void Shoot()
    {
        if (player != null && 
            ((enemy.transform.position.y < yStart && enemy.transform.position.y > yEnd) || 
            (enemy.transform.position.x < xStart && enemy.transform.position.x > xEnd)))
        {
            shootingEffect.Play();
            Instantiate(bullet, bulletPos.position, Quaternion.identity);
        }
    }
}

