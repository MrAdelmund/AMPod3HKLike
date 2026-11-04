using UnityEngine;

public class moving_platform_slash_wall : MonoBehaviour
{
    public string dirrection = "Left";
    public float speed = 4f;
    public float distance = 6f;
    private bool finished = false;
    public bool paused = false;
    public int delay = 0;
    private int timer = 0;
    public Locate_Starting_Platform Locate_Starting_Platform;
    private float end_pos = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Starts the timer.
        timer = delay;
        //Stores the start position and the end position.
        if(dirrection == "Left")
        {
            end_pos = Locate_Starting_Platform.start_pos.x - distance;
        }else if(dirrection == "Right")
        {
            end_pos = Locate_Starting_Platform.start_pos.x + distance;
        }
        else if (dirrection == "Down")
        {
            end_pos = Locate_Starting_Platform.start_pos.y - distance;
        }
        else if (dirrection == "Up")
        {
            end_pos = Locate_Starting_Platform.start_pos.y + distance;
        }
        //Halfs the speed.
        speed = speed / 200;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= 1;
        }
        //Checks if it is moving forward or backwards, the timer is up and if it is paused.
        if(finished == false && paused == false && timer == 0)
        {
            //Checks the dirrection and if it has meet the end position.
            if (dirrection == "Left" && transform.position.x >= end_pos)
            {
                //Changes the position every frame.
                transform.position += new Vector3(-speed, Locate_Starting_Platform.start_pos.y, Locate_Starting_Platform.start_pos.z);
                //Checks if it has meet the end position and if so reverses the motion and sets the timer.
                if (transform.position.x < end_pos)
                {
                    finished = true;
                    timer = delay;
                }
            }
            else if(dirrection == "Right" && transform.position.x <= end_pos)
            {
                transform.position += new Vector3(speed, Locate_Starting_Platform.start_pos.y, Locate_Starting_Platform.start_pos.z);
                if (transform.position.x > end_pos)
                {
                    finished = true;
                    timer = delay;
                }
            }
            else if (dirrection == "Down" && transform.position.y >= end_pos)
            {
                transform.position += new Vector3(Locate_Starting_Platform.start_pos.x, -speed, Locate_Starting_Platform.start_pos.z);
                if (transform.position.y < end_pos)
                {
                    finished = true;
                    timer = delay;
                }
            }
            else if (dirrection == "Up" && transform.position.y <= end_pos)
            {
                transform.position += new Vector3(Locate_Starting_Platform.start_pos.x, speed, Locate_Starting_Platform.start_pos.z);
                if (transform.position.y > end_pos)
                {
                    finished = true;
                    timer = delay;
                }
            }
        }
        //Checks if it is paused and if the timer is up.
        else if(paused == false && timer == 0)
        {
            //Checks the dirrection and if it has meet the start position.
            if (transform.position.x <= Locate_Starting_Platform.start_pos.x && dirrection == "Left")
            {
                //Changes the position every frame.
                transform.position += new Vector3(speed, Locate_Starting_Platform.start_pos.y, Locate_Starting_Platform.start_pos.z);
                //Checks if it has meet the start position and if so reverses the motion and sets the timer.
                if (transform.position.x > Locate_Starting_Platform.start_pos.x)
                {
                    finished = false;
                    timer = delay;
                }
            }
            else if (transform.position.x >= Locate_Starting_Platform.start_pos.x && dirrection == "Right")
            {
                transform.position += new Vector3(-speed, Locate_Starting_Platform.start_pos.y, Locate_Starting_Platform.start_pos.z);
                if (transform.position.x <= Locate_Starting_Platform.start_pos.x)
                {
                    finished = false;
                    timer = delay;
                }
            }
            else if (transform.position.y <= Locate_Starting_Platform.start_pos.y && dirrection == "Down")
            {
                transform.position += new Vector3(Locate_Starting_Platform.start_pos.x, speed, Locate_Starting_Platform.start_pos.z);
                if (transform.position.y >= Locate_Starting_Platform.start_pos.y)
                {
                    finished = false;
                    timer = delay;
                }
            }
            else if (transform.position.y >= Locate_Starting_Platform.start_pos.y && dirrection == "Up")
            {
                transform.position += new Vector3(Locate_Starting_Platform.start_pos.x, -speed, Locate_Starting_Platform.start_pos.z);
                if (transform.position.y <= Locate_Starting_Platform.start_pos.y)
                {
                    finished = false;
                    timer = delay;
                }
            }
        }
    }
}
