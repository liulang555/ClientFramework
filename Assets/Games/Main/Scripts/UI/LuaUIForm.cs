using XLua;
using System;

public class LuaUIForm : UGUIForm
{
    public string luaAssetName;
    public LuaTable luaTable;
    Action luaDestroy;
    Action<object> luaOnOpen;
    Action<bool, object> luaOnClose;
    Action<float, float> luaOnUpdate;

    protected override void OnInit(object userData)
    {
        base.OnInit(userData);

        Name = UIForm.SerialId + "|" + Name;
        luaAssetName = string.IsNullOrEmpty(luaAssetName) ?
        AssetUtility.GetLuaAssetPathForUIForm(UIForm.UIFormAssetName) :
        AssetUtility.GetLuaAssetPath("UIForms/" + luaAssetName, GameData.GameType);

        luaTable = GameEntry.Lua.DoLuaFile(luaAssetName);
        if (luaTable != null)
        {
            luaTable.Set("gameObject", gameObject);
            luaTable.Set("transform", transform);
            luaTable.Set("serialId", UIForm.SerialId);
            luaOnOpen = luaTable.Get<Action<object>>("OnOpen");
            luaOnClose = luaTable.Get<Action<bool, object>>("OnClose");
            luaOnUpdate = luaTable.Get<Action<float, float>>("OnUpdate");
            luaDestroy = luaTable.Get<Action>("OnDestroy");
            Action<object> luaOnInit = luaTable.Get<Action<object>>("OnInit");
            luaOnInit?.Invoke(userData);
        }
    }

    protected override void OnOpen(object userData)
    {
        base.OnOpen(userData);
        luaOnOpen?.Invoke(userData);
    }

    protected override void OnClose(bool isShutdown, object userData)
    {
        base.OnClose(isShutdown, userData);
        luaOnClose?.Invoke(isShutdown, userData);
        if (isShutdown && luaTable != null)
        {
            luaDestroy?.Invoke();
            luaOnOpen = null;
            luaOnClose = null;
            luaOnUpdate = null;
            luaDestroy = null;
            luaTable.Dispose();
        }
    }

    protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(elapseSeconds, realElapseSeconds);
        luaOnUpdate?.Invoke(elapseSeconds, realElapseSeconds);
    }
}