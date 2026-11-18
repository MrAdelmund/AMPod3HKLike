using UnityEngine;

public class Destroy_Object : MonoBehaviour
{
    public Repulate_Objects Repulate_Objects_Script;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Detects if object is touching another object.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Detects of that object is the death barrier.
        if (collision.gameObject.tag == "Death")
        {
            //Destroys the object and sets timer to delay and sets object exsists to false.
            Repulate_Objects_Script.timer = Repulate_Objects_Script.delay;
            Destroy(gameObject);
            Repulate_Objects_Script.object_exsists = false;
        }
    }
}
