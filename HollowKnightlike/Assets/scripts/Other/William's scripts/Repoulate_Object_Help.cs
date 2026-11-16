using UnityEngine;

public class Repoulate_Object_Help : MonoBehaviour
{
    public PlayerAttack playerAttack_script;
    public Repulate_Objects Repulate_Objects_Script;
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
        if (collision.gameObject.tag == "Bullet" && playerAttack_script.isAttacking == true)
        {
            Repulate_Objects_Script.timer = Repulate_Objects_Script.delay;
            Repulate_Objects_Script.object_exsists = false;
        }
    }
}
