using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour {

    [SerializeField] int pointsperenemiesDef = 10;
    [SerializeField] int pointpercollectable = 5;

    [SerializeField] int enemiesDef = 0;
    [SerializeField] int collectablesFound = 0;

    [SerializeField] int playerScore = 0;

    private bool gameStats = false;

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

    // Players overall Score
    public void AddToScore()
    {

        AddToCollectablesFound();
        AddToEnemiesDef();

        playerScore += collectablesFound + enemiesDef;
        
    }

    // Adding the overall Enemy defeated points
    public void AddToEnemiesDef()
    {
        enemiesDef += pointsperenemiesDef;
    }
    // Adding the overall amount of collectables points
    public void AddToCollectablesFound()
    {
        collectablesFound += pointpercollectable;
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
