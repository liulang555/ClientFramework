// Entity 需要的Unity事件触发器，主要用于透传给Lua层调用
using UnityEngine;
using UnityEngine.Events;

public class EntityEventListener : MonoBehaviour
{
    public class EntityEvent : UnityEvent<Collider>{}
    public EntityEvent onTriggerEnter;
    private void Awake()
    {
        onTriggerEnter = new EntityEvent();
    }

    public static EntityEventListener Get(GameObject go)
    {
        EntityEventListener listener = go.GetComponent<EntityEventListener>();
        if (listener == null) listener = go.AddComponent<EntityEventListener>();
        return listener;
    }
    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnter?.Invoke(other);
    }
}
