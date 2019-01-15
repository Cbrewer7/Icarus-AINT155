using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour {

    [SerializeField] int pointsperenemiesDef = 10;
    [SerializeField] int pointpercollectable = 5;

    [SerializeField] int enemiesDefPoints = 0;
    [SerializeField] int collectablePoints = 0;

    [SerializeField] int enemiesDef = 0;
    [SerializeField] int collectablesFound = 0;

    [SerializeField] int playerScore = 0;

    private bool gameStats = false;

    public Text allPointsDisplay;
    public Text allEnemiesDefDisplay;
    public Text allCollectiblesDisplay;

    //public Text testDisplay;

    private void Awake()
    {

        //Finding how many of the game object containing this script there are
        int addScoreCount = FindObjectsOfType<AddScore>().Length;
        if (addScoreCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }

    private void Start()
    {

        // Not destroying the object keeping score
        //if (!gameStats)
        //{
        //gameStats = true;
        //// The object will remain the same when changing scenes
        //DontDestroyOnLoad(transform.gameObject);
        //}
        //else
        //{
        //// Destroys the copy of the object that appears when a new scene is loaded
        //Destroy(gameObject);
        //}

    }

    private void Update()
    {
        allPointsDisplay.text = "Overall Score: " + playerScore ;
        allEnemiesDefDisplay.text = "Enemies Defeated: " + enemiesDef;
        allCollectiblesDisplay.text = "Balloons Found: " + collectablesFound;

        //testDisplay.text = "Kills: " + enemiesDef;
    }

    // Players overall Score
    public void AddToScore()
    {

        playerScore += collectablePoints + enemiesDefPoints;
        
    }

    public int GetScore()
    {
        return playerScore;
    }

    // Adding the overall Enemy defeated points
    public void AddToEnemiesDef()
    {
        enemiesDef += pointsperenemiesDef /10;
        enemiesDefPoints += pointsperenemiesDef;
    }
    // Adding the overall amount of collectables points
    public void AddToCollectablesFound()
    {
        collectablesFound += pointpercollectable /5;
        collectablePoints += pointpercollectable;
    }



    //public delegate void SendScore(int theScore);
    //public static event SendScore OnSendScore;

    //public int score = 0;
    //public bool scoreSent = false;

    //private void OnDestroy()
    //{
    //    if(OnSendScore != null)
    //    {
    //        if(!scoreSent)
    //        {
    //            scoreSent = true;
    //            OnSendScore(score);
    //        }
    //    }
    //}
}
