using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    public GameObject dialogBox;
    public TMP_Text dialogText;
    public string dialog;
    public bool playerInRange = false;

    void Start()
    {
        dialogBox.SetActive(playerInRange);
        dialogText.text = dialog;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //allows dialogue box to appear if player is in the trigger zone
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            dialogBox.SetActive(playerInRange);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //if player is out of the trigger zone the dialogue disappears
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(playerInRange);
        }
    }
}