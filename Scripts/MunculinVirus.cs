using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculinVirus : MonoBehavior
{
    public GameObject virus;
    public float waktuMinmal, waktuMaksimal;
    public float posisiMinimal, posisiMaksimal;

    // Start is called before the first frame update
    void Start()
    {
        StartCorountine(MunculVirus());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator MunculVirus()
    {
        Instantiate(virus, transform.position + Vector3.right * Random.Range(posisiMinimal, posisiMaksimal), Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMinmal, waktuMaksimal));
        StartCorountine(MunculVirus());
    }
}