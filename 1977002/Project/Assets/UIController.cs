
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Image colorImage;
    public Text highScoreText;
    public Text latestScoreText;
    public GameObject resetButton;

    public Save saveClass;

    void Start()
    {
        highScoreText.text = "High Score: " + saveClass.LoadScore();
    }


    public void SetHighScore(float score)
    {
        highScoreText.text = "High Score: " + score;
        saveClass.SaveScore(score);
    }

    public void SetLatestScore(float score)
    {
        latestScoreText.text = "Latest Score: " + score;

    }

    public void ToggleResetButton()
    {
        resetButton.SetActive(!resetButton.activeSelf);
    }

    public void ChangeImageColor(Color color)
    {
        colorImage.color = color;
    }
}
