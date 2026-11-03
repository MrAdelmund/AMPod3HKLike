using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public AudioClip hurtSound;
public float health = 100;
public int lives = 3;
int maxLives;
public TMPro.TextMeshProUGUI healthText;
public Image healthBar;
private float maxHealth;


public void PlayMySound()
{
    if (hurtSound != null)
    {
        //play sound on the camera's audio source, so we can always hear it
        Camera.main.GetComponent<AudioSource>().PlayOneShot(hurtSound);
    }
}
// Start is called before the first frame update
void Start()
{
    maxLives = lives;
    healthText.text = "Health: " + health;
    lives = PlayerPrefs.GetInt("lives");
    maxHealth = health;
}

// Update is called once per frame
void Update()
{

}

void ShouldIDie()
{
    if (health <= 0)
    {
        lives--;
        if (lives > 0)
        {
            PlayerPrefs.SetInt("lives", lives);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            PlayerPrefs.SetInt("lives", maxLives);
            SceneManager.LoadScene("Lose");
        }
    }
}

private void OnCollisionEnter2D(Collision2D collision)
{
    Debug.Log(collision.gameObject.name);
    if (collision.gameObject.tag == "Enemy")
    {
        health -= 3;
        //PlayMySound();
        //everywhere we reduce health we need to adjust the health bar 
        healthBar.fillAmount = health / maxHealth;
        healthText.text = "Health: " + health;
        ShouldIDie();
    }
}
private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.tag == "Water")
    {
        health -= 100;
        //everywhere we reduce health we need to adjust the health bar 
        healthBar.fillAmount = health / maxHealth;
        healthText.text = "Health: " + health;
        //Destroy(collision.gameObject);
        ShouldIDie();
    }
    if (collision.gameObject.tag == "EnemyBullet")
    {
        health -= 1;
        PlayMySound();
        healthText.text = "Health: " + health;
        Destroy(collision.gameObject);
        ShouldIDie();
    }
}
private void OnTriggerStay2D(Collider2D collision)
{
    if (collision.gameObject.tag == "Enemy2")
    {
        health -= 1;
        //everywhere we reduce health we need to adjust the health bar 
        healthBar.fillAmount = health / maxHealth;
        healthText.text = "Health: " + health;
        //Destroy(collision.gameObject);
        ShouldIDie();

    }
}
}