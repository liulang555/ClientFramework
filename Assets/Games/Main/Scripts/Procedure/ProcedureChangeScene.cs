using GameFramework.Event;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class ProcedureChangeScene : ProcedureBase
{
    private bool isChangeSceneComplete = false;
    private int m_BackgroundMusicId = 0;
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);

        isChangeSceneComplete = false;

        GameEntry.Event.Subscribe(LoadSceneSuccessEventArgs.EventId, OnLoadSceneSuccess);
        GameEntry.Event.Subscribe(LoadSceneFailureEventArgs.EventId, OnLoadSceneFailure);
        GameEntry.Event.Subscribe(LoadSceneUpdateEventArgs.EventId, OnLoadSceneUpdate);
        GameEntry.Event.Subscribe(LoadSceneDependencyAssetEventArgs.EventId, OnLoadSceneDependencyAsset);

        // 停止所有声音
        GameEntry.Sound.StopAllLoadingSounds();
        GameEntry.Sound.StopAllLoadedSounds();

        // 隐藏所有实体
        GameEntry.Entity.HideAllLoadingEntities();
        GameEntry.Entity.HideAllLoadedEntities();

        // 卸载所有场景
        string[] loadedSceneAssetNames = GameEntry.Scene.GetLoadedSceneAssetNames();
        for (int i = 0; i < loadedSceneAssetNames.Length; i++)
        {
            GameEntry.Scene.UnloadScene(loadedSceneAssetNames[i]);
        }

        // 还原游戏速度
        GameEntry.Base.ResetNormalGameSpeed();

        GameEntry.Scene.LoadScene(AssetUtility.GetSceneAssetPath(GameData.GameType, GameData.GameType), this);
    }

    protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
    {
        GameEntry.Event.Unsubscribe(LoadSceneSuccessEventArgs.EventId, OnLoadSceneSuccess);
        GameEntry.Event.Unsubscribe(LoadSceneFailureEventArgs.EventId, OnLoadSceneFailure);
        GameEntry.Event.Unsubscribe(LoadSceneUpdateEventArgs.EventId, OnLoadSceneUpdate);
        GameEntry.Event.Unsubscribe(LoadSceneDependencyAssetEventArgs.EventId, OnLoadSceneDependencyAsset);
        DataEventArgs dataEventArgs = DataEventArgs.Create(this, LoadingForm.UpdateProgressEventId, LoadingStep.ChangeScene, 1);
        GameEntry.Event.Fire(dataEventArgs.EventId, dataEventArgs);
        base.OnLeave(procedureOwner, isShutdown);
    }

    protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

        if (!isChangeSceneComplete)
        {
            return;
        }
        ChangeState<ProcedureMain>(procedureOwner);
    }

    private void OnLoadSceneSuccess(object sender, GameEventArgs e)
    {
        LoadSceneSuccessEventArgs ne = (LoadSceneSuccessEventArgs)e;
        if (ne.UserData != this)
        {
            return;
        }

        Log.Info("Load scene '{0}' OK.", ne.SceneAssetName);

        if (m_BackgroundMusicId > 0)
        {
            // GameEntry.Sound.PlaySound(m_BackgroundMusicId);
        }

        isChangeSceneComplete = true;
    }

    private void OnLoadSceneFailure(object sender, GameEventArgs e)
    {
        LoadSceneFailureEventArgs ne = (LoadSceneFailureEventArgs)e;
        if (ne.UserData != this)
        {
            return;
        }

        Log.Error("Load scene '{0}' failure, error message '{1}'.", ne.SceneAssetName, ne.ErrorMessage);
    }

    private void OnLoadSceneUpdate(object sender, GameEventArgs e)
    {
        LoadSceneUpdateEventArgs ne = (LoadSceneUpdateEventArgs)e;
        if (ne.UserData != this)
        {
            return;
        }
        DataEventArgs dataEventArgs = DataEventArgs.Create(this, LoadingForm.UpdateProgressEventId, LoadingStep.ChangeScene, ne.Progress);
        GameEntry.Event.Fire(dataEventArgs.EventId, dataEventArgs);
        Log.Info("Load scene '{0}' update, progress '{1}'.", ne.SceneAssetName, ne.Progress.ToString("P2"));
    }

    private void OnLoadSceneDependencyAsset(object sender, GameEventArgs e)
    {
        LoadSceneDependencyAssetEventArgs ne = (LoadSceneDependencyAssetEventArgs)e;
        if (ne.UserData != this)
        {
            return;
        }

        Log.Info("Load scene '{0}' dependency asset '{1}', count '{2}/{3}'.", ne.SceneAssetName, ne.DependencyAssetName, ne.LoadedCount.ToString(), ne.TotalCount.ToString());
    }
}