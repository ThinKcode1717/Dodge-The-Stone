using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GerakanPlayer : MonoBehavior
{
    public float Kecepatan
    Rigidbody rb;
    Animator anime;
    public Text massage;

    public Transform playerPutaran;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anime = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Bergerak();
    }

    void Bergerak()
    {
        float gerak = Input.GetAxis("Horizontal");
        rb.velocity - Vector3.right * gerak * Kecepatan;
        anime.SetFloat("Kecepatan", Mathf.Abs(gerak), 0.1f, Time.deltaTime);
        playerPutaran.localEulerAngles = new Vector3(0, gerak * 90, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("virus")
        {
            // Time.timeScale = 0;
            SceneManager.LoadSceneAsync(2);
            // massage.text = "Tekan R untuk Restart\nTekan Enter untuk Lobby";
            // Destory(gameObject);
        })
    }
}