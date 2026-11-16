using UnityEngine;

public class Repulate_Objects : MonoBehaviour
{
    public GameObject the_object;
    public int delay = 100;
    public int timer = 0;
    public string the_tag;
    public bool object_exsists = false;
    public int max_object_count = 10;
    public int total_object_count = 0;
    public bool is_maximum_object_count = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer >= 0)
        {
            timer -= 1;
            Debug.Log(timer);
        }
        if(timer >= 0 && object_exsists == false && total_object_count < max_object_count || timer >= 0 && object_exsists == false && is_maximum_object_count == false)
        {
            GameObject new_object = Instantiate(the_object, transform.position, Quaternion.identity);
            object_exsists = true;
            total_object_count += 1;
        }
    }
}
