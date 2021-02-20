using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    public GameObject oyunayarlari;

    private void Start()
    {
        oyunayarlari = GameObject.Find("GameController");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "engel" || collision.gameObject.tag == "top")
        {
            oyunayarlari.transform.gameObject.GetComponent<GameController>().oyunDevam = false;
            oyunayarlari.transform.gameObject.GetComponent<GameController>().OyunBitti();
            Destroy(gameObject);
        }
    }
}
