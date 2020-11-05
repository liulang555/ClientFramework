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
    public class UnityGameFrameworkRuntimeUIComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.UIComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 18, 5, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasUIGroup", _m_HasUIGroup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUIGroup", _m_GetUIGroup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllUIGroups", _m_GetAllUIGroups);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddUIGroup", _m_AddUIGroup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasUIForm", _m_HasUIForm);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUIForm", _m_GetUIForm);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUIForms", _m_GetUIForms);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllLoadedUIForms", _m_GetAllLoadedUIForms);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllLoadingUIFormSerialIds", _m_GetAllLoadingUIFormSerialIds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsLoadingUIForm", _m_IsLoadingUIForm);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsValidUIForm", _m_IsValidUIForm);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OpenUIForm", _m_OpenUIForm);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CloseUIForm", _m_CloseUIForm);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CloseAllLoadedUIForms", _m_CloseAllLoadedUIForms);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CloseAllLoadingUIForms", _m_CloseAllLoadingUIForms);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RefocusUIForm", _m_RefocusUIForm);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetUIFormInstanceLocked", _m_SetUIFormInstanceLocked);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetUIFormInstancePriority", _m_SetUIFormInstancePriority);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "UIGroupCount", _g_get_UIGroupCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "InstanceAutoReleaseInterval", _g_get_InstanceAutoReleaseInterval);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "InstanceCapacity", _g_get_InstanceCapacity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "InstanceExpireTime", _g_get_InstanceExpireTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "InstancePriority", _g_get_InstancePriority);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "InstanceAutoReleaseInterval", _s_set_InstanceAutoReleaseInterval);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "InstanceCapacity", _s_set_InstanceCapacity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "InstanceExpireTime", _s_set_InstanceExpireTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "InstancePriority", _s_set_InstancePriority);
            
			
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
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityGameFramework.Runtime.UIComponent gen_ret = new UnityGameFramework.Runtime.UIComponent();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.UIComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasUIGroup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _uiGroupName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.HasUIGroup( _uiGroupName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUIGroup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _uiGroupName = LuaAPI.lua_tostring(L, 2);
                    
                        GameFramework.UI.IUIGroup gen_ret = gen_to_be_invoked.GetUIGroup( _uiGroupName );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllUIGroups(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        GameFramework.UI.IUIGroup[] gen_ret = gen_to_be_invoked.GetAllUIGroups(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<GameFramework.UI.IUIGroup>>(L, 2)) 
                {
                    System.Collections.Generic.List<GameFramework.UI.IUIGroup> _results = (System.Collections.Generic.List<GameFramework.UI.IUIGroup>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<GameFramework.UI.IUIGroup>));
                    
                    gen_to_be_invoked.GetAllUIGroups( _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.UIComponent.GetAllUIGroups!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddUIGroup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _uiGroupName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.AddUIGroup( _uiGroupName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _uiGroupName = LuaAPI.lua_tostring(L, 2);
                    int _depth = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool gen_ret = gen_to_be_invoked.AddUIGroup( _uiGroupName, _depth );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.UIComponent.AddUIGroup!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasUIForm(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _serialId = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.HasUIForm( _serialId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _uiFormAssetName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.HasUIForm( _uiFormAssetName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.UIComponent.HasUIForm!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUIForm(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _serialId = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityGameFramework.Runtime.UIForm gen_ret = gen_to_be_invoked.GetUIForm( _serialId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _uiFormAssetName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityGameFramework.Runtime.UIForm gen_ret = gen_to_be_invoked.GetUIForm( _uiFormAssetName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.UIComponent.GetUIForm!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUIForms(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _uiFormAssetName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityGameFramework.Runtime.UIForm[] gen_ret = gen_to_be_invoked.GetUIForms( _uiFormAssetName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityGameFramework.Runtime.UIForm>>(L, 3)) 
                {
                    string _uiFormAssetName = LuaAPI.lua_tostring(L, 2);
                    System.Collections.Generic.List<UnityGameFramework.Runtime.UIForm> _results = (System.Collections.Generic.List<UnityGameFramework.Runtime.UIForm>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityGameFramework.Runtime.UIForm>));
                    
                    gen_to_be_invoked.GetUIForms( _uiFormAssetName, _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.UIComponent.GetUIForms!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllLoadedUIForms(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        UnityGameFramework.Runtime.UIForm[] gen_ret = gen_to_be_invoked.GetAllLoadedUIForms(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<UnityGameFramework.Runtime.UIForm>>(L, 2)) 
                {
                    System.Collections.Generic.List<UnityGameFramework.Runtime.UIForm> _results = (System.Collections.Generic.List<UnityGameFramework.Runtime.UIForm>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityGameFramework.Runtime.UIForm>));
                    
                    gen_to_be_invoked.GetAllLoadedUIForms( _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.UIComponent.GetAllLoadedUIForms!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllLoadingUIFormSerialIds(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        int[] gen_ret = gen_to_be_invoked.GetAllLoadingUIFormSerialIds(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<int>>(L, 2)) 
                {
                    System.Collections.Generic.List<int> _results = (System.Collections.Generic.List<int>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<int>));
                    
                    gen_to_be_invoked.GetAllLoadingUIFormSerialIds( _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.UIComponent.GetAllLoadingUIFormSerialIds!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsLoadingUIForm(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _serialId = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.IsLoadingUIForm( _serialId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _uiFormAssetName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.IsLoadingUIForm( _uiFormAssetName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.UIComponent.IsLoadingUIForm!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsValidUIForm(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityGameFramework.Runtime.UIForm _uiForm = (UnityGameFramework.Runtime.UIForm)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.UIForm));
                    
                        bool gen_ret = gen_to_be_invoked.IsValidUIForm( _uiForm );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OpenUIForm(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    string _uiFormAssetName = LuaAPI.lua_tostring(L, 2);
                    string _uiGroupName = LuaAPI.lua_tostring(L, 3);
                    
                        int gen_ret = gen_to_be_invoked.OpenUIForm( _uiFormAssetName, _uiGroupName );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _uiFormAssetName = LuaAPI.lua_tostring(L, 2);
                    string _uiGroupName = LuaAPI.lua_tostring(L, 3);
                    int _priority = LuaAPI.xlua_tointeger(L, 4);
                    
                        int gen_ret = gen_to_be_invoked.OpenUIForm( _uiFormAssetName, _uiGroupName, _priority );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    string _uiFormAssetName = LuaAPI.lua_tostring(L, 2);
                    string _uiGroupName = LuaAPI.lua_tostring(L, 3);
                    bool _pauseCoveredUIForm = LuaAPI.lua_toboolean(L, 4);
                    
                        int gen_ret = gen_to_be_invoked.OpenUIForm( _uiFormAssetName, _uiGroupName, _pauseCoveredUIForm );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    string _uiFormAssetName = LuaAPI.lua_tostring(L, 2);
                    string _uiGroupName = LuaAPI.lua_tostring(L, 3);
                    int _priority = LuaAPI.xlua_tointeger(L, 4);
                    bool _pauseCoveredUIForm = LuaAPI.lua_toboolean(L, 5);
                    
                        int gen_ret = gen_to_be_invoked.OpenUIForm( _uiFormAssetName, _uiGroupName, _priority, _pauseCoveredUIForm );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 4)) 
                {
                    string _uiFormAssetName = LuaAPI.lua_tostring(L, 2);
                    string _uiGroupName = LuaAPI.lua_tostring(L, 3);
                    object _userData = translator.GetObject(L, 4, typeof(object));
                    
                        int gen_ret = gen_to_be_invoked.OpenUIForm( _uiFormAssetName, _uiGroupName, _userData );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string _uiFormAssetName = LuaAPI.lua_tostring(L, 2);
                    string _uiGroupName = LuaAPI.lua_tostring(L, 3);
                    int _priority = LuaAPI.xlua_tointeger(L, 4);
                    object _userData = translator.GetObject(L, 5, typeof(object));
                    
                        int gen_ret = gen_to_be_invoked.OpenUIForm( _uiFormAssetName, _uiGroupName, _priority, _userData );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string _uiFormAssetName = LuaAPI.lua_tostring(L, 2);
                    string _uiGroupName = LuaAPI.lua_tostring(L, 3);
                    bool _pauseCoveredUIForm = LuaAPI.lua_toboolean(L, 4);
                    object _userData = translator.GetObject(L, 5, typeof(object));
                    
                        int gen_ret = gen_to_be_invoked.OpenUIForm( _uiFormAssetName, _uiGroupName, _pauseCoveredUIForm, _userData );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& translator.Assignable<object>(L, 6)) 
                {
                    string _uiFormAssetName = LuaAPI.lua_tostring(L, 2);
                    string _uiGroupName = LuaAPI.lua_tostring(L, 3);
                    int _priority = LuaAPI.xlua_tointeger(L, 4);
                    bool _pauseCoveredUIForm = LuaAPI.lua_toboolean(L, 5);
                    object _userData = translator.GetObject(L, 6, typeof(object));
                    
                        int gen_ret = gen_to_be_invoked.OpenUIForm( _uiFormAssetName, _uiGroupName, _priority, _pauseCoveredUIForm, _userData );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.UIComponent.OpenUIForm!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CloseUIForm(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _serialId = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.CloseUIForm( _serialId );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityGameFramework.Runtime.UIForm>(L, 2)) 
                {
                    UnityGameFramework.Runtime.UIForm _uiForm = (UnityGameFramework.Runtime.UIForm)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.UIForm));
                    
                    gen_to_be_invoked.CloseUIForm( _uiForm );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    int _serialId = LuaAPI.xlua_tointeger(L, 2);
                    object _userData = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.CloseUIForm( _serialId, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityGameFramework.Runtime.UIForm>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    UnityGameFramework.Runtime.UIForm _uiForm = (UnityGameFramework.Runtime.UIForm)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.UIForm));
                    object _userData = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.CloseUIForm( _uiForm, _userData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.UIComponent.CloseUIForm!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CloseAllLoadedUIForms(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.CloseAllLoadedUIForms(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _userData = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.CloseAllLoadedUIForms( _userData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.UIComponent.CloseAllLoadedUIForms!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CloseAllLoadingUIForms(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.CloseAllLoadingUIForms(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RefocusUIForm(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityGameFramework.Runtime.UIForm>(L, 2)) 
                {
                    UnityGameFramework.Runtime.UIForm _uiForm = (UnityGameFramework.Runtime.UIForm)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.UIForm));
                    
                    gen_to_be_invoked.RefocusUIForm( _uiForm );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityGameFramework.Runtime.UIForm>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    UnityGameFramework.Runtime.UIForm _uiForm = (UnityGameFramework.Runtime.UIForm)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.UIForm));
                    object _userData = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.RefocusUIForm( _uiForm, _userData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.UIComponent.RefocusUIForm!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetUIFormInstanceLocked(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityGameFramework.Runtime.UIForm _uiForm = (UnityGameFramework.Runtime.UIForm)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.UIForm));
                    bool _locked = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.SetUIFormInstanceLocked( _uiForm, _locked );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetUIFormInstancePriority(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityGameFramework.Runtime.UIForm _uiForm = (UnityGameFramework.Runtime.UIForm)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.UIForm));
                    int _priority = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetUIFormInstancePriority( _uiForm, _priority );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UIGroupCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.UIGroupCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_InstanceAutoReleaseInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.InstanceAutoReleaseInterval);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_InstanceCapacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.InstanceCapacity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_InstanceExpireTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.InstanceExpireTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_InstancePriority(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.InstancePriority);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_InstanceAutoReleaseInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.InstanceAutoReleaseInterval = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_InstanceCapacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.InstanceCapacity = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_InstanceExpireTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.InstanceExpireTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_InstancePriority(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.UIComponent gen_to_be_invoked = (UnityGameFramework.Runtime.UIComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.InstancePriority = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
