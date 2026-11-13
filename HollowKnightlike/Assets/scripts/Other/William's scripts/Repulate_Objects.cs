using UnityEngine;

public class Repulate_Objects : MonoBehaviour
{
    public GameObject the_object;
    public int delay = 100;
    public int timer = 0;
    public string the_tag;
    public bool object_exsists = false;
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
        }
        if(timer > 0 && object_exsists == false)
        {
            GameObject new_object = Instantiate(the_object, transform.position, Quaternion.identity);
            object_exsists = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == the_tag)
        {
            timer = delay;
            object_exsists = false;
        }
    }
}
