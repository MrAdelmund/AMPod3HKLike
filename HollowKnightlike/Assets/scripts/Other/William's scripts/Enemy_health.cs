using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_health : MonoBehaviour
{
    //public Playerattack PlayerattackScript;
    public int chance_of_drop = 50;
    public int health = 2;
    public GameObject healing;
    public PlayerAttack playerAttack_script;
    public Damage damage_script;
    public int delay = 0;
    public int timer = 0;
    public void Update()
    {
        //reduces timer by one each frame, when it is equal to 0.
        if(timer > 0)
        {
            timer -= 1;
        }
    }
    //This detects enemys colliding with an object marked as trigger.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //This checks if said object is a player attack object, that the player is atacking, and that the timer is 0.
        if(collision.gameObject.tag == "Bullet" && playerAttack_script.isAttacking == true && timer <= 0)
        {
            //Reduces enemy health and starts the timer.
            Debug.Log("Ouch!");
            health -= damage_script.player_damage;
            timer = delay;
            //If enemy health gets too low, destroy them.
            if (health <= 0)
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
