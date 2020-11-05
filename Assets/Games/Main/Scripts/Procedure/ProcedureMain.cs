using XLua;
using System;
using GameFramework;
using GameFramework.Event;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
public class ProcedureMain : ProcedureBase
{
    LuaTable luaTable;
    Action<object> luaOnInit;
    Action<float, float> luaOnUpdate;
    Action<bool> luaOnApplicationFocus;
    Action<bool> luaOnApplicationPause;
    ProcedureOwner procedureOwner;

    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        this.procedureOwner = procedureOwner;
        base.OnEnter(procedureOwner);
        GameEntry.Event.Subscribe(WebRequestSuccessEventArgs.EventId, OnWebRequestSuccess);
        GameEntry.Event.Subscribe(WebRequestFailureEventArgs.EventId, OnWebRequestFailure);
        // 后续多关卡（游戏）的时候，这里执行的Lua脚本要换成对应的关卡（游戏）名
        if (GameData.GameType == "Main")
        {
            GameEntry.UI.OpenUIForm(AssetUtility.GetUIFormAssetPath("SelectGameForm", GameData.GameType), "DefaultGroup", this);
            // GameData.GameType = "AntiVirus";
            // luaTable = GameEntry.Lua.DoLuaFile(AssetUtility.GetLuaAssetPath(GameData.GameType, GameData.GameType));
            // if (luaTable != null)
            // {
            //     luaOnInit = luaTable.Get<Action<object>>("OnInit");
            //     luaOnUpdate = luaTable.Get<Action<float, float>>("OnUpdate");
            //     luaOnApplicationPause = luaTable.Get<Action<bool>>("OnApplicationPause");
            //     luaOnApplicationFocus = luaTable.Get<Action<bool>>("OnApplicationFocus");
            //     luaOnInit?.Invoke(this);
            // }
        }
        else
        {
            luaTable = GameEntry.Lua.DoLuaFile(AssetUtility.GetLuaAssetPath(GameData.GameType, GameData.GameType));
            if (luaTable != null)
            {
                luaOnInit = luaTable.Get<Action<object>>("OnInit");
                luaOnUpdate = luaTable.Get<Action<float, float>>("OnUpdate");
                luaOnApplicationPause = luaTable.Get<Action<bool>>("OnApplicationPause");
                luaOnApplicationFocus = luaTable.Get<Action<bool>>("OnApplicationFocus");
                luaOnInit?.Invoke(this);
            }
        }
        // 获取框架网络组件
        // string url = "http://gameframework.cn/starforce/version.txt";
        // GameEntry.WebRequest.AddWebRequest(url, this);
    }
    private void OnAdsSuccess()
    {
        Log.Debug("OnAdsSuccess");
    }
    protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
    {
        GameEntry.Event.Unsubscribe(WebRequestSuccessEventArgs.EventId, OnWebRequestSuccess);
        GameEntry.Event.Unsubscribe(WebRequestFailureEventArgs.EventId, OnWebRequestFailure);
        if (luaTable != null)
        {
            luaOnInit = null;
            luaOnUpdate = null;
            luaTable.Dispose();
        }
        base.OnLeave(procedureOwner, isShutdown);
    }

    protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        luaOnUpdate?.Invoke(elapseSeconds, realElapseSeconds);

        if (GameData.IsChangeGameType)
        {
            GameData.IsChangeGameType = false;
            var uiGroup = GameEntry.UI.GetUIGroup("DefaultGroup");
            var allUIForms = uiGroup.GetAllUIForms();
            foreach (var item in allUIForms)
            {
                GameEntry.UI.CloseUIForm(item.SerialId);
            }
            ChangeState<ProcedurePreload>(procedureOwner);
        }
    }

    private void OnWebRequestSuccess(object sender, GameEventArgs e)
    {
        WebRequestSuccessEventArgs ne = (WebRequestSuccessEventArgs)e;
        // 获取回应的数据
        string responseJson = Utility.Converter.GetString(ne.GetWebResponseBytes());
        Log.Debug("responseJson：" + responseJson);
    }

    private void OnWebRequestFailure(object sender, GameEventArgs e)
    {
        Log.Warning("请求失败");
    }
}