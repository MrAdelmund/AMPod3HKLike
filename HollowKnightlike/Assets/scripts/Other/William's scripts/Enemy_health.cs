using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_health : MonoBehaviour
{
    public Playerattack PlayerattackScript;
    public int chance_of_drop = 50;
    public int health = 2;
    public GameObject healing;
    //This detects enemys colliding with an object marked as trigger.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //This checks if said object is a bullet.
        if(collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Ouch!");
            //Subtracts amount from health if said check comes out true.
            health -= PlayerattackScript.damage;
            //If enemy health gets too low, destroy them.
            if(health <= 0)
            {
                //Rolls the chance of an item drop.
                int drop_chance = Random.Range(1, 101);
                //Destroys then enemy if health is less then or equal to 0.
                Destroy(gameObject);
                //Checks if drop chance is the chance of the item droping.
                if(drop_chance <= chance_of_drop)
                {
                    Debug.Log("Dropped!");
                    //Summons in the drop.
                    GameObject drop = Instantiate(healing, transform.position, Quaternion.identity);
                }
            }
        }
    }
}
