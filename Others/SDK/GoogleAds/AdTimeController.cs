using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdTimeController : MonoBehaviour
{
    private static AdTimeController _instance;
    public static AdTimeController Instance
    {
        get { return _instance; }
    }


    //无广告时间
    private int noAdTime = 120;
    //长间隔期
    private int adSpaceTime = 720;
    //长间隔期间隔时间
    private int longAdSpaceTime = 180;
    //短间间隔间隔时间
    private int shortAdSpaceTime = 90;

    //游戏开始时间
    private float _startGameTime;

    //上次播放广告时间
    private float _lastAdTime;

    private void Awake()
    {
        _instance = this;
        _startGameTime = Time.time;
    }

    private void Start()
    {
#if UNITY_EDITOR
#else
        StartCoroutine(showBannerAd());
        
#endif
    }

    IEnumerator showBannerAd()
    {
        yield return new WaitForSeconds(2);
        GoogleAds.Instance.RequestBanner();
        yield return new WaitForSeconds(2);
        GoogleAds.Instance.RequestInterstitial();
        yield return new WaitForSeconds(2);
        GoogleAds.Instance.RequestRewardAd();

        //yield return new WaitForSeconds(noAdTime - 6);
        //GoogleAds.Instance.ShowBanner();
        InvokeRepeating("showBanner", 300, 300);
        yield return new WaitForSeconds(10);
    }

    private void showBanner()
    {
        GoogleAds.Instance.RequestBanner();
    }

    /// <summary>
    /// 显示全屏插页广告
    /// </summary>
    public void ShowFullVideoAd()
    {
        if (Time.time - _startGameTime >= noAdTime)
        {
            if (Time.time - _startGameTime < adSpaceTime)
            {
                if (Time.time - _lastAdTime >= longAdSpaceTime)
                {
#if UNITY_EDITOR
#else
                    GoogleAds.Instance.ShowInterstitial();
#endif
                    _lastAdTime = Time.time;
                }
            }
            else
            {

                if (Time.time - _lastAdTime >= shortAdSpaceTime)
                {
#if UNITY_EDITOR
#else
                    GoogleAds.Instance.ShowInterstitial();
#endif
                    _lastAdTime = Time.time;
                }
            }
        }
    }

    public void ShowRewardVideoAd(Action action)
    {
#if UNITY_EDITOR
#else
        GoogleAds.Instance.ShowRewardAd(1, action);
#endif
    }
}
