using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSprite : MonoBehaviour
{
    public Sprite DaySprite;
    public Sprite NightSprite;
    private SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Day()
    {
        sp.sprite = DaySprite;
    }
    public void Night()
    {
        sp.sprite = NightSprite;
    }
}
