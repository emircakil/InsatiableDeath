using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Xml.Serialization;
using Mono.CompilerServices.SymbolWriter;
using System.ComponentModel;

public class DialogueScript : MonoBehaviour
{
    public TextMeshProUGUI textDislpay;
    public string[] sentences;
    private int index;
    public float typingSpeed ;
    public GameObject continueButton;
    public AudioSource audiooo;

    //GameObject varGameObject;



    void Start()
    {
        audiooo = GetComponent<AudioSource>();
       // varGameObject = GameObject.FindWithTag("Bullet");
        StartCoroutine(Type());
        
    }

    void Update()
    {
        if (textDislpay.text == sentences[index])
        {

            continueButton.SetActive(true);
            
        }
        else {

            continueButton.SetActive(false);

        }
    }

    IEnumerator Type() {

        foreach (char letter in sentences[index].ToCharArray() ){

            textDislpay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
            
          
        } 
        
    }

    public void NextSentence() {
       

        continueButton?.SetActive(false);
       

        if (index < sentences.Length - 1)
        {
            audiooo.Play();
            index++;
            textDislpay.text = "";
            StartCoroutine(Type());
           // varGameObject.GetComponent<Bullet>().enabled = false;
            

        }
        else {
            
            textDislpay.text = "";
            continueButton?.SetActive(false);
            //varGameObject.GetComponent<EnemyBullet>().enabled = false;
         
        }
    }


}
