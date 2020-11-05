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
    public class UnityGameFrameworkRuntimeEntityComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.EntityComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 22, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasEntityGroup", _m_HasEntityGroup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEntityGroup", _m_GetEntityGroup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllEntityGroups", _m_GetAllEntityGroups);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddEntityGroup", _m_AddEntityGroup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasEntity", _m_HasEntity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEntity", _m_GetEntity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEntities", _m_GetEntities);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllLoadedEntities", _m_GetAllLoadedEntities);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllLoadingEntityIds", _m_GetAllLoadingEntityIds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsLoadingEntity", _m_IsLoadingEntity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsValidEntity", _m_IsValidEntity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ShowEntity", _m_ShowEntity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HideEntity", _m_HideEntity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HideAllLoadedEntities", _m_HideAllLoadedEntities);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HideAllLoadingEntities", _m_HideAllLoadingEntities);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetParentEntity", _m_GetParentEntity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetChildEntities", _m_GetChildEntities);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AttachEntity", _m_AttachEntity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DetachEntity", _m_DetachEntity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DetachChildEntities", _m_DetachChildEntities);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetEntityInstanceLocked", _m_SetEntityInstanceLocked);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInstancePriority", _m_SetInstancePriority);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "EntityCount", _g_get_EntityCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EntityGroupCount", _g_get_EntityGroupCount);
            
			
			
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
					
					UnityGameFramework.Runtime.EntityComponent gen_ret = new UnityGameFramework.Runtime.EntityComponent();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasEntityGroup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _entityGroupName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.HasEntityGroup( _entityGroupName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEntityGroup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _entityGroupName = LuaAPI.lua_tostring(L, 2);
                    
                        GameFramework.Entity.IEntityGroup gen_ret = gen_to_be_invoked.GetEntityGroup( _entityGroupName );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllEntityGroups(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        GameFramework.Entity.IEntityGroup[] gen_ret = gen_to_be_invoked.GetAllEntityGroups(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<GameFramework.Entity.IEntityGroup>>(L, 2)) 
                {
                    System.Collections.Generic.List<GameFramework.Entity.IEntityGroup> _results = (System.Collections.Generic.List<GameFramework.Entity.IEntityGroup>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<GameFramework.Entity.IEntityGroup>));
                    
                    gen_to_be_invoked.GetAllEntityGroups( _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.GetAllEntityGroups!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddEntityGroup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _entityGroupName = LuaAPI.lua_tostring(L, 2);
                    float _instanceAutoReleaseInterval = (float)LuaAPI.lua_tonumber(L, 3);
                    int _instanceCapacity = LuaAPI.xlua_tointeger(L, 4);
                    float _instanceExpireTime = (float)LuaAPI.lua_tonumber(L, 5);
                    int _instancePriority = LuaAPI.xlua_tointeger(L, 6);
                    
                        bool gen_ret = gen_to_be_invoked.AddEntityGroup( _entityGroupName, _instanceAutoReleaseInterval, _instanceCapacity, _instanceExpireTime, _instancePriority );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasEntity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _entityId = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.HasEntity( _entityId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _entityAssetName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.HasEntity( _entityAssetName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.HasEntity!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEntity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _entityId = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityGameFramework.Runtime.Entity gen_ret = gen_to_be_invoked.GetEntity( _entityId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _entityAssetName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityGameFramework.Runtime.Entity gen_ret = gen_to_be_invoked.GetEntity( _entityAssetName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.GetEntity!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEntities(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _entityAssetName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityGameFramework.Runtime.Entity[] gen_ret = gen_to_be_invoked.GetEntities( _entityAssetName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityGameFramework.Runtime.Entity>>(L, 3)) 
                {
                    string _entityAssetName = LuaAPI.lua_tostring(L, 2);
                    System.Collections.Generic.List<UnityGameFramework.Runtime.Entity> _results = (System.Collections.Generic.List<UnityGameFramework.Runtime.Entity>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityGameFramework.Runtime.Entity>));
                    
                    gen_to_be_invoked.GetEntities( _entityAssetName, _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.GetEntities!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllLoadedEntities(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        UnityGameFramework.Runtime.Entity[] gen_ret = gen_to_be_invoked.GetAllLoadedEntities(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<UnityGameFramework.Runtime.Entity>>(L, 2)) 
                {
                    System.Collections.Generic.List<UnityGameFramework.Runtime.Entity> _results = (System.Collections.Generic.List<UnityGameFramework.Runtime.Entity>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityGameFramework.Runtime.Entity>));
                    
                    gen_to_be_invoked.GetAllLoadedEntities( _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.GetAllLoadedEntities!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllLoadingEntityIds(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        int[] gen_ret = gen_to_be_invoked.GetAllLoadingEntityIds(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<int>>(L, 2)) 
                {
                    System.Collections.Generic.List<int> _results = (System.Collections.Generic.List<int>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<int>));
                    
                    gen_to_be_invoked.GetAllLoadingEntityIds( _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.GetAllLoadingEntityIds!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsLoadingEntity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _entityId = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.IsLoadingEntity( _entityId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsValidEntity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityGameFramework.Runtime.Entity _entity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    
                        bool gen_ret = gen_to_be_invoked.IsValidEntity( _entity );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShowEntity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Type>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TSTRING)) 
                {
                    int _entityId = LuaAPI.xlua_tointeger(L, 2);
                    System.Type _entityLogicType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    string _entityAssetName = LuaAPI.lua_tostring(L, 4);
                    string _entityGroupName = LuaAPI.lua_tostring(L, 5);
                    
                    gen_to_be_invoked.ShowEntity( _entityId, _entityLogicType, _entityAssetName, _entityGroupName );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Type>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    int _entityId = LuaAPI.xlua_tointeger(L, 2);
                    System.Type _entityLogicType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    string _entityAssetName = LuaAPI.lua_tostring(L, 4);
                    string _entityGroupName = LuaAPI.lua_tostring(L, 5);
                    int _priority = LuaAPI.xlua_tointeger(L, 6);
                    
                    gen_to_be_invoked.ShowEntity( _entityId, _entityLogicType, _entityAssetName, _entityGroupName, _priority );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Type>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 6)) 
                {
                    int _entityId = LuaAPI.xlua_tointeger(L, 2);
                    System.Type _entityLogicType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    string _entityAssetName = LuaAPI.lua_tostring(L, 4);
                    string _entityGroupName = LuaAPI.lua_tostring(L, 5);
                    object _userData = translator.GetObject(L, 6, typeof(object));
                    
                    gen_to_be_invoked.ShowEntity( _entityId, _entityLogicType, _entityAssetName, _entityGroupName, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Type>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<object>(L, 7)) 
                {
                    int _entityId = LuaAPI.xlua_tointeger(L, 2);
                    System.Type _entityLogicType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    string _entityAssetName = LuaAPI.lua_tostring(L, 4);
                    string _entityGroupName = LuaAPI.lua_tostring(L, 5);
                    int _priority = LuaAPI.xlua_tointeger(L, 6);
                    object _userData = translator.GetObject(L, 7, typeof(object));
                    
                    gen_to_be_invoked.ShowEntity( _entityId, _entityLogicType, _entityAssetName, _entityGroupName, _priority, _userData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.ShowEntity!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HideEntity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _entityId = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.HideEntity( _entityId );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)) 
                {
                    UnityGameFramework.Runtime.Entity _entity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    
                    gen_to_be_invoked.HideEntity( _entity );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    int _entityId = LuaAPI.xlua_tointeger(L, 2);
                    object _userData = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.HideEntity( _entityId, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    UnityGameFramework.Runtime.Entity _entity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    object _userData = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.HideEntity( _entity, _userData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.HideEntity!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HideAllLoadedEntities(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.HideAllLoadedEntities(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _userData = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.HideAllLoadedEntities( _userData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.HideAllLoadedEntities!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HideAllLoadingEntities(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.HideAllLoadingEntities(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetParentEntity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityGameFramework.Runtime.Entity gen_ret = gen_to_be_invoked.GetParentEntity( _childEntityId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    
                        UnityGameFramework.Runtime.Entity gen_ret = gen_to_be_invoked.GetParentEntity( _childEntity );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.GetParentEntity!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetChildEntities(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityGameFramework.Runtime.Entity[] gen_ret = gen_to_be_invoked.GetChildEntities( _parentEntityId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)) 
                {
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    
                        UnityGameFramework.Runtime.Entity[] gen_ret = gen_to_be_invoked.GetChildEntities( _parentEntity );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<GameFramework.Entity.IEntity>>(L, 3)) 
                {
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<GameFramework.Entity.IEntity> _results = (System.Collections.Generic.List<GameFramework.Entity.IEntity>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<GameFramework.Entity.IEntity>));
                    
                    gen_to_be_invoked.GetChildEntities( _parentEntityId, _results );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<GameFramework.Entity.IEntity>(L, 2)&& translator.Assignable<System.Collections.Generic.List<GameFramework.Entity.IEntity>>(L, 3)) 
                {
                    GameFramework.Entity.IEntity _parentEntity = (GameFramework.Entity.IEntity)translator.GetObject(L, 2, typeof(GameFramework.Entity.IEntity));
                    System.Collections.Generic.List<GameFramework.Entity.IEntity> _results = (System.Collections.Generic.List<GameFramework.Entity.IEntity>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<GameFramework.Entity.IEntity>));
                    
                    gen_to_be_invoked.GetChildEntities( _parentEntity, _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.GetChildEntities!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AttachEntity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.AttachEntity( _childEntityId, _parentEntityId );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 3)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 3, typeof(UnityGameFramework.Runtime.Entity));
                    
                    gen_to_be_invoked.AttachEntity( _childEntityId, _parentEntity );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.AttachEntity( _childEntity, _parentEntityId );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 3);
                    string _parentTransformPath = LuaAPI.lua_tostring(L, 4);
                    
                    gen_to_be_invoked.AttachEntity( _childEntityId, _parentEntityId, _parentTransformPath );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Transform>(L, 4)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Transform _parentTransform = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    
                    gen_to_be_invoked.AttachEntity( _childEntityId, _parentEntityId, _parentTransform );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 3);
                    object _userData = translator.GetObject(L, 4, typeof(object));
                    
                    gen_to_be_invoked.AttachEntity( _childEntityId, _parentEntityId, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 3)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 3, typeof(UnityGameFramework.Runtime.Entity));
                    
                    gen_to_be_invoked.AttachEntity( _childEntity, _parentEntity );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 3, typeof(UnityGameFramework.Runtime.Entity));
                    string _parentTransformPath = LuaAPI.lua_tostring(L, 4);
                    
                    gen_to_be_invoked.AttachEntity( _childEntityId, _parentEntity, _parentTransformPath );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 3);
                    string _parentTransformPath = LuaAPI.lua_tostring(L, 4);
                    
                    gen_to_be_invoked.AttachEntity( _childEntity, _parentEntityId, _parentTransformPath );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 3)&& translator.Assignable<UnityEngine.Transform>(L, 4)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 3, typeof(UnityGameFramework.Runtime.Entity));
                    UnityEngine.Transform _parentTransform = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    
                    gen_to_be_invoked.AttachEntity( _childEntityId, _parentEntity, _parentTransform );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Transform>(L, 4)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Transform _parentTransform = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    
                    gen_to_be_invoked.AttachEntity( _childEntity, _parentEntityId, _parentTransform );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 3, typeof(UnityGameFramework.Runtime.Entity));
                    object _userData = translator.GetObject(L, 4, typeof(object));
                    
                    gen_to_be_invoked.AttachEntity( _childEntityId, _parentEntity, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 3);
                    object _userData = translator.GetObject(L, 4, typeof(object));
                    
                    gen_to_be_invoked.AttachEntity( _childEntity, _parentEntityId, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 5)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 3);
                    string _parentTransformPath = LuaAPI.lua_tostring(L, 4);
                    object _userData = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.AttachEntity( _childEntityId, _parentEntityId, _parentTransformPath, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Transform _parentTransform = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    object _userData = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.AttachEntity( _childEntityId, _parentEntityId, _parentTransform, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 3, typeof(UnityGameFramework.Runtime.Entity));
                    string _parentTransformPath = LuaAPI.lua_tostring(L, 4);
                    
                    gen_to_be_invoked.AttachEntity( _childEntity, _parentEntity, _parentTransformPath );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 3)&& translator.Assignable<UnityEngine.Transform>(L, 4)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 3, typeof(UnityGameFramework.Runtime.Entity));
                    UnityEngine.Transform _parentTransform = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    
                    gen_to_be_invoked.AttachEntity( _childEntity, _parentEntity, _parentTransform );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 3, typeof(UnityGameFramework.Runtime.Entity));
                    object _userData = translator.GetObject(L, 4, typeof(object));
                    
                    gen_to_be_invoked.AttachEntity( _childEntity, _parentEntity, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 5)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 3, typeof(UnityGameFramework.Runtime.Entity));
                    string _parentTransformPath = LuaAPI.lua_tostring(L, 4);
                    object _userData = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.AttachEntity( _childEntityId, _parentEntity, _parentTransformPath, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 5)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 3);
                    string _parentTransformPath = LuaAPI.lua_tostring(L, 4);
                    object _userData = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.AttachEntity( _childEntity, _parentEntityId, _parentTransformPath, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 3)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 3, typeof(UnityGameFramework.Runtime.Entity));
                    UnityEngine.Transform _parentTransform = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    object _userData = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.AttachEntity( _childEntityId, _parentEntity, _parentTransform, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Transform _parentTransform = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    object _userData = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.AttachEntity( _childEntity, _parentEntityId, _parentTransform, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 5)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 3, typeof(UnityGameFramework.Runtime.Entity));
                    string _parentTransformPath = LuaAPI.lua_tostring(L, 4);
                    object _userData = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.AttachEntity( _childEntity, _parentEntity, _parentTransformPath, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 3)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 3, typeof(UnityGameFramework.Runtime.Entity));
                    UnityEngine.Transform _parentTransform = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    object _userData = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.AttachEntity( _childEntity, _parentEntity, _parentTransform, _userData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.AttachEntity!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DetachEntity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.DetachEntity( _childEntityId );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    
                    gen_to_be_invoked.DetachEntity( _childEntity );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    int _childEntityId = LuaAPI.xlua_tointeger(L, 2);
                    object _userData = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.DetachEntity( _childEntityId, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    UnityGameFramework.Runtime.Entity _childEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    object _userData = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.DetachEntity( _childEntity, _userData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.DetachEntity!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DetachChildEntities(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.DetachChildEntities( _parentEntityId );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)) 
                {
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    
                    gen_to_be_invoked.DetachChildEntities( _parentEntity );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    int _parentEntityId = LuaAPI.xlua_tointeger(L, 2);
                    object _userData = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.DetachChildEntities( _parentEntityId, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityGameFramework.Runtime.Entity>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    UnityGameFramework.Runtime.Entity _parentEntity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    object _userData = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.DetachChildEntities( _parentEntity, _userData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EntityComponent.DetachChildEntities!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetEntityInstanceLocked(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityGameFramework.Runtime.Entity _entity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    bool _locked = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.SetEntityInstanceLocked( _entity, _locked );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetInstancePriority(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityGameFramework.Runtime.Entity _entity = (UnityGameFramework.Runtime.Entity)translator.GetObject(L, 2, typeof(UnityGameFramework.Runtime.Entity));
                    int _priority = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetInstancePriority( _entity, _priority );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EntityCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.EntityCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EntityGroupCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.EntityComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EntityComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.EntityGroupCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
