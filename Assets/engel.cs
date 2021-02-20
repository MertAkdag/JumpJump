using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel : MonoBehaviour
{

    public float yokolma;

    public GameObject oyunayarlari;
    
    void Start()
    {
        oyunayarlari = GameObject.Find("GameController");
        yokolma = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(oyunayarlari.transform.gameObject.GetComponent<GameController>().oyunDevam== true)
        {
            yokolma -= Time.deltaTime;
        }
        

        if(yokolma <= 0)
        {
            Destroy(gameObject);
        }
    }

    
}
