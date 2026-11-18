using UnityEngine;

public class Object_Breaks_Object : MonoBehaviour
{
    public GameObject the_destroying_object;
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
        if(collision.gameObject == the_destroying_object)
        {
            Debug.Log("break");
            Destroy(gameObject);
        }
    }
}
