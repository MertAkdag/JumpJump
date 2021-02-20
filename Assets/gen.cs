using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gen : MonoBehaviour
{
    public Rigidbody2D[] engeller;

    public float spawnTime;

    int yon;

    public float hiz;

    public bool spawnoldu;

    public GameObject oyunayarlari;

    void Start()
    {
        spawnTime = 1f;
        yon = Random.RandomRange(0, 2);
        spawnoldu = true;
        oyunayarlari = GameObject.Find("GameController");
        spawnoldu = true;
    }

    
    void Update()
    {
        if(oyunayarlari.gameObject.GetComponent<GameController>().oyunDevam == true)
        {
            spawnTime -= Time.deltaTime;
        }

        if(spawnTime <= 0)
        {
            spawnoldu = false;
        }


        if(yon == 0 && spawnoldu == false)
        {
            spawnoldu = true;
            Instantiate(engeller[Random.RandomRange(0,2)], transform.position, transform.rotation);
            yon = 1;
            spawnTime = 1.5f;
        }

        if(yon == 1 && spawnoldu == false)
        {
            spawnoldu = true;
            Instantiate(engeller[Random.RandomRange(2, 4)], transform.position, transform.rotation);
            yon = 0;
            spawnTime = 1.5f;
        }

    }
}
