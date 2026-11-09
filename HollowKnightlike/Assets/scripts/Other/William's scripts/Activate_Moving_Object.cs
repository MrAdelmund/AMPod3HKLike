using UnityEngine;

public class Activate_Moving_Object : MonoBehaviour
{
    public moving_platform_slash_wall moving_Platform_Slash_Wall_script;
    public bool unpauses = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Checks if the player is touching the trigger.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If it unpauses the object will start moving.
        if(unpauses == true)
        {
            moving_Platform_Slash_Wall_script.paused = false;
        }
        else
        {
            //If it pauses the object will stop moving.
            moving_Platform_Slash_Wall_script.paused = true;
        }
    }
}
