using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour {

    // The points that add up to make the players overall score
    [SerializeField] int pointsperenemiesDef = 10;
    [SerializeField] int pointpercollectable = 5;

    // The amount of points acumulated by the player during the current runthrough of both variables
    [SerializeField] int enemiesDefPoints = 0;
    [SerializeField] int collectablePoints = 0;

    // The amount of Enemies killed and balloons collected
    [SerializeField] int enemiesDef = 0;
    [SerializeField] int collectablesFound = 0;

    // The Players overall score
    [SerializeField] int playerScore = 0;

    private bool gameStats = false;

    // The Text properties where the stats are displayed
    public Text allPointsDisplay;
    public Text allEnemiesDefDisplay;
    public Text allCollectiblesDisplay;

    private void Awake()
    {

        // Finding how many of the game object containing this script there are
        int addScoreCount = FindObjectsOfType<AddScore>().Length;
        // If there are more than one copy delete the current copy and use the newest
        // This is used to reset the score
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

    // Destroys the current game object
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
    

    private void Update()
    {
        // Display the correct stats in a good looking format
        allPointsDisplay.text = "Overall Score: " + playerScore ;
        allEnemiesDefDisplay.text = "Enemies Defeated: " + enemiesDef;
        allCollectiblesDisplay.text = "Balloons Found: " + collectablesFound;
    }

    // Players overall Score
    public void AddToScore()
    {

        playerScore += collectablePoints + enemiesDefPoints;
        
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
    
}
