using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public Transform pointA, pointB;
    private bool movingToPointB = true;

    
    public Transform player;
    public float visionRange = 5f;
    public float visionAngle = 45f; 
    private bool chasingPlayer = false;

    void Update()
    {
 
        Vector2 directionToPlayer = player.position - transform.position;
        float distanceToPlayer = directionToPlayer.magnitude;
        float angleToPlayer = Vector2.Angle(transform.right, directionToPlayer);

        if (distanceToPlayer < visionRange && angleToPlayer < visionAngle / 2f)
        {
            chasingPlayer = true;
        }
        else
        {
            chasingPlayer = false;
        }

     
        if (chasingPlayer)
        {
            ChasePlayer();
        }
        else
        {
            Patrol();
        }
    }

  
    void Patrol()
    {
        if (movingToPointB)
        {
            transform.position = Vector2.MoveTowards(transform.position, pointB.position, speed * Time.deltaTime);
            if (transform.position == pointB.position)
                movingToPointB = false;
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, pointA.position, speed * Time.deltaTime);
            if (transform.position == pointA.position)
                movingToPointB = true;
        }
    }

 
    void ChasePlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Circle"))
        {
            Debug.Log("Player Hit!");
        }
    }
}
