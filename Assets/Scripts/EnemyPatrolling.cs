
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolling : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private Transform[] movementPoints;
    [SerializeField] private float minDistance;

    private int nextPoint = 0;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        //nextPoint = Random.Range(0, movementPoints.Length);
        spriteRenderer = GetComponent<SpriteRenderer>();
        Spin();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, movementPoints[nextPoint].position, movementSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, movementPoints[nextPoint].position) < minDistance)
        {
            //nextPoint = Random.Range(0, movementPoints.Length);
            //Spin();
            nextPoint += 1;
            if (nextPoint >= movementPoints.Length)
            {
                nextPoint = 0;
            }
            Spin();
        }
    }


    private void Spin()
    {
        if (transform.position.x < movementPoints[nextPoint].position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
