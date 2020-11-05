using XLua;
using System;
using System.Collections.Generic;
using UnityEngine;
using GameFramework.Resource;
using DG.Tweening.Core;
using DG.Tweening;
using UnityGameFramework.Runtime;
using UnityEngine.UI;
using TMPro;
using GameFramework.Sound;

public static class XLuaConfig
{
    [LuaCallCSharp]
    public static List<Type> LuaCallCSharp = new List<Type>() {
        // Unity
        typeof(Time),
        typeof(Vector2),
        typeof(Vector3),
        typeof(Component),
        typeof(Transform),
        typeof(RectTransform),
        typeof(GameObject),
        typeof(Animator),
        typeof(ParticleSystem),
        typeof(UnityEngine.Object),
        typeof(Rigidbody),
        typeof(ForceMode),
        typeof(BoxCollider),
        typeof(MeshCollider),

        typeof(SkinnedMeshRenderer),
        typeof(MeshRenderer),

        typeof(TextAsset),
        typeof(Sprite),
        typeof(Image),
        typeof(Button),
        typeof(Text),
        typeof(TextMeshProUGUI),

        typeof(Application),
        typeof(RuntimePlatform),
        typeof(Input),
        typeof(Camera),
        typeof(Screen),
        typeof(Canvas),
        typeof(GraphicRaycaster),
        typeof(System.DateTime),
        typeof(UnityEngine.ColorUtility),
        typeof(ReflectionProbe),

        // GameFramework
        typeof(GameEntry),
        typeof(UnityGameFramework.Runtime.GameEntry),
        typeof(ShutdownType),
        typeof(BaseComponent),
        typeof(UIComponent),
        typeof(EntityComponent),
        typeof(SoundComponent),
        typeof(ResourceComponent),
        typeof(FileSystemComponent),
        typeof(EventComponent),
        typeof(Log),
        typeof(LuaEntity),
        typeof(LuaUIForm),
        typeof(EventIds),
        typeof(GameData),
        typeof(Extentions),
        typeof(LoadAssetCallbacks),
        typeof(UnityGameFramework.Runtime.PlaySoundSuccessEventArgs),
        typeof(PlaySoundParams),
        typeof(DataEventArgs),

        // DOTween
        typeof(DOTween),
        typeof(PathType),
        typeof(PathMode),
        typeof(RotateMode),
        typeof(TweenExtensions),
        typeof(ShortcutExtensions),
        typeof(TweenSettingsExtensions),
        typeof(DOTweenModuleUI),
    };

    [CSharpCallLua]
    public static List<Type> CSharpCallLua = new List<Type>() {
        // C#
        typeof(Action<object>),
        typeof(Action<bool>),
        typeof(Action<int>),
        typeof(Action<bool, object>),
        typeof(Action<float, float>),
        typeof(Action<LuaTable,int>),
        // GameFramework
        typeof(LoadAssetSuccessCallback),
        typeof(LoadAssetFailureCallback),
        typeof(LoadAssetUpdateCallback),
        typeof(LoadAssetDependencyAssetCallback),

        // DOTween
        typeof(DOSetter<float>),
    };
    //黑名单
    [BlackList]
    public static List<List<string>> BlackList = new List<List<string>>()  {
        new List<string>(){"UnityEngine.Input", "IsJoystickPreconfigured", "System.String"},
        new List<string>(){"UnityEngine.UI.Text", "OnRebuildRequested"},
        new List<string>(){"UnityEngine.UI.Text", "OnRebuildRequested"},
        new List<string>(){"UnityEngine.Input", "location"},

        new List<string>(){"UnityEngine.MeshRenderer", "scaleInLightmap"},
        new List<string>(){"UnityEngine.MeshRenderer", "receiveGI"},
        new List<string>(){"UnityEngine.MeshRenderer", "stitchLightmapSeams"},
    };
}
