using TMPro;
using UnityEngine;

public class Is_being_crushed : MonoBehaviour
{
    public bool player_is_in = false;
    public bool wall_is_down = false;
    public TMP_Text text;
    public Player_health Player_healthScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Tests if the player is being crushed and if so kills them.
        if(player_is_in && wall_is_down)
        {
            Player_healthScript.health = 0;
            text.text = "Health: " + Player_healthScript.health + "/" + Player_healthScript.max_health;
        }
    }
    //Tests for collision.
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Tests if objects are player and a moving object and then tells the game that the player or wall are not touching it.
        if (collision.gameObject.tag == "Player")
        {
            player_is_in = false;
        }
        if (collision.gameObject.tag == "Moving")
        {
            wall_is_down = false;
        }
    }
    //Tests for collision.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Tests if objects are player and a moving object and then tells the game that the player or wall are touching it.
        if (collision.gameObject.tag == "Player")
        {
            player_is_in = true;
        }
        if (collision.gameObject.tag == "Moving")
        {
            wall_is_down = true;
        }
    }
}