using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TalkWithNPC : MonoBehaviour
{
    public string[] dialogueLines;
    private int currentLineIndex;
    public GameObject gameObjectUI;
    public TextMeshProUGUI interactionText;
    public GameObject audio;
    private void Start()
    {
        //AudioListener.volume = 0f;
    }
    private void OnTriggerEnter(Collider other)
    {
    if (other.CompareTag("Player"))
         {
          gameObjectUI.SetActive(true);
          print("Триггер нпс");
         }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentLineIndex < dialogueLines.Length)
            {
                interactionText.text = dialogueLines[currentLineIndex];
                currentLineIndex ++;
            }
        }
        if (currentLineIndex == 5)
        {
            audio.SetActive(true);
            //AudioListener.volume = 1.0f;
        }
    }

}
