using UnityEngine;
using UnityEngine.SceneManagement;

public class Death_Screen : MonoBehaviour
{
    public Player_health player_Health_script;
    public bool restarts = false;
    public bool enabled_boolean = true;
    public string LevelToLoad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Hide the death scrren on start.
        Time.timeScale = 1.0f;
        GetComponent<Canvas>().enabled = false;
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
            Time.timeScale = 0;
            GetComponent<Canvas>().enabled = true;
        }
    }
    public void OnRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OnMainMenu()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
