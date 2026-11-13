using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public Player_health playerHealth_script;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Enemy")
        {
            //PlayMySound();
            //everywhere we reduce health we need to adjust the health bar 
            float tempHP = playerHealth_script.health;
            float tempMaxHP = playerHealth_script.max_health;
            healthBar.fillAmount = tempHP / tempMaxHP;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Heal")
        {
            float tempHP = playerHealth_script.health;
            float tempMaxHP = playerHealth_script.max_health;
            healthBar.fillAmount = tempMaxHP/tempHP;
        }
    }
}
