using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public float Force;

    public Rigidbody2D rb;
    public GameObject oyunayarlari;

    void Awake()
    {
        
        oyunayarlari = GameObject.Find("GameController");
    }

    void Update()
    {
        if(oyunayarlari.transform.gameObject.GetComponent<GameController>().oyunDevam == true)
        {
            transform.position += transform.right * 5 * Time.deltaTime;
        }

        
    }

    

    public void FlapButton()
    {
        Flap();
    }
    public void Flap()
    {
       
        this.rb.AddForce(Vector2.up * Force);
    }
}
