using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Door : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] UnityEvent doorOpenEvent;

    [SerializeField] float radius = 0.5f;

    GameObject player;
    IDOTweenInit doTween;

    bool doorUsed = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        doTween = DOTween.Init(true, true);
    }

    void Update()
    {
        if (doorUsed && Vector2.Distance(transform.position, player.transform.position) < radius)
        {
            doorUsed = false;
            DOTween.Kill(doTween);
            doorOpenEvent.Invoke();
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        doorUsed = true;
        player.transform.DOMoveX(transform.position.x, 4);
    }

    /*void OnPointerEnter(PointerEventData pointerEventData)
    {
        //doorOpenEvent = null;
    }

    void OnPointerExit(PointerEventData pointerEventData)
    {
        //doorOpenEvent = null;
    }*/
}
