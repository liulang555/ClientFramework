#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class GameFrameworkResourceLoadAssetCallbacksWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(GameFramework.Resource.LoadAssetCallbacks);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 4, 0);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadAssetSuccessCallback", _g_get_LoadAssetSuccessCallback);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadAssetFailureCallback", _g_get_LoadAssetFailureCallback);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadAssetUpdateCallback", _g_get_LoadAssetUpdateCallback);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadAssetDependencyAssetCallback", _g_get_LoadAssetDependencyAssetCallback);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2))
				{
					GameFramework.Resource.LoadAssetSuccessCallback _loadAssetSuccessCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2);
					
					GameFramework.Resource.LoadAssetCallbacks gen_ret = new GameFramework.Resource.LoadAssetCallbacks(_loadAssetSuccessCallback);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2) && translator.Assignable<GameFramework.Resource.LoadAssetFailureCallback>(L, 3))
				{
					GameFramework.Resource.LoadAssetSuccessCallback _loadAssetSuccessCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2);
					GameFramework.Resource.LoadAssetFailureCallback _loadAssetFailureCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetFailureCallback>(L, 3);
					
					GameFramework.Resource.LoadAssetCallbacks gen_ret = new GameFramework.Resource.LoadAssetCallbacks(_loadAssetSuccessCallback, _loadAssetFailureCallback);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2) && translator.Assignable<GameFramework.Resource.LoadAssetUpdateCallback>(L, 3))
				{
					GameFramework.Resource.LoadAssetSuccessCallback _loadAssetSuccessCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2);
					GameFramework.Resource.LoadAssetUpdateCallback _loadAssetUpdateCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetUpdateCallback>(L, 3);
					
					GameFramework.Resource.LoadAssetCallbacks gen_ret = new GameFramework.Resource.LoadAssetCallbacks(_loadAssetSuccessCallback, _loadAssetUpdateCallback);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2) && translator.Assignable<GameFramework.Resource.LoadAssetDependencyAssetCallback>(L, 3))
				{
					GameFramework.Resource.LoadAssetSuccessCallback _loadAssetSuccessCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2);
					GameFramework.Resource.LoadAssetDependencyAssetCallback _loadAssetDependencyAssetCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetDependencyAssetCallback>(L, 3);
					
					GameFramework.Resource.LoadAssetCallbacks gen_ret = new GameFramework.Resource.LoadAssetCallbacks(_loadAssetSuccessCallback, _loadAssetDependencyAssetCallback);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2) && translator.Assignable<GameFramework.Resource.LoadAssetFailureCallback>(L, 3) && translator.Assignable<GameFramework.Resource.LoadAssetUpdateCallback>(L, 4))
				{
					GameFramework.Resource.LoadAssetSuccessCallback _loadAssetSuccessCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2);
					GameFramework.Resource.LoadAssetFailureCallback _loadAssetFailureCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetFailureCallback>(L, 3);
					GameFramework.Resource.LoadAssetUpdateCallback _loadAssetUpdateCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetUpdateCallback>(L, 4);
					
					GameFramework.Resource.LoadAssetCallbacks gen_ret = new GameFramework.Resource.LoadAssetCallbacks(_loadAssetSuccessCallback, _loadAssetFailureCallback, _loadAssetUpdateCallback);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2) && translator.Assignable<GameFramework.Resource.LoadAssetFailureCallback>(L, 3) && translator.Assignable<GameFramework.Resource.LoadAssetDependencyAssetCallback>(L, 4))
				{
					GameFramework.Resource.LoadAssetSuccessCallback _loadAssetSuccessCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2);
					GameFramework.Resource.LoadAssetFailureCallback _loadAssetFailureCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetFailureCallback>(L, 3);
					GameFramework.Resource.LoadAssetDependencyAssetCallback _loadAssetDependencyAssetCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetDependencyAssetCallback>(L, 4);
					
					GameFramework.Resource.LoadAssetCallbacks gen_ret = new GameFramework.Resource.LoadAssetCallbacks(_loadAssetSuccessCallback, _loadAssetFailureCallback, _loadAssetDependencyAssetCallback);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && translator.Assignable<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2) && translator.Assignable<GameFramework.Resource.LoadAssetFailureCallback>(L, 3) && translator.Assignable<GameFramework.Resource.LoadAssetUpdateCallback>(L, 4) && translator.Assignable<GameFramework.Resource.LoadAssetDependencyAssetCallback>(L, 5))
				{
					GameFramework.Resource.LoadAssetSuccessCallback _loadAssetSuccessCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetSuccessCallback>(L, 2);
					GameFramework.Resource.LoadAssetFailureCallback _loadAssetFailureCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetFailureCallback>(L, 3);
					GameFramework.Resource.LoadAssetUpdateCallback _loadAssetUpdateCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetUpdateCallback>(L, 4);
					GameFramework.Resource.LoadAssetDependencyAssetCallback _loadAssetDependencyAssetCallback = translator.GetDelegate<GameFramework.Resource.LoadAssetDependencyAssetCallback>(L, 5);
					
					GameFramework.Resource.LoadAssetCallbacks gen_ret = new GameFramework.Resource.LoadAssetCallbacks(_loadAssetSuccessCallback, _loadAssetFailureCallback, _loadAssetUpdateCallback, _loadAssetDependencyAssetCallback);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Resource.LoadAssetCallbacks constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadAssetSuccessCallback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameFramework.Resource.LoadAssetCallbacks gen_to_be_invoked = (GameFramework.Resource.LoadAssetCallbacks)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.LoadAssetSuccessCallback);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadAssetFailureCallback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameFramework.Resource.LoadAssetCallbacks gen_to_be_invoked = (GameFramework.Resource.LoadAssetCallbacks)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.LoadAssetFailureCallback);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadAssetUpdateCallback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameFramework.Resource.LoadAssetCallbacks gen_to_be_invoked = (GameFramework.Resource.LoadAssetCallbacks)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.LoadAssetUpdateCallback);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadAssetDependencyAssetCallback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameFramework.Resource.LoadAssetCallbacks gen_to_be_invoked = (GameFramework.Resource.LoadAssetCallbacks)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.LoadAssetDependencyAssetCallback);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
