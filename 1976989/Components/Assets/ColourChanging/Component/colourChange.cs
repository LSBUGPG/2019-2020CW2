using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourChange : MonoBehaviour
{
  
    SpriteRenderer rend;




    // Start is called before the first frame update
    void Start()
    {

        rend = GetComponent<SpriteRenderer>();
     
    }

    // Update is called once per frame
    void Update()
    {


    
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Red"))
        {
            rend.color = Color.red;

        }
        if (other.gameObject.tag == ("Green"))
        {
            rend.color = Color.green;

        }
        if (other.gameObject.tag == ("Blue"))
        {
            rend.color = Color.blue;
        }
    }
   
    

}
