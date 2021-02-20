using UnityEngine;
using UnityEngine.Advertisements;

public class reklam : MonoBehaviour
{
   public string GameID = "GAME ID";
    public string InterstitialPlacementID = "video";
    public bool testModu = true;
    private static int olmeSayisi;
    private bool interstitialGosterilecek = false;
 
    void Start()
    {
        // Unity Ads'i kullanıma hazır hale getir
        Advertisement.Initialize( GameID, testModu );
        if (interstitialGosterilecek)
        {
            // Interstitial reklam gösterilmeye hazır mı diye kontrol et
            if (Advertisement.IsReady(InterstitialPlacementID))
            {
                // Interstitial reklam gösterilmeye hazır, o halde reklamı göster!
                Advertisement.Show(InterstitialPlacementID);

                // Interstitial'ı gösterdik, artık bu if koşulunu kontrol etmemize gerek yok
                interstitialGosterilecek = false;

            }
        }
    }
 
    void Update()
    {

}
 

 
    public void InterstitialGoster()
    {
        interstitialGosterilecek = true;
                float sayi;
        
        sayi = Random.Range(0, 100);

        if( (++olmeSayisi) % 3 == 0 )
        {
            InterstitialGoster();
        }
      
    }

}
/*
 
*/