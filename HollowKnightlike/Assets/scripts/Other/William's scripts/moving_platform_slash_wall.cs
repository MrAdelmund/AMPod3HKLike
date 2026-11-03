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
        Vector3 start_pos = transform.position;
        end_pos = start_pos.x - distance;
    }

    // Update is called once per frame
    void Update()
    {
        if (finished == false) {
            if (dirrection == "Left" && transform.position.x > end_pos)
            {
                transform.position += new Vector3(-speed, start_pos.y, start_pos.z);
                if (transform.position.x < end_pos)
                {
                    finished = true;
                }
            }
        }
        else
        {
            if (transform.position.x < start_pos.x && dirrection == "Left")
            {
                transform.position += new Vector3(speed, start_pos.y, start_pos.z);
                if(transform.position.x > start_pos.x)
                {
                    finished = false;
                }
            }
        }
    }
}
