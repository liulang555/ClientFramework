using UnityEngine;
using UnityEngine.EventSystems;

public class UIEventListener : UnityEngine.EventSystems.EventTrigger
{
    public TriggerEvent onClick;
    public TriggerEvent onDown;
    public TriggerEvent onEnter;
    public TriggerEvent onExit;
    public TriggerEvent onUp;
    public TriggerEvent onSelect;
    public TriggerEvent onUpdateSelect;
    public TriggerEvent onDrag;
    public TriggerEvent onBeginDrag;
    public TriggerEvent onEndDrag;
    public TriggerEvent onDrop;

    private UIEventListener()
    {
        onClick = new TriggerEvent();
        onDown = new TriggerEvent();
        onEnter = new TriggerEvent();
        onExit = new TriggerEvent();
        onUp = new TriggerEvent();
        onSelect = new TriggerEvent();
        onUpdateSelect = new TriggerEvent();
        onDrag = new TriggerEvent();
        onBeginDrag = new TriggerEvent();
        onEndDrag = new TriggerEvent();
        onDrop = new TriggerEvent();
    }
    public static UIEventListener Get(GameObject go)
    {
        UIEventListener listener = go.GetComponent<UIEventListener>();
        if (listener == null) listener = go.AddComponent<UIEventListener>();
        return listener;
    }
    public override void OnPointerClick(PointerEventData eventData)
    {
        // Debug.Log("OnPointerClick called.");
        onClick?.Invoke(eventData);
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        // Debug.Log("OnPointerDown called.");
        onDown?.Invoke(eventData);
    }
    public override void OnPointerEnter(PointerEventData eventData)
    {
        // Debug.Log("OnPointerEnter called.");
        onEnter?.Invoke(eventData);
    }
    public override void OnPointerExit(PointerEventData eventData)
    {
        // Debug.Log("OnPointerExit called.");
        onExit?.Invoke(eventData);
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        // Debug.Log("OnPointerUp called.");
        onUp?.Invoke(eventData);
    }
    public override void OnSelect(BaseEventData eventData)
    {
        // Debug.Log("OnSelect called.");
        onSelect?.Invoke(eventData);
    }
    public override void OnUpdateSelected(BaseEventData eventData)
    {
        // Debug.Log("OnUpdateSelected called.");
        onUpdateSelect?.Invoke(eventData);
    }

    public override void OnDrag(PointerEventData eventData)
    {
        // Debug.Log("OnDrag called.");
        onDrag?.Invoke(eventData);
    }
    public override void OnBeginDrag(PointerEventData eventData)
    {
        // Debug.Log("OnBeginDrag called.");
        onBeginDrag?.Invoke(eventData);
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        // Debug.Log("OnEndDrag called.");
        onEndDrag?.Invoke(eventData);
    }
    public override void OnDrop(PointerEventData eventData)
    {
        // Debug.Log("OnDrop called.");
        onDrop?.Invoke(eventData);
    }
}