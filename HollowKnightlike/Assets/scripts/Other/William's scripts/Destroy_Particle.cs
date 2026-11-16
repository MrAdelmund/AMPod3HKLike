using UnityEngine;

public class Destroy_Particle : MonoBehaviour
{
    private float destruction_delay = 0.02f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Particle" && collision.gameObject.tag != "Bullet")
        {
            Destroy(gameObject, destruction_delay);
        }
    }
}
