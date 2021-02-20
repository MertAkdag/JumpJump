using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonenTop : MonoBehaviour
{
    public float donmeHizi;
    public float bulletSpeed;
    public Rigidbody2D Bullet;
    public Transform atilanyer;
    public float atesSure;
    public GameObject oyunayarlari;
    void Start()
    {
        atesSure = 1.5f;
        oyunayarlari = GameObject.Find("GameController");
    }

    void Update()
    {
        if(oyunayarlari.transform.GetComponent<GameController>().oyunDevam == true)
        {
            atesSure -= Time.deltaTime;
        }
        
        this.transform.Rotate(0, 0, donmeHizi, Space.Self);

        if (atesSure <= 0)
        {
            var firedBullet = Instantiate(Bullet, atilanyer.position, transform.rotation);
            firedBullet.AddForce(atilanyer.up * bulletSpeed);
            Destroy(firedBullet.gameObject, 8);
            atesSure = 0.9f;
        }
    }
}
