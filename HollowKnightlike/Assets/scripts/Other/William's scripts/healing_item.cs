using TMPro;
using UnityEngine;

public class healing_item : MonoBehaviour
{
    //Gets variables from other scripts.
    public Player_health Player_healthScript;
    public TMP_Text text;
    public int healing_amount = 3;
    //This detects you colliding with an object marked as trigger.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //This checks if said object is the player.
        if (collision.gameObject.tag == "Player")
        {
            //Adds amount to health if said check comes out true.
            Player_healthScript.health += healing_amount;
            text.text = "Health: " + Player_healthScript.health + "/" + Player_healthScript.max_health;
            //If so, it destroys the healing item.
            Debug.Log("Healing item.");
            Destroy(gameObject);
        }
    }
}
