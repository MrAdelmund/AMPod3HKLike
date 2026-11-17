using UnityEngine;

public class Kill_Enemy : MonoBehaviour
{
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
        if(collision.gameObject.tag == "Death")
        {
            //Destroys the object.
            Destroy(gameObject);
        }
    }
}
