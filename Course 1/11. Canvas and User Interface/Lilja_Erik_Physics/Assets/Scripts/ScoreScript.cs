using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI MyScore;
    private int scoreNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreNumber = 0;
        MyScore.text = "Score : " + scoreNumber;
    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "MyCoin")
        {
            scoreNumber += 1000;
            Destroy(Coin.gameObject);
            MyScore.text = "Score : " + scoreNumber;
        }
    }
}
