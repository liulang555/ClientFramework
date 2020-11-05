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
    public class UnityGameFrameworkRuntimeResourceComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.ResourceComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 23, 37, 12);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetResourceMode", _m_SetResourceMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCurrentVariant", _m_SetCurrentVariant);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDecryptResourceCallback", _m_SetDecryptResourceCallback);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnloadUnusedAssets", _m_UnloadUnusedAssets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ForceUnloadUnusedAssets", _m_ForceUnloadUnusedAssets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InitResources", _m_InitResources);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CheckVersionList", _m_CheckVersionList);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateVersionList", _m_UpdateVersionList);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CheckResources", _m_CheckResources);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyResources", _m_ApplyResources);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateResources", _m_UpdateResources);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "VerifyResourcePack", _m_VerifyResourcePack);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasAsset", _m_HasAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAsset", _m_LoadAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnloadAsset", _m_UnloadAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBinaryPath", _m_GetBinaryPath);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBinaryLength", _m_GetBinaryLength);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadBinary", _m_LoadBinary);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadBinaryFromFileSystem", _m_LoadBinaryFromFileSystem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadBinarySegmentFromFileSystem", _m_LoadBinarySegmentFromFileSystem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasResourceGroup", _m_HasResourceGroup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetResourceGroup", _m_GetResourceGroup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllLoadAssetInfos", _m_GetAllLoadAssetInfos);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ReadOnlyPath", _g_get_ReadOnlyPath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ReadWritePath", _g_get_ReadWritePath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourceMode", _g_get_ResourceMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ReadWritePathType", _g_get_ReadWritePathType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CurrentVariant", _g_get_CurrentVariant);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "PackageVersionListSerializer", _g_get_PackageVersionListSerializer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdatableVersionListSerializer", _g_get_UpdatableVersionListSerializer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ReadOnlyVersionListSerializer", _g_get_ReadOnlyVersionListSerializer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ReadWriteVersionListSerializer", _g_get_ReadWriteVersionListSerializer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourcePackVersionListSerializer", _g_get_ResourcePackVersionListSerializer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UnloadUnusedAssetsInterval", _g_get_UnloadUnusedAssetsInterval);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ApplicableGameVersion", _g_get_ApplicableGameVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "InternalResourceVersion", _g_get_InternalResourceVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetCount", _g_get_AssetCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourceCount", _g_get_ResourceCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourceGroupCount", _g_get_ResourceGroupCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdatePrefixUri", _g_get_UpdatePrefixUri);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "GenerateReadWriteVersionListLength", _g_get_GenerateReadWriteVersionListLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ApplyingResourcePackPath", _g_get_ApplyingResourcePackPath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ApplyWaitingCount", _g_get_ApplyWaitingCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdateRetryCount", _g_get_UpdateRetryCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdatingResourceGroup", _g_get_UpdatingResourceGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdateWaitingCount", _g_get_UpdateWaitingCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdateCandidateCount", _g_get_UpdateCandidateCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdatingCount", _g_get_UpdatingCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadTotalAgentCount", _g_get_LoadTotalAgentCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadFreeAgentCount", _g_get_LoadFreeAgentCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadWorkingAgentCount", _g_get_LoadWorkingAgentCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadWaitingTaskCount", _g_get_LoadWaitingTaskCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetAutoReleaseInterval", _g_get_AssetAutoReleaseInterval);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetCapacity", _g_get_AssetCapacity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetExpireTime", _g_get_AssetExpireTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetPriority", _g_get_AssetPriority);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourceAutoReleaseInterval", _g_get_ResourceAutoReleaseInterval);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourceCapacity", _g_get_ResourceCapacity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourceExpireTime", _g_get_ResourceExpireTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourcePriority", _g_get_ResourcePriority);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "UnloadUnusedAssetsInterval", _s_set_UnloadUnusedAssetsInterval);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "UpdatePrefixUri", _s_set_UpdatePrefixUri);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "GenerateReadWriteVersionListLength", _s_set_GenerateReadWriteVersionListLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "UpdateRetryCount", _s_set_UpdateRetryCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AssetAutoReleaseInterval", _s_set_AssetAutoReleaseInterval);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AssetCapacity", _s_set_AssetCapacity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AssetExpireTime", _s_set_AssetExpireTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AssetPriority", _s_set_AssetPriority);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ResourceAutoReleaseInterval", _s_set_ResourceAutoReleaseInterval);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ResourceCapacity", _s_set_ResourceCapacity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ResourceExpireTime", _s_set_ResourceExpireTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ResourcePriority", _s_set_ResourcePriority);
            
			
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
					
					UnityGameFramework.Runtime.ResourceComponent gen_ret = new UnityGameFramework.Runtime.ResourceComponent();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ResourceComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetResourceMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Resource.ResourceMode _resourceMode;translator.Get(L, 2, out _resourceMode);
                    
                    gen_to_be_invoked.SetResourceMode( _resourceMode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCurrentVariant(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _currentVariant = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SetCurrentVariant( _currentVariant );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDecryptResourceCallback(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Resource.DecryptResourceCallback _decryptResourceCallback = translator.GetDelegate<GameFramework.Resource.DecryptResourceCallback>(L, 2);
                    
                    gen_to_be_invoked.SetDecryptResourceCallback( _decryptResourceCallback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnloadUnusedAssets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _performGCCollect = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.UnloadUnusedAssets( _performGCCollect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForceUnloadUnusedAssets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _performGCCollect = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.ForceUnloadUnusedAssets( _performGCCollect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitResources(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Resource.InitResourcesCompleteCallback _initResourcesCompleteCallback = translator.GetDelegate<GameFramework.Resource.InitResourcesCompleteCallback>(L, 2);
                    
                    gen_to_be_invoked.InitResources( _initResourcesCompleteCallback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckVersionList(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _latestInternalResourceVersion = LuaAPI.xlua_tointeger(L, 2);
                    
                        GameFramework.Resource.CheckVersionListResult gen_ret = gen_to_be_invoked.CheckVersionList( _latestInternalResourceVersion );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateVersionList(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _versionListLength = LuaAPI.xlua_tointeger(L, 2);
                    int _versionListHashCode = LuaAPI.xlua_tointeger(L, 3);
                    int _versionListZipLength = LuaAPI.xlua_tointeger(L, 4);
                    int _versionListZipHashCode = LuaAPI.xlua_tointeger(L, 5);
                    GameFramework.Resource.UpdateVersionListCallbacks _updateVersionListCallbacks = (GameFramework.Resource.UpdateVersionListCallbacks)translator.GetObject(L, 6, typeof(GameFramework.Resource.UpdateVersionListCallbacks));
                    
                    gen_to_be_invoked.UpdateVersionList( _versionListLength, _versionListHashCode, _versionListZipLength, _versionListZipHashCode, _updateVersionListCallbacks );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckResources(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<GameFramework.Resource.CheckResourcesCompleteCallback>(L, 2)) 
                {
                    GameFramework.Resource.CheckResourcesCompleteCallback _checkResourcesCompleteCallback = translator.GetDelegate<GameFramework.Resource.CheckResourcesCompleteCallback>(L, 2);
                    
                    gen_to_be_invoked.CheckResources( _checkResourcesCompleteCallback );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& translator.Assignable<GameFramework.Resource.CheckResourcesCompleteCallback>(L, 3)) 
                {
                    bool _ignoreOtherVariant = LuaAPI.lua_toboolean(L, 2);
                    GameFramework.Resource.CheckResourcesCompleteCallback _checkResourcesCompleteCallback = translator.GetDelegate<GameFramework.Resource.CheckResourcesCompleteCallback>(L, 3);
                    
                    gen_to_be_invoked.CheckResources( _ignoreOtherVariant, _checkResourcesCompleteCallback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ResourceComponent.CheckResources!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyResources(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _resourcePackPath = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Resource.ApplyResourcesCompleteCallback _applyResourcesCompleteCallback = translator.GetDelegate<GameFramework.Resource.ApplyResourcesCompleteCallback>(L, 3);
                    
                    gen_to_be_invoked.ApplyResources( _resourcePackPath, _applyResourcesCompleteCallback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateResources(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<GameFramework.Resource.UpdateResourcesCompleteCallback>(L, 2)) 
                {
                    GameFramework.Resource.UpdateResourcesCompleteCallback _updateResourcesCompleteCallback = translator.GetDelegate<GameFramework.Resource.UpdateResourcesCompleteCallback>(L, 2);
                    
                    gen_to_be_invoked.UpdateResources( _updateResourcesCompleteCallback );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.Resource.UpdateResourcesCompleteCallback>(L, 3)) 
                {
                    string _resourceGroupName = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Resource.UpdateResourcesCompleteCallback _updateResourcesCompleteCallback = translator.GetDelegate<GameFramework.Resource.UpdateResourcesCompleteCallback>(L, 3);
                    
                    gen_to_be_invoked.UpdateResources( _resourceGroupName, _updateResourcesCompleteCallback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ResourceComponent.UpdateResources!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_VerifyResourcePack(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _resourcePackPath = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.VerifyResourcePack( _resourcePackPath );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 2);
                    
                        GameFramework.Resource.HasAssetResult gen_ret = gen_to_be_invoked.HasAsset( _assetName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 3)) 
                {
                    string _assetName = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Resource.LoadAssetCallbacks _loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 3, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    
                    gen_to_be_invoked.LoadAsset( _assetName, _loadAssetCallbacks );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 4)) 
                {
                    string _assetName = LuaAPI.lua_tostring(L, 2);
                    int _priority = LuaAPI.xlua_tointeger(L, 3);
                    GameFramework.Resource.LoadAssetCallbacks _loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 4, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    
                    gen_to_be_invoked.LoadAsset( _assetName, _priority, _loadAssetCallbacks );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 4)) 
                {
                    string _assetName = LuaAPI.lua_tostring(L, 2);
                    System.Type _assetType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    GameFramework.Resource.LoadAssetCallbacks _loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 4, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    
                    gen_to_be_invoked.LoadAsset( _assetName, _assetType, _loadAssetCallbacks );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    string _assetName = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Resource.LoadAssetCallbacks _loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 3, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    object _userData = translator.GetObject(L, 4, typeof(object));
                    
                    gen_to_be_invoked.LoadAsset( _assetName, _loadAssetCallbacks, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 5)) 
                {
                    string _assetName = LuaAPI.lua_tostring(L, 2);
                    System.Type _assetType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    int _priority = LuaAPI.xlua_tointeger(L, 4);
                    GameFramework.Resource.LoadAssetCallbacks _loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 5, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    
                    gen_to_be_invoked.LoadAsset( _assetName, _assetType, _priority, _loadAssetCallbacks );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string _assetName = LuaAPI.lua_tostring(L, 2);
                    int _priority = LuaAPI.xlua_tointeger(L, 3);
                    GameFramework.Resource.LoadAssetCallbacks _loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 4, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    object _userData = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.LoadAsset( _assetName, _priority, _loadAssetCallbacks, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string _assetName = LuaAPI.lua_tostring(L, 2);
                    System.Type _assetType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    GameFramework.Resource.LoadAssetCallbacks _loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 4, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    object _userData = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.LoadAsset( _assetName, _assetType, _loadAssetCallbacks, _userData );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 5)&& translator.Assignable<object>(L, 6)) 
                {
                    string _assetName = LuaAPI.lua_tostring(L, 2);
                    System.Type _assetType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    int _priority = LuaAPI.xlua_tointeger(L, 4);
                    GameFramework.Resource.LoadAssetCallbacks _loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 5, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    object _userData = translator.GetObject(L, 6, typeof(object));
                    
                    gen_to_be_invoked.LoadAsset( _assetName, _assetType, _priority, _loadAssetCallbacks, _userData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ResourceComponent.LoadAsset!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnloadAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _asset = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.UnloadAsset( _asset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBinaryPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = gen_to_be_invoked.GetBinaryPath( _binaryAssetName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    bool _storageInReadOnly;
                    bool _storageInFileSystem;
                    string _relativePath;
                    string _fileName;
                    
                        bool gen_ret = gen_to_be_invoked.GetBinaryPath( _binaryAssetName, out _storageInReadOnly, out _storageInFileSystem, out _relativePath, out _fileName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushboolean(L, _storageInReadOnly);
                        
                    LuaAPI.lua_pushboolean(L, _storageInFileSystem);
                        
                    LuaAPI.lua_pushstring(L, _relativePath);
                        
                    LuaAPI.lua_pushstring(L, _fileName);
                        
                    
                    
                    
                    return 5;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ResourceComponent.GetBinaryPath!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBinaryLength(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    
                        int gen_ret = gen_to_be_invoked.GetBinaryLength( _binaryAssetName );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadBinary(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.Resource.LoadBinaryCallbacks>(L, 3)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Resource.LoadBinaryCallbacks _loadBinaryCallbacks = (GameFramework.Resource.LoadBinaryCallbacks)translator.GetObject(L, 3, typeof(GameFramework.Resource.LoadBinaryCallbacks));
                    
                    gen_to_be_invoked.LoadBinary( _binaryAssetName, _loadBinaryCallbacks );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.Resource.LoadBinaryCallbacks>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Resource.LoadBinaryCallbacks _loadBinaryCallbacks = (GameFramework.Resource.LoadBinaryCallbacks)translator.GetObject(L, 3, typeof(GameFramework.Resource.LoadBinaryCallbacks));
                    object _userData = translator.GetObject(L, 4, typeof(object));
                    
                    gen_to_be_invoked.LoadBinary( _binaryAssetName, _loadBinaryCallbacks, _userData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ResourceComponent.LoadBinary!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadBinaryFromFileSystem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    
                        byte[] gen_ret = gen_to_be_invoked.LoadBinaryFromFileSystem( _binaryAssetName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 3);
                    
                        int gen_ret = gen_to_be_invoked.LoadBinaryFromFileSystem( _binaryAssetName, _buffer );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 3);
                    int _startIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                        int gen_ret = gen_to_be_invoked.LoadBinaryFromFileSystem( _binaryAssetName, _buffer, _startIndex );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 3);
                    int _startIndex = LuaAPI.xlua_tointeger(L, 4);
                    int _length = LuaAPI.xlua_tointeger(L, 5);
                    
                        int gen_ret = gen_to_be_invoked.LoadBinaryFromFileSystem( _binaryAssetName, _buffer, _startIndex, _length );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ResourceComponent.LoadBinaryFromFileSystem!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadBinarySegmentFromFileSystem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    int _length = LuaAPI.xlua_tointeger(L, 3);
                    
                        byte[] gen_ret = gen_to_be_invoked.LoadBinarySegmentFromFileSystem( _binaryAssetName, _length );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _length = LuaAPI.xlua_tointeger(L, 4);
                    
                        byte[] gen_ret = gen_to_be_invoked.LoadBinarySegmentFromFileSystem( _binaryAssetName, _offset, _length );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 3);
                    int _length = LuaAPI.xlua_tointeger(L, 4);
                    
                        int gen_ret = gen_to_be_invoked.LoadBinarySegmentFromFileSystem( _binaryAssetName, _buffer, _length );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 3);
                    int _startIndex = LuaAPI.xlua_tointeger(L, 4);
                    int _length = LuaAPI.xlua_tointeger(L, 5);
                    
                        int gen_ret = gen_to_be_invoked.LoadBinarySegmentFromFileSystem( _binaryAssetName, _buffer, _startIndex, _length );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 4);
                    int _length = LuaAPI.xlua_tointeger(L, 5);
                    
                        int gen_ret = gen_to_be_invoked.LoadBinarySegmentFromFileSystem( _binaryAssetName, _offset, _buffer, _length );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    string _binaryAssetName = LuaAPI.lua_tostring(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 4);
                    int _startIndex = LuaAPI.xlua_tointeger(L, 5);
                    int _length = LuaAPI.xlua_tointeger(L, 6);
                    
                        int gen_ret = gen_to_be_invoked.LoadBinarySegmentFromFileSystem( _binaryAssetName, _offset, _buffer, _startIndex, _length );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ResourceComponent.LoadBinarySegmentFromFileSystem!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasResourceGroup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _resourceGroupName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.HasResourceGroup( _resourceGroupName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetResourceGroup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        GameFramework.Resource.IResourceGroup gen_ret = gen_to_be_invoked.GetResourceGroup(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _resourceGroupName = LuaAPI.lua_tostring(L, 2);
                    
                        GameFramework.Resource.IResourceGroup gen_ret = gen_to_be_invoked.GetResourceGroup( _resourceGroupName );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ResourceComponent.GetResourceGroup!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllLoadAssetInfos(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        GameFramework.TaskInfo[] gen_ret = gen_to_be_invoked.GetAllLoadAssetInfos(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ReadOnlyPath(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.ReadOnlyPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ReadWritePath(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.ReadWritePath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourceMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ResourceMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ReadWritePathType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ReadWritePathType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CurrentVariant(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.CurrentVariant);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PackageVersionListSerializer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.PackageVersionListSerializer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdatableVersionListSerializer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.UpdatableVersionListSerializer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ReadOnlyVersionListSerializer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ReadOnlyVersionListSerializer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ReadWriteVersionListSerializer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ReadWriteVersionListSerializer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourcePackVersionListSerializer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ResourcePackVersionListSerializer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UnloadUnusedAssetsInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.UnloadUnusedAssetsInterval);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ApplicableGameVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.ApplicableGameVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_InternalResourceVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.InternalResourceVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.AssetCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourceCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ResourceCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourceGroupCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ResourceGroupCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdatePrefixUri(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.UpdatePrefixUri);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GenerateReadWriteVersionListLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.GenerateReadWriteVersionListLength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ApplyingResourcePackPath(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.ApplyingResourcePackPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ApplyWaitingCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ApplyWaitingCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdateRetryCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.UpdateRetryCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdatingResourceGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.UpdatingResourceGroup);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdateWaitingCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.UpdateWaitingCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdateCandidateCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.UpdateCandidateCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdatingCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.UpdatingCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadTotalAgentCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.LoadTotalAgentCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadFreeAgentCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.LoadFreeAgentCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadWorkingAgentCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.LoadWorkingAgentCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadWaitingTaskCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.LoadWaitingTaskCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetAutoReleaseInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.AssetAutoReleaseInterval);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetCapacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.AssetCapacity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetExpireTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.AssetExpireTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetPriority(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.AssetPriority);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourceAutoReleaseInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.ResourceAutoReleaseInterval);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourceCapacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ResourceCapacity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourceExpireTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.ResourceExpireTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourcePriority(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ResourcePriority);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UnloadUnusedAssetsInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.UnloadUnusedAssetsInterval = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UpdatePrefixUri(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.UpdatePrefixUri = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_GenerateReadWriteVersionListLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.GenerateReadWriteVersionListLength = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UpdateRetryCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.UpdateRetryCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AssetAutoReleaseInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AssetAutoReleaseInterval = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AssetCapacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AssetCapacity = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AssetExpireTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AssetExpireTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AssetPriority(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AssetPriority = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ResourceAutoReleaseInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ResourceAutoReleaseInterval = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ResourceCapacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ResourceCapacity = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ResourceExpireTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ResourceExpireTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ResourcePriority(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ResourcePriority = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
