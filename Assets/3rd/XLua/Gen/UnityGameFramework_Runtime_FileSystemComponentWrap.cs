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
    public class UnityGameFrameworkRuntimeFileSystemComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.FileSystemComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasFileSystem", _m_HasFileSystem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFileSystem", _m_GetFileSystem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateFileSystem", _m_CreateFileSystem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadFileSystem", _m_LoadFileSystem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DestroyFileSystem", _m_DestroyFileSystem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllFileSystems", _m_GetAllFileSystems);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Count", _g_get_Count);
            
			
			
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
					
					UnityGameFramework.Runtime.FileSystemComponent gen_ret = new UnityGameFramework.Runtime.FileSystemComponent();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.FileSystemComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasFileSystem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.FileSystemComponent gen_to_be_invoked = (UnityGameFramework.Runtime.FileSystemComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _fullPath = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.HasFileSystem( _fullPath );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFileSystem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.FileSystemComponent gen_to_be_invoked = (UnityGameFramework.Runtime.FileSystemComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _fullPath = LuaAPI.lua_tostring(L, 2);
                    
                        GameFramework.FileSystem.IFileSystem gen_ret = gen_to_be_invoked.GetFileSystem( _fullPath );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateFileSystem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.FileSystemComponent gen_to_be_invoked = (UnityGameFramework.Runtime.FileSystemComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _fullPath = LuaAPI.lua_tostring(L, 2);
                    GameFramework.FileSystem.FileSystemAccess _access;translator.Get(L, 3, out _access);
                    int _maxFileCount = LuaAPI.xlua_tointeger(L, 4);
                    int _maxBlockCount = LuaAPI.xlua_tointeger(L, 5);
                    
                        GameFramework.FileSystem.IFileSystem gen_ret = gen_to_be_invoked.CreateFileSystem( _fullPath, _access, _maxFileCount, _maxBlockCount );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFileSystem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.FileSystemComponent gen_to_be_invoked = (UnityGameFramework.Runtime.FileSystemComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _fullPath = LuaAPI.lua_tostring(L, 2);
                    GameFramework.FileSystem.FileSystemAccess _access;translator.Get(L, 3, out _access);
                    
                        GameFramework.FileSystem.IFileSystem gen_ret = gen_to_be_invoked.LoadFileSystem( _fullPath, _access );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DestroyFileSystem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.FileSystemComponent gen_to_be_invoked = (UnityGameFramework.Runtime.FileSystemComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.FileSystem.IFileSystem _fileSystem = (GameFramework.FileSystem.IFileSystem)translator.GetObject(L, 2, typeof(GameFramework.FileSystem.IFileSystem));
                    bool _deletePhysicalFile = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.DestroyFileSystem( _fileSystem, _deletePhysicalFile );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllFileSystems(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.FileSystemComponent gen_to_be_invoked = (UnityGameFramework.Runtime.FileSystemComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        GameFramework.FileSystem.IFileSystem[] gen_ret = gen_to_be_invoked.GetAllFileSystems(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<GameFramework.FileSystem.IFileSystem>>(L, 2)) 
                {
                    System.Collections.Generic.List<GameFramework.FileSystem.IFileSystem> _results = (System.Collections.Generic.List<GameFramework.FileSystem.IFileSystem>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<GameFramework.FileSystem.IFileSystem>));
                    
                    gen_to_be_invoked.GetAllFileSystems( _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.FileSystemComponent.GetAllFileSystems!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Count(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.FileSystemComponent gen_to_be_invoked = (UnityGameFramework.Runtime.FileSystemComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Count);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
