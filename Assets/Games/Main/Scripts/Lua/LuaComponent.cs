using XLua;
using System;
using UnityEngine;
using UnityGameFramework.Runtime;
using System.Collections.Generic;

/// <summary>
/// Lua组件
/// </summary>
[DisallowMultipleComponent]
public class LuaComponent : GameFrameworkComponent
{
    /// <summary>
    /// 全局唯一Lua虚拟环境
    /// </summary>
    private LuaEnv luaEnv;
    public Dictionary<string, byte[]> LuaPathToTxtMap { get; set; }

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        LuaPathToTxtMap = new Dictionary<string, byte[]>();
        luaEnv = new LuaEnv();
        luaEnv.AddLoader((ref string luaName) =>
        {
            string luaPath = AssetUtility.GetLuaAssetPath(luaName, GameData.GameType);
            if (LuaPathToTxtMap.ContainsKey(luaPath))
            {
                return LuaPathToTxtMap[luaPath];
            }
            return null;
        });
    }

    private void Update()
    {
        if (luaEnv != null)
        {
            luaEnv.Tick();
        }
    }

    private void OnDestroy()
    {
        if (luaEnv != null)
        {
            // luaEnv.Dispose(); 开启这个注释，需要清空所有的lua委托，这个步骤执行起来太过繁琐。
            luaEnv = null;
        }
    }

    public void InitBase()
    {
        luaEnv.DoString("require 'Base/Base'");
    }

    /// <summary>
    /// 执行lua文件
    /// </summary>
    /// <param name="luaName"></param>
    /// <returns>lua table</returns>
    public LuaTable DoLuaFile(string luaName)
    {
        if (LuaPathToTxtMap.ContainsKey(luaName))
        {
            var luaChunck = LuaPathToTxtMap[luaName];
            object[] result = luaEnv.DoString(luaChunck, luaName);
            if (result == null || result.Length != 1 || !(result[0] is LuaTable))
            {
                Log.Info(string.Format("do lua file success, but not return table {0}", luaName));
            }
            else
            {
                return result[0] as LuaTable;
            }
        }
        else
        {
            Log.Info(string.Format("do lua file failed. The file is {0}. ", luaName));
        }
        return null;
    }

    /// <summary>
    /// 获取全局类的LuaTable
    /// </summary>
    public LuaTable GetLuaTable(string tableName)
    {
        LuaTable classLuaTable = luaEnv.Global.Get<LuaTable>(tableName);
        return classLuaTable;
    }

    /// <summary>
    /// 调用Lua方法
    /// </summary>
    /// <param name="funcName"></param>
    public void CallLuaFunction(LuaTable luaTable, string funcName, params object[] param)
    {
        if (luaTable != null)
        {
            try
            {
                LuaFunction luaFunction = luaTable.Get<LuaFunction>(funcName);
                if (luaFunction != null)
                {
                    luaFunction.Call(param);
                    luaFunction.Dispose();
                    luaFunction = null;
                }
            }
            catch (Exception exception)
            {
                Log.Error(exception.Message);
            }
        }
    }

    /// <summary>
    /// 调用Lua方法
    /// </summary>
    /// <param name="luaName"></param>
    /// <param name="className"></param>
    /// <param name="funcName"></param>
    /// <param name="parms"></param>
    public void CallLuaFunction(string className, string funcName, params object[] parms)
    {
        try
        {
            LuaTable classLuaTable = luaEnv.Global.Get<LuaTable>(className);
            LuaFunction luaFunc = classLuaTable.Get<LuaFunction>(funcName);
            luaFunc.Call(parms);
            classLuaTable.Dispose();
            luaFunc.Dispose();
            classLuaTable = null;
            luaFunc = null;
        }
        catch (Exception exception)
        {
            Log.Error(exception.Message);
        }
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        if (GameEntry.Event != null)
        {
            DataEventArgs dataEventArgs = DataEventArgs.Create(this, Convert.ToInt32(EventIds.ApplicationPause), pauseStatus);
            GameEntry.Event.FireNow(dataEventArgs.EventId, dataEventArgs);
        }
    }

    private void OnApplicationFocus(bool focusStatus)
    {
        if (GameEntry.Event != null)
        {
            DataEventArgs dataEventArgs = DataEventArgs.Create(this, Convert.ToInt32(EventIds.ApplicationFocus), focusStatus);
            GameEntry.Event.FireNow(dataEventArgs.EventId, dataEventArgs);
        }
    }

    private void OnApplicationQuit()
    {
        if (GameEntry.Event != null)
        {
            DataEventArgs dataEventArgs = DataEventArgs.Create(this, Convert.ToInt32(EventIds.ApplicationQuit));
            GameEntry.Event.FireNow(dataEventArgs.EventId, dataEventArgs);
        }
    }
}
