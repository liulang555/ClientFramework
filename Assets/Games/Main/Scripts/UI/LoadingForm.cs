using XLua;
using System;
using UnityEngine.UI;
using GameFramework.Event;
using UnityGameFramework.Runtime;

public enum LoadingStep
{
    UpdateVersion = 1,
    Preload = 2,
    ChangeScene = 3,
}

public class LoadingForm : UGUIForm
{
    public static readonly int UpdateProgressEventId = typeof(LoadingForm).GetHashCode();
    public bool isLua;
    public string luaAssetName;
    public Image progressImg;
    LuaTable luaTable;
    Action<object> luaOnOpen;
    Action<bool, object> luaOnClose;
    Action<float, float> luaOnUpdate;
    float progressNum = 0;
    protected override void OnInit(object userData)
    {
        base.OnInit(userData);
        Name = UIForm.SerialId + "|" + Name;
        if (isLua)
        {
            luaAssetName = string.IsNullOrEmpty(luaAssetName) ?
            AssetUtility.GetLuaAssetPathForUIForm(UIForm.UIFormAssetName) :
            AssetUtility.GetLuaAssetPath("UIForms/" + luaAssetName, GameData.GameType);

            luaTable = GameEntry.Lua.DoLuaFile(luaAssetName);
            if (luaTable != null)
            {
                luaTable.Set("gameObject", gameObject);
                luaTable.Set("transform", transform);
                luaTable.Set("progressImg", progressImg);
                luaTable.Set("progressNum", progressNum);
                luaOnOpen = luaTable.Get<Action<object>>("OnOpen");
                luaOnClose = luaTable.Get<Action<bool, object>>("OnClose");
                luaOnUpdate = luaTable.Get<Action<float, float>>("OnUpdate");
                Action<object> luaOnInit = luaTable.Get<Action<object>>("OnInit");
                luaOnInit?.Invoke(userData);
            }
        }
    }

    protected override void OnOpen(object userData)
    {
        base.OnOpen(userData);
        GameEntry.Event.Subscribe(UpdateProgressEventId, OnUpdateProgress);
        if (isLua)
        {
            luaOnOpen?.Invoke(userData);
        }
        else
        {
            progressImg.fillAmount = 0;
        }
    }

    protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(elapseSeconds, realElapseSeconds);
        if (isLua)
        {
            luaOnUpdate?.Invoke(elapseSeconds, realElapseSeconds);
        }
        else
        {
            progressImg.fillAmount = progressNum;
        }
    }

    protected override void OnClose(bool isShutdown, object userData)
    {
        if (isLua && luaTable != null)
        {
            luaOnClose?.Invoke(isShutdown, userData);
            luaOnOpen = null;
            luaOnClose = null;
            luaOnUpdate = null;
            luaTable.Dispose();
        }
        GameEntry.Event.Unsubscribe(UpdateProgressEventId, OnUpdateProgress);
        base.OnClose(isShutdown, userData);
    }

    private void OnUpdateProgress(object sender, GameEventArgs e)
    {
        DataEventArgs ne = (DataEventArgs)e;
        LoadingStep stepId = (LoadingStep)ne.Param[0];
        float value = Convert.ToSingle(ne.Param[1]);
        switch (stepId)
        {
            case LoadingStep.UpdateVersion:
                progressNum = value * 0.3f;
                break;
            case LoadingStep.Preload:
                progressNum = value * 0.3f + 0.3f;
                break;
            case LoadingStep.ChangeScene:
                progressNum = value * 0.4f + 0.6f;
                break;
        }
        if (isLua)
        {
            luaTable.Set("progressNum", progressNum);
        }
        if (progressNum == 1)
        {
            this.Close();
        }
    }
}