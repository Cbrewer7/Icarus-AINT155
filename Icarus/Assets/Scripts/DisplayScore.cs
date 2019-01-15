using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{

    public Text allPointsDisplay;
    public Text allEnemiesDefDisplay;
    public Text allCollectiblesDisplay;

    AddScore scoreOverall;

    // Use this for initialization
    void Start()
    {
        allPointsDisplay = GetComponent<Text>();
        allEnemiesDefDisplay = GetComponent<Text>();
        allCollectiblesDisplay = GetComponent<Text>();

        scoreOverall = FindObjectOfType<AddScore>();


    }

    // Update is called once per frame
    void Update()
    {
        allPointsDisplay.text = scoreOverall.GetScore().ToString();
    }
}
