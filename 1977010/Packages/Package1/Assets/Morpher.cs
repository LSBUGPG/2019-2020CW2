using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morpher : MonoBehaviour
{

    public bool morphed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("q"))
        {
            Form1();            
        }
        if (Input.GetKeyDown("e"))
        {
            Form2();
        }
    }

    void Form1()
    {
        if(morphed == false)
        {
            this.transform.localScale = new Vector3(1f, 2f, 1f);
            morphed = true;
            transform.gameObject.tag = "Form1";
        }
        else
        {
            baseForm();
        }
    }
    void Form2()
    {
        if (morphed == false)
        {
            this.transform.localScale = new Vector3(2f, 2f, 2f);
            morphed = true;
            transform.gameObject.tag = "Form2";
        }
        else
        {
            baseForm();
        }
    }

    void baseForm()
    {
        this.transform.localScale = new Vector3(1f, 1f, 1f);
        morphed = false;
        transform.gameObject.tag = "BaseForm";
    }
}

    
