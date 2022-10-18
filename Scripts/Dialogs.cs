using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogs : MonoBehaviour
{
    public GameObject firstDialog;
    [SerializeField] public Rigidbody2D rb;
    public GameObject homelessDialog;
    public GameObject gangDialog;
    public GameObject fahiseDialog;
    public GameObject fahise;
    public GameObject sonunda;


    void Start()
    {
        

        firstDialog.SetActive(false);
        
        homelessDialog.SetActive(false);

        gangDialog.SetActive(false);

        sonunda.SetActive(false);

        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        if (rb.transform.position.x >= -14 && rb.transform.position.x <= 50)
        {

            firstDialog.SetActive(true);


        }
        else { 
            firstDialog.SetActive(false);
        }
        if (rb.transform.position.x >= 58 && rb.transform.position.x <= 120)
        {

            homelessDialog.SetActive(true);
        }
        else {

            homelessDialog.SetActive(false);
        }

        if (rb.transform.position.x >= 138 && rb.transform.position.x <= 175 )
        {

            gangDialog.SetActive(true);
        }
        else
        {

            gangDialog.SetActive(false);
        }
        if (rb.transform.position.x >= 180 && rb.transform.position.x <= 187)
        {

            fahiseDialog.SetActive(true);
        }
        else
        {

            fahiseDialog.SetActive(false);
        }
        if (rb.transform.position.x >= 190 && rb.transform.position.x <= 230)
        {

            fahise.SetActive(true);
        }
        else
        {

            fahise.SetActive(false);
        }
        if (rb.transform.position.x >= 282 && rb.transform.position.x <= 300)
        {

            sonunda.SetActive(true);
        }
        else
        {

            sonunda.SetActive(false);
        }
    }
}
