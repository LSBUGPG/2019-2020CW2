//// Coin Collect

//This script is about players collecting coins and adding the coins to a score total. There are 2 scripts to explain here: CoinObtain and ScoreManager.

//    CoinObtain:

//    public int coinValue = 1;

//Staring with CoinObtain, this first line is easy: the amount of points that the coin will grant is 1 (this is also a public variable, meaning
//it can be changed in Unity).

//    private void OnTriggerEnter2D(Collider2D other)
//{
//    if (other.gameObject.CompareTag("Player"))
//    {
//        ScoreManager.instance.ChangeScore(coinValue);
//        Debug.Log("Coin hath been taken");
//    }
//}

//This next set of lines is easy as well; it essentially means if the coin comes into contact with any game object with the "Player" tag attached to it,
//    a message will appear in the console, confirming that the coin has been collected.

//    ScoreManager:

//        using TMPro;

//Before we mention the code itself, an important step for this code is to include this line, because Text (or in this case TextMeshPro) has it's own
//    set of code the player needs to call.

//        public static ScoreManager instance;
//public TextMeshProUGUI text;
//int score;

//This first set of code essentially set up variables that can be edited in Unity: the text for the score, the score itself, and the number
//    the score will show.

//    public void ChangeScore(int coinValue)
//{
//    score += coinValue;
//    text.text = "Score: " + score.ToString();
//}

//The last essential part of the code is simple: it all means that once a coin is collected, it changes the score text into how many coins the
//player has collected.