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
    public class UnityGameFrameworkRuntimeEventComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.EventComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Count", _m_Count);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Check", _m_Check);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Subscribe", _m_Subscribe);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Unsubscribe", _m_Unsubscribe);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDefaultHandler", _m_SetDefaultHandler);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Fire", _m_Fire);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FireNow", _m_FireNow);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "EventHandlerCount", _g_get_EventHandlerCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EventCount", _g_get_EventCount);
            
			
			
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
					
					UnityGameFramework.Runtime.EventComponent gen_ret = new UnityGameFramework.Runtime.EventComponent();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.EventComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Count(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EventComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EventComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _id = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = gen_to_be_invoked.Count( _id );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Check(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EventComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EventComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _id = LuaAPI.xlua_tointeger(L, 2);
                    System.EventHandler<GameFramework.Event.GameEventArgs> _handler = translator.GetDelegate<System.EventHandler<GameFramework.Event.GameEventArgs>>(L, 3);
                    
                        bool gen_ret = gen_to_be_invoked.Check( _id, _handler );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Subscribe(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EventComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EventComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _id = LuaAPI.xlua_tointeger(L, 2);
                    System.EventHandler<GameFramework.Event.GameEventArgs> _handler = translator.GetDelegate<System.EventHandler<GameFramework.Event.GameEventArgs>>(L, 3);
                    
                    gen_to_be_invoked.Subscribe( _id, _handler );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Unsubscribe(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EventComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EventComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _id = LuaAPI.xlua_tointeger(L, 2);
                    System.EventHandler<GameFramework.Event.GameEventArgs> _handler = translator.GetDelegate<System.EventHandler<GameFramework.Event.GameEventArgs>>(L, 3);
                    
                    gen_to_be_invoked.Unsubscribe( _id, _handler );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDefaultHandler(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EventComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EventComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.EventHandler<GameFramework.Event.GameEventArgs> _handler = translator.GetDelegate<System.EventHandler<GameFramework.Event.GameEventArgs>>(L, 2);
                    
                    gen_to_be_invoked.SetDefaultHandler( _handler );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Fire(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EventComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EventComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _sender = translator.GetObject(L, 2, typeof(object));
                    GameFramework.Event.GameEventArgs _e = (GameFramework.Event.GameEventArgs)translator.GetObject(L, 3, typeof(GameFramework.Event.GameEventArgs));
                    
                    gen_to_be_invoked.Fire( _sender, _e );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FireNow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.EventComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EventComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _sender = translator.GetObject(L, 2, typeof(object));
                    GameFramework.Event.GameEventArgs _e = (GameFramework.Event.GameEventArgs)translator.GetObject(L, 3, typeof(GameFramework.Event.GameEventArgs));
                    
                    gen_to_be_invoked.FireNow( _sender, _e );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EventHandlerCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.EventComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EventComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.EventHandlerCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EventCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.EventComponent gen_to_be_invoked = (UnityGameFramework.Runtime.EventComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.EventCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
