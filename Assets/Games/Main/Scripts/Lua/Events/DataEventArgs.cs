using GameFramework;
using GameFramework.Event;

public class DataEventArgs : GameEventArgs
{
    public override int Id
    {
        get { return EventId; }
    }

    public int EventId
    {
        private set;
        get;
    }

    public object Sender
    {
        private set;
        get;
    }

    public object[] Param
    {
        private set;
        get;
    }

    public static DataEventArgs Create(object sender, int eventId, params object[] param)
    {
        DataEventArgs dataEventArgs = ReferencePool.Acquire<DataEventArgs>();
        dataEventArgs.Sender = sender;
        dataEventArgs.EventId = eventId;
        dataEventArgs.Param = param;
        return dataEventArgs;
    }

    /// <summary>
    /// 清理加载场景时加载依赖资源事件。
    /// </summary>
    public override void Clear()
    {
        EventId = 0;
        Sender = null;
        Param = null;
    }
}
