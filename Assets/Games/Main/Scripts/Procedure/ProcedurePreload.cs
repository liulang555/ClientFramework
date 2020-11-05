using GameFramework.Procedure;
using GameFramework.Resource;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class ProcedurePreload : ProcedureBase
{
    private Dictionary<string, bool> loadedFlag = new Dictionary<string, bool>();

    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);
        PreloadResources();
    }

    protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        foreach (var item in loadedFlag)
        {
            if (item.Value == false)
            {
                return;
            }
        }
        ChangeState<ProcedureChangeScene>(procedureOwner);
    }

    protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
    {
        if(GameData.GameType == "Main")
        {
            GameEntry.Lua.InitBase();
        }
        base.OnLeave(procedureOwner, isShutdown);
    }

    private void PreloadResources()
    {
        string path = AssetUtility.GetPreloadFileConfig(GameData.GameType);
        loadedFlag[path] = false;
        GameEntry.Resource.LoadAsset(
            path,
            new LoadAssetCallbacks(OnLoadFileConfigSuccess, OnLoadAssetFailure)
        );
    }

    private void OnLoadFileConfigSuccess(string assetName, object asset, float duration, object userData)
    {
        TextAsset textAsset = (TextAsset)asset;
        string[] fileList = textAsset.text.Split('\n');
        for (int i = 0; i < fileList.Length; i++)
        {
            string filePath = "Assets/Games/" + fileList[i].Trim();
            if (filePath != "Assets/Games/")
            {
                loadedFlag[filePath] = false;
                LoadAssetCallbacks callBacks = new LoadAssetCallbacks(OnLoadAssetSuccess, OnLoadAssetFailure);
                GameEntry.Resource.LoadAsset(filePath, callBacks);
            }
        }
        UpdateLoadedFlag(assetName);
    }

    private void OnLoadAssetFailure(string assetName, LoadResourceStatus status, string errorMessage, object userData)
    {
        Log.Error("Failure: " + errorMessage);
    }

    private void OnLoadAssetSuccess(string assetName, object asset, float duration, object userData)
    {
        if (assetName.EndsWith(".lua.txt"))
        {
            TextAsset textAsset = asset as TextAsset;
            GameEntry.Lua.LuaPathToTxtMap[assetName] = textAsset.bytes;
        }
        UpdateLoadedFlag(assetName);
    }

    private void UpdateLoadedFlag(string assetName)
    {
        loadedFlag[assetName] = true;
        float i = 0;
        foreach (var item in loadedFlag)
        {
            i = item.Value ? i + 1 : i;
        }
        float progressNum = i / loadedFlag.Count;
        DataEventArgs dataEventArgs = DataEventArgs.Create(this, LoadingForm.UpdateProgressEventId, LoadingStep.Preload, progressNum);
        GameEntry.Event.Fire(dataEventArgs.EventId, dataEventArgs);
    }
}