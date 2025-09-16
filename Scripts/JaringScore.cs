using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JaringScore : MonoBehavior
{
    public static int Score = 0;
    public Text ScoreUI;

    // Start is called before the first freme update
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("virus"))
        {
            Score += 1;
            ScoreUI.text = "Score : " + Score.ToString();
            Destory(collision.collider.gameObject);
        }
    }
}