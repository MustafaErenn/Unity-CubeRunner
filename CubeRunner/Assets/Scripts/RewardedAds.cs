﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;
using UnityEngine.UI;

public class RewardedAds : MonoBehaviour
{
    private RewardedAd rewardedAd;
    public Button reklams;
    public Text kontrol_metni;

    public GameObject player;
    public PlayerController playerScript;

    void Start()
    {

        player = GameObject.Find("Player");
        playerScript = player.GetComponent<PlayerController>();

        string adUnitId;
#if UNITY_ANDROID
        adUnitId = "ca-app-pub-3940256099942544/5224354917"; // buraya kendi reklam kodumuz eklenecek!!
#elif UNITY_IPHONE
adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
adUnitId = "unexpected_platform";
#endif
        MobileAds.Initialize(initStatus => { });
        this.rewardedAd = new RewardedAd(adUnitId);

        // Reklam çağırma işlemi başarılı ise
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Reklam çağırma işlemi başarısız ise
        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // reklam gösterilmeye başlandığında
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // reklam gösterilmesinde hata olduysa
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // reklam başarılı bir şekilde izlendiğinde.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Reklam erkenden kapatılırsa
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        AdRequest request = new AdRequest.Builder().Build();

        this.rewardedAd.LoadAd(request);
    }
    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        kontrol_metni.text = "reklam yüklendi";
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        kontrol_metni.text = "reklam yüklenemedi";
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        kontrol_metni.text = "reklam açık";
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        kontrol_metni.text = "reklam gösterilirken bir hata oluştu.";
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        kontrol_metni.text = "reklamı kapattın neden ? ";
        reklams.interactable = false;
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        playerScript.money = playerScript.money * 2;
        

    }
    public void UserChoseToWatchAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }
    void Update()
    {

    }
}

