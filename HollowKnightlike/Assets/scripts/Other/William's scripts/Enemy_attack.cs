using TMPro;
using UnityEngine;

public class Enemy_attack : MonoBehaviour
{
    public int damage = 1;
    public TMP_Text text;
    public Player_health Player_healthScript;
    //This detects enemeies colliding with an object.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //This checks if said object is the player.
        if (collision.gameObject.tag == "Player")
        {
            //Subtracts amount from player health if said check comes out true.
            Debug.Log("I hit an ememy!");
            Player_healthScript.health -= damage;
            text.text = "Health: " + Player_healthScript.health + "/" + Player_healthScript.max_health;
        }
    }
}
