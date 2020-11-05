using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.UI;
using System;
// using juyou_star;


public class GoogleAds : MonoBehaviour
{
    private static GoogleAds _instance;
    public static GoogleAds Instance
    {
        get
        {
            return _instance;
        }
    }

    //获取奖励后的回调
    private Action rewardAction;
    private int rewardAdType;

    private BannerView bannerView;
    private InterstitialAd interstitial;
    private RewardedAd rewardedAd;

    private string BannerId = "ca-app-pub-6562789771066579/6148297768";   //正式：ca-app-pub-6562789771066579/1294968513           测试："ca-app-pub-3940256099942544/6300978111"
    //插页
    private string InterstitialAd = "ca-app-pub-6562789771066579/5956726072";  //正式：ca-app-pub-6562789771066579/7285661796      测试： "ca-app-pub-3940256099942544/1033173712"
    //激励
    private string RewardId = "ca-app-pub-6562789771066579/7078236052";    //正式：ca-app-pub-6562789771066579/5781008431           测试："ca-app-pub-3940256099942544/5224354917"


    private string BannerId_IOS = "ca-app-pub-6562789771066579/2755847660";   //ca-app-pub-6562789771066579/7069382835
    private string InterstitialAd_IOS = "ca-app-pub-6562789771066579/2477140904";  //ca-app-pub-6562789771066579/5564729476
    private string RewardId_IOS = "ca-app-pub-6562789771066579/5190439315";   //ca-app-pub-6562789771066579/1625484461


    private void Awake()
    {
        _instance = this;
    }

    public void Start()
    {
#if UNITY_EDITOR
        //return;
#endif

#if UNITY_ANDROID
        string appId = "ca-app-pub-6562789771066579~3561662870";                //ca-app-pub-6562789771066579~7313581957
#elif UNITY_IOS
        string appId = "ca-app-pub-6562789771066579~2443505408";
#else
        string appId = "ca-app-pub-3940256099942544~3347511713";
#endif

        MobileAds.Initialize(appId);
    }

    //1-跳关  2-金币  3-宝箱
    public void ShowRewardAd(int adType, Action action)
    {
        rewardAction = action;
        rewardAdType = adType;

        Debug.Log("yyy: + 播放视频奖励广告 this.rewardedAd: "+(this.rewardedAd == null));
        if (this.rewardedAd != null && this.rewardedAd.IsLoaded())
        {
            Debug.Log("yyy: + 播放视频奖励广告:播放");
            this.rewardedAd.Show();
            RequestRewardAd();
        }
        else
        {
            Debug.Log("yyy: + 播放视频奖励广告：请求");
            RequestRewardAd();
        }
    }

    //视频奖励广告
    public void RequestRewardAd()
    {
        Debug.Log("yyy加载Reward");
        string adUnitId;
#if UNITY_ANDROID
        adUnitId = RewardId;
#elif UNITY_IOS
        adUnitId = RewardId_IOS;
#else
            adUnitId = "unexpected_platform";
#endif
        if (this.rewardedAd == null || !this.rewardedAd.IsLoaded())
        {
            Debug.Log("yyy: + 获取视频奖励广告");
            UMengAnalyticsController.Instance.PrepAd(31);
            this.rewardedAd = new RewardedAd(adUnitId);

            AdRequest request = new AdRequest.Builder().Build();

            this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
            this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;
            this.rewardedAd.OnAdLoaded += onRewardAdLoaded;
            this.rewardedAd.OnAdOpening += onRewardShow;
            this.rewardedAd.OnAdFailedToLoad += onRewardAdLoadedFiled;
            this.rewardedAd.LoadAd(request);
        }
    }

    private void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        RequestRewardAd();
        if (rewardAdType == 1)
        {
            UMengAnalyticsController.Instance.StopAd(31);
        }
        else if (rewardAdType == 2)
        {
            UMengAnalyticsController.Instance.StopAd(32);
        }
        else if (rewardAdType == 3)
        {
            UMengAnalyticsController.Instance.StopAd(33);
        }
    }

    private void onRewardAdLoaded(object sender, EventArgs args)
    {
        Debug.Log("yyy: + 获取视频奖励广告成功");
        UMengAnalyticsController.Instance.ReadyAd(31);
    }

    private void onRewardAdLoadedFiled(object sender, EventArgs args)
    {
        Debug.Log("yyy: + 获取视频奖励广告失败");
    }

    private void HandleUserEarnedReward(object sender, Reward args)
    {
        Debug.Log("yyy: + 获取视频奖励的奖励");
        rewardAction?.Invoke();
    }


    private void onRewardShow(object sender, EventArgs args)
    {
        if (rewardAdType == 1)
        {
            UMengAnalyticsController.Instance.PlayAd(31);
        }
        else if (rewardAdType == 2)
        {
            UMengAnalyticsController.Instance.PlayAd(32);
        }
        else if (rewardAdType == 3)
        {
            UMengAnalyticsController.Instance.PlayAd(33);
        }
    }

    public void ShowInterstitial()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
            RequestInterstitial();
        }
        else
        {
            RequestInterstitial();
        }
    }

    //插页广告
    public void RequestInterstitial()
    {
        Debug.Log("yyy加载fullscreen");
#if UNITY_ANDROID
        string adUnitId = InterstitialAd;           //正式ca-app-pub-6562789771066579/2649399554
#elif UNITY_IOS
        string adUnitId = InterstitialAd_IOS;
#else
        string adUnitId = "unexpected_platform";
#endif


        if (this.interstitial == null || !this.interstitial.IsLoaded())
        {
            Debug.Log("yyy: + 获取插页广告");
            UMengAnalyticsController.Instance.PrepAd(21);
            this.interstitial = new InterstitialAd(adUnitId);

            AdRequest request = new AdRequest.Builder().Build();

            this.interstitial.OnAdClosed += HandleOnAdClosed;
            this.interstitial.OnAdLoaded += onInterstitialAdLoaded;
            this.interstitial.OnAdOpening += onInterstitialAdShow;
            this.interstitial.OnAdFailedToLoad += onInterstitialAdLoadedFiled;
            this.interstitial.LoadAd(request);
        }
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        Debug.Log("yyy: + 插页广告关闭");
        UMengAnalyticsController.Instance.StopAd(21);
        RequestInterstitial();
    }

    private void onInterstitialAdLoaded(object sender, EventArgs args)
    {
        Debug.Log("yyy: + 获取插页广告成功");
        UMengAnalyticsController.Instance.ReadyAd(21);
    }

    private void onInterstitialAdLoadedFiled(object sender, EventArgs args)
    {
        Debug.Log("yyy: + 获取插页广告失败");
    }

    private void onInterstitialAdShow(object sender, EventArgs args)
    {
        UMengAnalyticsController.Instance.PlayAd(21);
    }

    public void ShowBanner()
    {
        //this.bannerView.Show();
        RequestBanner();
    }

    //横幅广告
    public void RequestBanner()
    {
        Debug.Log("yyy加载Banner");
#if UNITY_ANDROID
        string adUnitId = BannerId;            //正式ca-app-pub-6562789771066579/4154052916
#elif UNITY_IOS
        string adUnitId = BannerId_IOS;
#else
        string adUnitId = "ca-app-pub-3940256099942544/6300978111";
#endif


        UMengAnalyticsController.Instance.PrepAd(11);
        AdSize adaptiveSize =
                AdSize.GetPortraitAnchoredAdaptiveBannerAdSizeWithWidth(AdSize.FullWidth);
        this.bannerView = new BannerView(adUnitId, adaptiveSize, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();

        this.bannerView.OnAdLoaded += onBannerLoaded;
        this.bannerView.OnAdFailedToLoad += onIBannerAdLoadedFiled;
        bannerView.LoadAd(request);

    }

    private void onBannerLoaded(object sender, EventArgs args)
    {
        Debug.Log("yyy: + Banner广告成功");
        this.bannerView.Show();
        UMengAnalyticsController.Instance.ReadyAd(11);
    }

    private void onIBannerAdLoadedFiled(object sender, EventArgs args)
    {
        Debug.Log("yyy: + 获取Banner失败");
    }

    public void OnDestroy()
    {
        if (this.rewardedAd != null)
        {
            this.rewardedAd = null;
        }
        if (this.interstitial != null)
        {
            this.interstitial.Destroy();
            this.interstitial = null;
        }
        if (this.bannerView != null)
        {
            this.bannerView.Destroy();
            this.bannerView = null;
        }
    }
}


