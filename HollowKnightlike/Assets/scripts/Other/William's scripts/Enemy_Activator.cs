using UnityEngine;

public class Enemy_Activator : MonoBehaviour
{
    public EnemyAI enemyAI_script;
    public bool activates = true;
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
        if(activates == true)
        {
            enemyAI_script.enemy_enabled = true;
        }
        else
        {
            enemyAI_script.enemy_enabled = false;
        }
    }
}
