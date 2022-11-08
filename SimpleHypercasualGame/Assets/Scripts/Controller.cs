using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour
{
    public float moveX = 0;

    public RectTransform positioner;
    private float prevPosX = 0f;
    public GameObject knife;

    private void Start()
    {
        Vector3 knifePos = new Vector3(Random.Range(-2f, 2f), 1.56f, Random.Range(30f, 60f));
        Instantiate(knife, knifePos,Quaternion.Euler(0,90,0));
    }

    public void onControllerPressDown(BaseEventData _e)
    {
        PointerEventData _p = _e as PointerEventData;
        positioner.position = _p.position;
        prevPosX = positioner.anchoredPosition.x;
    }
    public void onControllerPressDrag(BaseEventData _e)
    {
        PointerEventData _p = _e as PointerEventData;
        positioner.position = _p.position;

        moveX = (positioner.anchoredPosition.x - prevPosX);
        prevPosX = positioner.anchoredPosition.x;

    }
    public void onControllerPressUp(BaseEventData _e)
    {
        PointerEventData _p = _e as PointerEventData;
        moveX = 0;
    }

    void FixedUpdate()
    {
        moveX = 0f;
    }
}
