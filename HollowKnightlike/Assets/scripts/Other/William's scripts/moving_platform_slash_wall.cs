using UnityEngine;

public class moving_platform_slash_wall : MonoBehaviour
{
    public string dirrection = "Left";
    public float speed = 4f;
    public float distance = 6f;
    private bool finished = false;
    public int delay = 0;
    private Vector3 start_pos = new Vector3(0f, 0f, 0f);
    private float end_pos = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Stores the start position and the end position.
        Vector3 start_pos = transform.position;
        if(dirrection == "Left")
        {
            end_pos = start_pos.x - distance;
        }else if(dirrection == "Right")
        {
            end_pos = start_pos.x + distance;
        }
        else if (dirrection == "Down")
        {
            end_pos = start_pos.y - distance;
        }
        else if (dirrection == "Up")
        {
            end_pos = start_pos.y + distance;
        }
        //Halfs the speed.
        speed = speed / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if it is moving forward or backwards.
        if(finished == false) {
            //Checks the dirrection and if it has meet the end position.
            if (dirrection == "Left" && transform.position.x > end_pos)
            {
                //Changes the position every frame.
                transform.position += new Vector3(-speed, start_pos.y, start_pos.z);
                //Checks if it has meet the end position and if so reverses the motion.
                if (transform.position.x < end_pos)
                {
                    finished = true;
                }
            }
            else if(dirrection == "Right" && transform.position.x < end_pos)
            {
                transform.position += new Vector3(speed, start_pos.y, start_pos.z);
                if (transform.position.x > end_pos)
                {
                    finished = true;
                }
            }
            else if (dirrection == "Down" && transform.position.y < end_pos)
            {
                transform.position += new Vector3(start_pos.x, -speed, start_pos.z);
                if (transform.position.y < end_pos)
                {
                    finished = true;
                }
            }
            else if (dirrection == "Down" && transform.position.y < end_pos)
            {
                transform.position += new Vector3(start_pos.x, speed, start_pos.z);
                if (transform.position.y > end_pos)
                {
                    finished = true;
                }
            }
        }
        else
        {
            //Checks the dirrection and if it has meet the start position.
            if (transform.position.x < start_pos.x && dirrection == "Left")
            {
                //Changes the position every frame.
                transform.position += new Vector3(speed, start_pos.y, start_pos.z);
                //Checks if it has meet the start position and if so reverses the motion.
                if (transform.position.x > start_pos.x)
                {
                    finished = false;
                }
            }
            else if (transform.position.x > start_pos.x && dirrection == "Right")
            {
                transform.position += new Vector3(-speed, start_pos.y, start_pos.z);
                if (transform.position.x < start_pos.x)
                {
                    finished = false;
                }
            }
            else if (transform.position.y < start_pos.y && dirrection == "Down")
            {
                transform.position += new Vector3(start_pos.x, speed, start_pos.z);
                if (transform.position.y > start_pos.y)
                {
                    finished = false;
                }
            }
            else if (transform.position.y > start_pos.y && dirrection == "Up")
            {
                transform.position += new Vector3(start_pos.x, -speed, start_pos.z);
                if (transform.position.y < start_pos.y)
                {
                    finished = false;
                }
            }
        }
    }
}
