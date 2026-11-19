using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public AudioClip speakSound;

    private int index;

    public void PlayMySound()
    {
        if (speakSound != null)
        {
            //play sound on the camera's audio source, so we can always hear it
            Camera.main.GetComponent<AudioSource>().PlayOneShot(speakSound);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        //allows the player to go to the next line of dialogue
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
                PlayMySound();
            }
            else
            {
                //dialogue box and text disappear if no more dialogue
                StopAllCoroutines();
                textComponent.text = lines[index];
            }

        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());

    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
