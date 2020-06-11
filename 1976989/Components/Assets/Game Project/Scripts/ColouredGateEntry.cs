using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColouredGateEntry : MonoBehaviour
{
    // this script is not a part of my main components, just an extra component for my final game

    public bool blueMadeIt;
    public bool redMadeIt;
    public Text winText;

    public GameObject blueGate;
    public GameObject redGate;



    // Start is called before the first frame update
    void Start()
    {
        winText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
     if (blueGate.GetComponent<ColouredGateEntry>().blueMadeIt == true && redGate.GetComponent<ColouredGateEntry>().redMadeIt == true)

        {
            StartCoroutine(wait());
        }
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.transform.tag == ("Blue") && collision.gameObject.GetComponent<SpriteRenderer>().color == Color.blue)
        {
            GetComponent<BoxCollider2D>().enabled = false;

            blueMadeIt = true;

        }
        if (this.gameObject.transform.tag == ("Red") && collision.gameObject.GetComponent<SpriteRenderer>().color == Color.red)
        {
            GetComponent<BoxCollider2D>().enabled = false;

            redMadeIt = true;
        }
        
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
        winText.enabled = true;
        winText.text = "Congrats, you beat the level!";
    }
}
