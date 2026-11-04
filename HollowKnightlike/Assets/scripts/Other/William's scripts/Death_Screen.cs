using UnityEngine;
using UnityEngine.SceneManagement;

public class Death_Screen : MonoBehaviour
{
    public Player_health player_Health_script;
    public int rest_health = 70;
    public bool restarts = false;
    public Vector3 death_screen;
    public bool enabled_boolean = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if the players health is equal to zero and if so, either restarts the scene or teliports the camera to the death screen.
        if(player_Health_script.health <= 0 && restarts == true && enabled_boolean == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(player_Health_script.health <= 0 && restarts == false && enabled_boolean == true)
        {
            transform.position = death_screen;
        }
    }
}
