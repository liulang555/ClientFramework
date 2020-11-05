using XLua;
using UnityGameFramework.Runtime;
using UnityEngine;
using System;

public class LuaEntity : EntityLogic
{
    public string luaAssetName;
    LuaTable luaTable;
    Action luaDestroy;
    Action<object> luaOnShow;
    Action<LuaTable,int> luaAddToManager;
    Action<int> luaDeleteFromManager;
    Action<bool, object> luaOnHide;
    Action<EntityLogic, Transform, object> luaAttachTo;
    Action<EntityLogic, object> luaDetachFrom;
    Action<float, float> luaOnUpdate;

    protected override void OnInit(object userData)
    {
        base.OnInit(userData);

        Name = Entity.Id + "|" + Name;
        luaAssetName = string.IsNullOrEmpty(luaAssetName) ?
        AssetUtility.GetLuaAssetPathForEntity(Entity.EntityAssetName) :
        AssetUtility.GetLuaAssetPath("Entity/" + luaAssetName, GameData.GameType);

        luaTable = GameEntry.Lua.DoLuaFile(luaAssetName);
        if (luaTable != null)
        {
            luaAddToManager = luaTable.Get<Action<LuaTable,int>>("AddToManager");
            luaDeleteFromManager = luaTable.Get<Action<int>>("DeleteFromManager");
            luaAddToManager?.Invoke(luaTable,this.Entity.Id);
            luaTable.Set("gameObject", gameObject);
            luaTable.Set("transform", transform);
            luaTable.Set("entityId", this.Entity.Id);
            luaOnShow = luaTable.Get<Action<object>>("OnShow");
            luaOnHide = luaTable.Get<Action<bool, object>>("OnHide");
            luaAttachTo = luaTable.Get<Action<EntityLogic, Transform, object>>("OnAttachTo");
            luaDetachFrom = luaTable.Get<Action<EntityLogic, object>>("OnDetachFrom");
            luaOnUpdate = luaTable.Get<Action<float, float>>("OnUpdate");
            luaDestroy = luaTable.Get<Action>("OnDestroy");
            Action<object> luaOnInit = luaTable.Get<Action<object>>("OnInit");
            luaOnInit?.Invoke(userData);
        }
    }

    protected override void OnShow(object userData)
    {
        base.OnShow(userData);
        luaOnShow?.Invoke(userData);
    }

    protected override void OnHide(bool isShutdown, object userData)
    {
        base.OnHide(isShutdown, userData);
        luaOnHide?.Invoke(isShutdown, userData);
        if (isShutdown && luaTable != null)
        {
            luaDestroy?.Invoke();
            luaDeleteFromManager?.Invoke(this.Entity.Id);
            luaOnShow = null;
            luaOnHide = null;
            luaAttachTo = null;
            luaDetachFrom = null;
            luaOnUpdate = null;
            luaDestroy = null;
            luaTable.Dispose();
        }
    }

    protected override void OnAttachTo(EntityLogic parentEntity, Transform parentTransform, object userData)
    {
        base.OnAttachTo(parentEntity, parentTransform, userData);
        luaAttachTo?.Invoke(parentEntity, parentTransform, userData);
    }
    protected override void OnDetachFrom(EntityLogic parentEntity, object userData)
    {
        base.OnDetachFrom(parentEntity, userData);
        luaDetachFrom?.Invoke(parentEntity, userData);
    }

    protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(elapseSeconds, realElapseSeconds);
        luaOnUpdate?.Invoke(elapseSeconds, realElapseSeconds);
    }
}