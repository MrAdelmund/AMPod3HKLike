using UnityEngine;

public class Object_Breaks_Object : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Object_Destroyer")
        {
            Debug.Log("break");
            Destroy(gameObject);
        }
    }
}
