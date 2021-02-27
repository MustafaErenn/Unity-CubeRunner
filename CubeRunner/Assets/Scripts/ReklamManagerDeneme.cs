using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GoogleMobileAds.Api;
using UnityEngine.UI;
using GoogleMobileAds;

public class ReklamManagerDeneme : MonoBehaviour
{

    private BannerView bannerReklam;
    private InterstitialAd gecisReklam;


    public Text kontrol_metni;

    public string appID = "";
    public string interstitialID = "";
    public string bannerID = "";
    public AdPosition adPosition;


    public void Start()
    {
        //MobileAds.Initialize(appID);
        BannerReklam();
        
    }

    public void BannerReklam()
    {
        bannerReklam = new BannerView(bannerID, AdSize.Banner, adPosition);
        Debug.Log("banner olusturuldu");
        AdRequest yeniReklam = new AdRequest.Builder().Build();
        
        Debug.Log("Banner request");
        bannerReklam.LoadAd(yeniReklam);

        
        bannerReklam.Show();
        Debug.Log("Banner gosterildi");

    }
    public void GecisReklam()
    {
        Debug.Log("Gecis Reklam= tam ekran");

        kontrol_metni.text = "Gecis reklam= tam ekran ";
        gecisReklam = new InterstitialAd(interstitialID);

        gecisReklam.OnAdClosed += InterstitialClosed;

        AdRequest yeniReklam = new AdRequest.Builder().Build();
        kontrol_metni.text = "Gecis reklam= tam ekran request ";
        Debug.Log("Gecis Reklam= tam ekran request");

        gecisReklam.LoadAd(yeniReklam);
        kontrol_metni.text = "Gecis reklam= tam ekran gosterildi";
        Debug.Log("Gecis Reklam= tam ekran gosterildi");

    }
    private void InterstitialClosed(object sender, EventArgs e)
    {
        GecisReklam();
    }

    public void GecisReklamGoster()
    {
        if (gecisReklam.IsLoaded())
        {
            gecisReklam.Show();
            kontrol_metni.text = "Gecis reklam= TAM EKRAN ACILDI ";
            Debug.Log("Gecis Reklam= tam ekran aciliyor");

        }
        else
        {
            Debug.Log("Gecis Reklam= tam ekran acilamadi ");
        }
    }


}
