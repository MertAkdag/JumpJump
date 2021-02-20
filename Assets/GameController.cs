using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public bool oyunDevam = false;

    public GameObject Character;

    public GameObject bitisPanel;

    public float score;
    public float bestScore;

    public Text[] scoreyazi;
    public Text bestscoreyazi;

    public GameObject flapbuton;

    public GameObject TapToStart;

    void Start()
    {
        bitisPanel.SetActive(false);
        score = 0;
        bestScore = PlayerPrefs.GetFloat("best");
        oyunDevam = false;
    }

    void Update()
    {

        scoreyazi[0].text = " " + "" + (int)score;
        scoreyazi[1].text = " " + "" + (int) score;
        bestscoreyazi.text = "  " + "" + (int)bestScore;

        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetFloat("best", bestScore);
        }

        if(oyunDevam == true)
        {
            score += Time.deltaTime;
        }
    }


    public void OyunBasladi()
    {
        if(oyunDevam == false)
        {
            
            
            oyunDevam = true;
        }
        Destroy(TapToStart.gameObject);
        Character.transform.gameObject.GetComponent<PlayerController>().rb.transform.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
        
    }

    public void OyunBitti()
    {
        oyunDevam = false;
        Destroy(flapbuton.gameObject);
        bitisPanel.SetActive(true);
    }

    

    

    public void MusicButton()
    {

    }

    
    public void ResetButton()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void ExitButton()
    {
        Application.Quit();
    }


}
