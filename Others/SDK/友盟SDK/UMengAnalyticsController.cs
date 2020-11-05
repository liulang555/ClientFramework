using System.Collections;
using System.Collections.Generic;
using Umeng;
using UnityEngine;

public class UMengAnalyticsController : MonoBehaviour
{
    private static UMengAnalyticsController _instance;
    public static UMengAnalyticsController Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        _instance = this;
    }

    void Start()
    {
#if UNITY_EDITOR

#elif UNITY_ANDROID
        GA.StartWithAppKeyAndChannelId("5f96aecb45b2b751a91c2a2d", "umeng");
#elif UNITY_IOS
        GA.StartWithAppKeyAndChannelId("5f2d1ff3d30932215475f8d6", "ios");
#endif
    }

    public void StartLevel(int lv)
    {
#if UNITY_EDITOR

#else
        GA.StartLevel(lv.ToString());
#endif
    }

    public void CompletehLevel(int lv)
    {
#if UNITY_EDITOR
        
#else
        GA.Event("10002", lv.ToString());
#endif
    }

    public void FinishLevel(int lv)
    {
#if UNITY_EDITOR

#else
        GA.FinishLevel(lv.ToString());

#endif
    }

    public void FailLevel(int lv)
    {
#if UNITY_EDITOR

#else
        GA.FailLevel(lv.ToString());
#endif
    }

    public void Tip(int lv)
    {
#if UNITY_EDITOR

#else
        GA.Event("10003", lv.ToString());
#endif
    }

    public void OpenBox()
    {
#if UNITY_EDITOR

#else
        GA.Event("10021");
#endif
    }

    /// <summary>
    /// 获得金币
    /// </summary>
    /// <param name="type">0=未知途径，1=通关获得，2=视频激励获得，3=宝箱获得，4=购买获得</param>
    public void GetGold(int type)
    {
#if UNITY_EDITOR

#else
        GA.Event("10101", type.ToString());
#endif
    }

    /// <summary>
    /// 花费金币
    /// </summary>
    /// <param name="type">0=未知途径，1~100=解锁图鉴-图鉴编号</param>
    public void CostGold(int type)
    {
#if UNITY_EDITOR

#else
        GA.Event("10102", type.ToString());
#endif
    }

    public void UnlockScene(int index)
    {
#if UNITY_EDITOR

#else
        GA.Event("unlock_skin", index.ToString());
#endif
    }

    /// <summary>
    /// 广告拉取
    /// </summary>
    /// <param name="type">0=未知，11=横幅广告，21=插页广告，31=激励广告</param>
    public void PrepAd(int type)
    {
#if UNITY_EDITOR

#else
        GA.Event("1101", type.ToString());
#endif
    }

    /// <summary>
    /// 广告就绪
    /// </summary>
    /// <param name="type">0=未知，11=横幅广告，21=插页广告，31=激励广告</param>
    public void ReadyAd(int type)
    {
#if UNITY_EDITOR

#else
        GA.Event("1102", type.ToString());
#endif
    }

    /// <summary>
    /// 广告播放
    /// </summary>
    /// <param name="type">0=未知，11=横幅广告，21=插页广告，31=视频激励广告-跳关，32=视频激励广告-金币，33=视频激励广告-宝箱</param>
    public void PlayAd(int type)
    {
#if UNITY_EDITOR

#else
        GA.Event("1103", type.ToString());
#endif
    }

    /// <summary>
    /// 广告关闭
    /// </summary>
    /// <param name="type">0=未知，11=横幅广告，21=插页广告，31=视频激励广告-跳关，32=视频激励广告-金币，33=视频激励广告-宝箱</param>
    public void StopAd(int type)
    {
#if UNITY_EDITOR

#else
        GA.Event("1104", type.ToString());
#endif
    }
}
