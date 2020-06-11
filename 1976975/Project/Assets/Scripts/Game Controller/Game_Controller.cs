using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/// <summary>
/// This class is responsible for managing the game itself. You can set the number of rounds, round length, points to win etc. At the end of every round there is a break and after said break a new round is initialised
/// </summary>
public class Game_Controller : MonoBehaviour
{
    public int numOfRounds;
    public float roundTimer;
    public float breakLength;
    public int pointsPerKill;
    public int pointThreshhold;
    public int pointThreshholdIncreasePerRound;
    public TextMeshProUGUI timerTxt;
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI roundTxt;
    public TextMeshProUGUI breakTxt;
    public GameObject breakObj;
    public GameObject youWin;
    public GameObject youLose;
    private AI_Controller aiController;

    [HideInInspector]public bool roundBreak;
    [HideInInspector]public int points;
    [HideInInspector]public int currRound = 0;
    private float timer;

    /// <summary>Starts this instance.</summary>
    /// <remarks>References the aiController and initialises the 1st round</remarks>
    /// <example>
    ///   <code>private void Start()
    /// {
    ///     aiController = GameObject.Find("AI Controller").GetComponent&lt;AI_Controller&gt;();
    ///     InitialiseRound();
    /// }</code>
    /// </example>
    private void Start()
    {
        aiController = GameObject.Find("AI Controller").GetComponent<AI_Controller>();
        InitialiseRound();
    }

    /// <summary>Controls Round Timer</summary>
    /// <remarks>Clamps timer so it can't display lower than 0. If the round timer counts to zero then check round win conditions</remarks>
    /// <example>
    ///   <code>void Update()
    /// {
    ///     timer = Mathf.Clamp(timer, 0, roundTimer);
    ///     timer -= Time.deltaTime;
    ///     timerTxt.text = string.Format("Time: {0}" , timer.ToString("F0"));
    ///     if (timer &lt;= 0)
    ///     {
    ///         CheckRoundWin();
    ///     }
    /// }</code>
    /// </example>
    void Update()
    {
        timer = Mathf.Clamp(timer, 0, roundTimer);
        timer -= Time.deltaTime;
        timerTxt.text = string.Format("Time: {0}" , timer.ToString("F0"));
        if (timer <= 0)
        {
            CheckRoundWin();
        }
    }

    /// <summary>Adds points to player score</summary>
    /// <param name="pointsToAdd">The points to add.</param>
    /// <remarks>Takes given value and adds it to the current round points. Updates score text</remarks>
    /// <example>
    ///   <code>public void AddPoints(int pointsToAdd) 
    /// {
    ///     points += pointsToAdd;
    ///     scoreTxt.text = string.Format("Points: {0}/{1}", points, pointThreshhold);
    /// }</code>
    /// </example>
    public void AddPoints(int pointsToAdd) 
    {
        points += pointsToAdd;
        scoreTxt.text = string.Format("Points: {0}/{1}", points, pointThreshhold);
    }

    /// <summary>Checks Win Conditions</summary>
    /// <remarks>Checks if enough points have been aqquired and if so initiates a round break. If all rounds have been completed then you win</remarks>
    /// <example>
    ///   <code>void CheckRoundWin() 
    /// {
    ///     if (points &gt;= pointThreshhold &amp;&amp; currRound &gt;= numOfRounds)
    ///     {
    ///         youWin.SetActive(true);
    ///         Time.timeScale = 0;
    ///     }
    ///
    ///     else if (points &gt;= pointThreshhold)
    ///     {
    ///         RoundBreak();
    ///     }
    ///
    ///     else if (points &lt; pointThreshhold)
    ///     {
    ///         youLose.SetActive(true);
    ///         Time.timeScale = 0;
    ///     }
    /// }</code>
    /// </example>
    void CheckRoundWin() 
    {
        if (points >= pointThreshhold && currRound >= numOfRounds)
        {
            youWin.SetActive(true);
            Time.timeScale = 0;
        }

        else if (points >= pointThreshhold)
        {
            RoundBreak();
        }

        else if (points < pointThreshhold)
        {
            youLose.SetActive(true);
            Time.timeScale = 0;
        }
    }

    /// <summary>Initiates a break between rounds</summary>
    /// <remarks>Destroys all current enemies that are alive. Initiates break timer and when it reaches 0 then the round number is increased and a new round is initialised</remarks>
    /// <example>
    ///   <code>public float privBreakTimer;
    /// public void RoundBreak() 
    /// {
    ///     GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
    ///     for (int i = 0; i &lt; enemies.Length; i++)
    ///     {
    ///         Destroy(enemies[i]);
    ///         aiController.RemoveFromList(enemies[i]);
    ///     }
    ///
    ///     breakObj.SetActive(true);
    ///     breakTxt.text = string.Format("{0}", privBreakTimer.ToString("F0"));
    ///
    ///     privBreakTimer -= Time.deltaTime;
    ///     if (privBreakTimer &lt;= 0)
    ///     {
    ///         breakObj.SetActive(false);
    ///
    ///         currRound = Mathf.Clamp(currRound, 1, numOfRounds);
    ///         currRound++;
    ///
    ///         InitialiseRound();
    ///
    ///     }
    /// }</code>
    /// </example>
    public float privBreakTimer;
    public void RoundBreak() 
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
            aiController.RemoveFromList(enemies[i]);
        }

        breakObj.SetActive(true);
        breakTxt.text = string.Format("{0}", privBreakTimer.ToString("F0"));

        privBreakTimer -= Time.deltaTime;
        if (privBreakTimer <= 0)
        {
            breakObj.SetActive(false);

            currRound = Mathf.Clamp(currRound, 1, numOfRounds);
            currRound++;

            InitialiseRound();

        }
    }

    /// <summary>Initialises the round.</summary>
    /// <remarks>Updates spawn pool based on current round. Resets values back to default and spawns enemies until the max number is reached again</remarks>
    /// <example>
    ///   <code>void InitialiseRound() 
    /// {
    ///     aiController.UpdateSpawnPool();
    ///     points = 0;
    ///     timer = roundTimer;
    ///     privBreakTimer = breakLength;
    ///
    ///     scoreTxt.text = string.Format("Points: {0}/{1}", points, pointThreshhold);
    ///     roundTxt.text = string.Format("Round: {0}", currRound);
    ///
    ///     for (int i = 0; i &lt; aiController.maxNumbOfEnemies; i++)
    ///     {
    ///         aiController.EnemyIndexRoll();
    ///     }
    /// }</code>
    /// </example>
    void InitialiseRound() 
    {
        aiController.UpdateSpawnPool();
        points = 0;
        timer = roundTimer;
        privBreakTimer = breakLength;

        scoreTxt.text = string.Format("Points: {0}/{1}", points, pointThreshhold);
        roundTxt.text = string.Format("Round: {0}", currRound);

        for (int i = 0; i < aiController.maxNumbOfEnemies; i++)
        {
            aiController.EnemyIndexRoll();
        }
    }
}
