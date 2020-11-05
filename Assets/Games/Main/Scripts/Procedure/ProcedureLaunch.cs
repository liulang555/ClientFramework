using GameFramework.Event;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class ProcedureLaunch : ProcedureBase
{
    ProcedureOwner procedureOwner;
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        this.procedureOwner = procedureOwner;
        base.OnEnter(procedureOwner);
        GameData.GameType = "Main";
        GameEntry.Event.Subscribe(OpenUIFormSuccessEventArgs.EventId, OnOpenUIFormSuccess);

        // 初始化资源
        if (!GameEntry.Base.EditorResourceMode)
        {
            GameEntry.Resource.InitResources(InitResourcesCompleteCallback);
        }
        else
        {
            InitResourcesCompleteCallback();
        }
    }

    protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
    {
        GameEntry.Event.Unsubscribe(OpenUIFormSuccessEventArgs.EventId, OnOpenUIFormSuccess);
        base.OnLeave(procedureOwner, isShutdown);
    }

    private void InitResourcesCompleteCallback()
    {
        var loadedScenes = GameEntry.Scene.GetLoadedSceneAssetNames();
        for (int i = 0; i < loadedScenes.Length; i++)
        {
            GameEntry.Scene.UnloadScene(loadedScenes[i]);
        }
        GameEntry.UI.OpenUIForm(AssetUtility.GetUIFormAssetPath("LoadingForm", GameData.GameType), "Loading", this);
    }

    private void OnOpenUIFormSuccess(object sender, GameEventArgs e)
    {
        OpenUIFormSuccessEventArgs ne = (OpenUIFormSuccessEventArgs)e;
        if (ne.UserData != this)
        {
            return;
        }
        ChangeState<ProcedurePreload>(procedureOwner);
    }
}
