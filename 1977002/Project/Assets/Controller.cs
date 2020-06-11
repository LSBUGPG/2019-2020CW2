
using UnityEngine;

public class Controller : MonoBehaviour
{

    public UIController UI;

    public float startTime;
    public float clickTime;

    public bool react = false;

    public float highScore;
    public float latestScore;

    void Update()
    {
        if (react && Random.Range(0,10000) > 9950)
        {
            ChangeColor();
        }      
    }

    public void Reset()
    {
        react = true;
        UI.ToggleResetButton();
    }

    public void ChangeColor()
    {
        UI.ChangeImageColor(Color.green);
        startTime = Time.time;
    }

    public void GivenInput()
    {
        if (react)
        {
            clickTime = Time.time;
            latestScore = clickTime - startTime;
            UI.SetLatestScore(latestScore);
            if (latestScore < highScore)
            {
                highScore = latestScore;
                UI.SetHighScore(highScore);
            }
            else if (highScore == 0)
            {
                highScore = latestScore;
            }
            react = false;
            UI.ToggleResetButton();
            UI.ChangeImageColor(Color.red);
        }
        
    }

    
}
