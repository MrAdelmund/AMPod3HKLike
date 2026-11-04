using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Player_health : MonoBehaviour
{
    public int health = 70;
    //The Test object we want to update.
    public TMP_Text text;
    public int max_health = 100;
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
            if(health < 0)
            {
                health = 0;
            }
            //Restarts scene if check pass.
            Debug.Log("You lost!");
            
        }
        //If health is greater than max health set health to max health.
        if(health > max_health)
        {
            
            health = max_health;
            
            text.text = "Health: " + health + "/" + max_health;
        }
    }
}
