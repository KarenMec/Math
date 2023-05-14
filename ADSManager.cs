using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class ADSManager : MonoBehaviour
{
    private InterstitialAd interstitialAd;
    private string _adUnitId = "ca-app-pub-3940256099942544/1033173712"; //"ca-app-pub-8023669923336275/9000002321";
    private int conunt_try;

    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) => { });

        // Call the LoadInterstitialAd method
        LoadInterstitialAd();
                
        conunt_try = 0;
    }

    /// <summary>
    /// Loads the interstitial ad.
    /// </summary>
    public void LoadInterstitialAd()
    {
        // Clean up the old ad before loading a new one.
        if (interstitialAd != null)
        {
            interstitialAd.Destroy();
            interstitialAd = null;
        }

        Debug.Log("Loading the interstitial ad.");

        // Create our request used to load the ad.
        var adRequest = new AdRequest.Builder()
                .AddKeyword("unity-admob-sample")
                .Build();

        // Send the request to load the ad.
        interstitialAd = new InterstitialAd(_adUnitId);
        interstitialAd.LoadAd(adRequest);

        interstitialAd.OnAdLoaded += HandleOnAdLoaded;
        interstitialAd.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        interstitialAd.OnAdClosed += HandleOnAdClosed;
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        // Load a new interstitial ad after the previous one is closed.
        LoadInterstitialAd();
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        Debug.Log("Interstitial ad loaded successfully.");

        if (interstitialAd.IsLoaded())
        {
            interstitialAd.Show();
            print("Interstitial ad is ready to be shown.");
        }
        else
        {
            print("Interstitial ad is not ready to be shown.");
        }

        // Ad loaded successfully, you can now show the ad when desired.

        // Load a new ad after the current ad is shown
        LoadInterstitialAd();
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        Debug.LogError("Interstitial ad failed to load an ad with error: " + args.LoadAdError);
    }

    private IEnumerator OnMouseUp()
    {
        switch (gameObject.name)
        {
            case "B_Enter":
                print("Enter click");
                conunt_try ++;
                print(conunt_try);
                break;
        }

        if (conunt_try == 5)
        {
            if (interstitialAd.IsLoaded())
            {
                // Show the ad
                interstitialAd.Show();
                //LoadInterstitialAd();
            }
            print("Oooo it is 5");
            conunt_try = 0;
        }
            
        yield return null;
    } 
}
