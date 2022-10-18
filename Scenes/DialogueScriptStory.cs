using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Xml.Serialization;
using Mono.CompilerServices.SymbolWriter;

public class DialogueScriptStory : MonoBehaviour
{
    public TextMeshProUGUI textDislpay;
    public string[] sentences;
    private int index;
    public float typingSpeed ;
   
    public AudioSource audiooo;
 

    void Start()
    {
        audiooo = GetComponent<AudioSource>();
   
        
        StartCoroutine(Type());
    }

    void Update()
    {
        if (textDislpay.text == sentences[index])
        {

            NextSentence();

        }
      
        else {
         

        }
    }

    IEnumerator Type() {

        foreach (char letter in sentences[index].ToCharArray() ){

            textDislpay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
          
        } 
        
    }

    public void NextSentence() {
       

      
        

        if (index < sentences.Length - 1)
        {
            audiooo.Play();
            index++;
            textDislpay.text = "";
            StartCoroutine(Type());
        
        }
        else {

            textDislpay.text = "";
          
            
        }
    }


}
