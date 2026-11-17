using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class Player_health : MonoBehaviour
{
    public Image healthBar;
    public int health = 70;
    //The Test object we want to update.
    public TMP_Text text;
    public int max_health = 100;
    public int enemyDamage = 10;

    //public object camera;
    public void Start()
    {
        text.text = "Health: " + health + "/" + max_health;
    }
    public void Update()
    {

        //checks if health is too low, and if so, you die, aka reload the level.
        if (health <= 0)
        {
            if (health < 0)
            {
                health = 0;
                text.text = "Health: " + health + "/" + max_health;
            }
            //Restarts scene if check pass.
            Debug.Log("You lost!");

        }
        //If health is greater than max health set health to max health.
        if (health > max_health)
        {

            health = max_health;

            text.text = "Health: " + health + "/" + max_health;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //This checks if said object is the player.
        if (collision.gameObject.tag == "Enemy")
        {
            //Subtracts amount from player health if said check comes out true.
            Debug.Log("I hit an ememy!");
            health -= enemyDamage;
            text.text = "Health: " + health + "/" + max_health;
            float tempHP = health;
            float tempMaxHP = max_health;
            healthBar.fillAmount = tempHP / tempMaxHP;
        }
    }
}
