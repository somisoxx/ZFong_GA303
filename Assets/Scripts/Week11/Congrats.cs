using UnityEngine;
using TMPro;
using System.Collections;

public class Congrats : MonoBehaviour
{
    public TextMeshProUGUI textAnnounced;
    //public string[] lines;
    public float textSpeed;
    //private int index;

    private Pokemon pokemon;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //textAnnounced.text = string.Empty;
        //StartDialogue();
        this.gameObject.SetActive(false);
    }


    /*
    void StartDialogue()
    {
        //index = 0;
        //StartCoroutine(TypeLine());
        pokemon = FindObjectOfType<Pokemon>();
        StartCoroutine(TypeMessage($"YOU MISSED {pokemon.missCounter} TIMES.\nCLICK TO TRY AGAIN!"));
    }
    */
    public void Success()
    {
        this.gameObject.SetActive(true);
        pokemon = FindObjectOfType<Pokemon>();
        StartCoroutine(TypeMessage($"YOU MISSED {pokemon.missCounter} TIMES.\nCLICK TO TRY AGAIN!"));
    }
    public IEnumerator TypeMessage(string message)
    { 
        textAnnounced.text = "";
        foreach (char c in message)
        {
            textAnnounced.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    

    /*public void DisplayMessage(string message, int variable)
    {
        textAnnounced.text = message + variable.ToString();
    }
    */
}
