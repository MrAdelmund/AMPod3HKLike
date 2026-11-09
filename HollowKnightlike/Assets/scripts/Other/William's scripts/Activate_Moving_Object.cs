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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(unpauses == true)
        {
            moving_Platform_Slash_Wall_script.paused = false;
        }
        else
        {
            moving_Platform_Slash_Wall_script.paused = true;
        }
    }
}
