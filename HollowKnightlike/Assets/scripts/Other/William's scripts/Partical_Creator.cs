using UnityEngine;

public class Partical_Creator : MonoBehaviour
{
    public GameObject partical;
    public int life_time = 10;
    public int timer = 0;
    public int delay = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1;
        if (timer <= 0)
        {
            GameObject new_partical = Instantiate(partical, transform.position, Quaternion.identity);
            timer = delay;
            Destroy(new_partical, life_time);
        }
    }
}
