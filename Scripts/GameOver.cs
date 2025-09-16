using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehavior
{
    public Text EndScore;

    // Start is Called before the first frame update
    void Start()
    {
        EndScore = GetComponent<Text> ();
        int ScoreAkhir = JaringScore.Score;
        EndScore.Text = ScoreAkhir.ToString();
        // Destroy(gameObject);
    }

    //  Update is called once per frame
    void Update()
    {
        
    }
}