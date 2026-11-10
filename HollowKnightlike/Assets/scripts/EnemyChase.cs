using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody2D))]

public class EnemyChase : MonoBehaviour
{

    public GameObject player;
    public GameObject the_chase_radius;
    public float chaseSpeed = 2.0f;
    public float chaseTriggerDistance = 3.0f;
    public Vector3 startPosition;
    private bool home = true;
    //-1 == left, 1 == right.
    public int direction = 1;
    public float paceDistance = 3.0f;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 1)
        {
            transform.position = new Vector3(transform.position.x + chaseSpeed, transform.position.y, 0f);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - chaseSpeed, transform.position.y, 0f);
        }
        Vector3 playerPosition = player.transform.position;
        Vector2 chaseDirection = new Vector2(playerPosition.x - transform.position.x, transform.position.y);
        if ((Mathf.Abs(transform.position.x) - Mathf.Abs(player.transform.position.x)) <= chaseTriggerDistance)
        {
            //player gets too close to the enemy
            home = false;
            if(player.transform.position.x > transform.position.x)
            {
                direction = 1;
            }else if(player.transform.position.x < transform.position.x)
            {
                direction = -1;
            }
        }
        else if (home == false)
        {
            if (startPosition.x > transform.position.x)
            {
                direction = 1;
            }
            else if (startPosition.x < transform.position.x)
            {
                direction = -1;
            }
            //if (homeDirection.magnitude < 0.3f)
            //{
            //    //we've arrived home
            //    home = true;
            //    GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            //}
            //else
            //{
            //    //go home
            //    homeDirection.Normalize();
            //    GetComponent<Rigidbody2D>().linearVelocity = homeDirection * chaseSpeed;
            //}
        }
        else
        {
            //Vector3 displacement = transform.position - startPosition;
            //float distanceFromStart = displacement.magnitude;
            //if (distanceFromStart >= paceDistance)
            //{
                //do stuff, we've gone too far
                //paceDirection = -displacement;
            //}
            //paceDirection.Normalize();
            //GetComponent<Rigidbody2D>().linearVelocity = paceDirection * chaseSpeed;
        }
    }
}
