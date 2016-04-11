using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VirtualJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{

    private Image bgImg;
    private Image joystickImg;
    private Vector3 inputvector;

    private void Start()
    {
        bgImg = GetComponent<Image>();
        joystickImg = transform.GetChild(0).GetComponent<Image>();

        Color c = bgImg.color;
        c.a = 0.5f;
        bgImg.color = c;
        joystickImg.color = c;
    }

    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImg.rectTransform
            , ped.position
            , ped.pressEventCamera
            , out pos))
        {
            //Click inside of the joystick
            pos.x = (pos.x / bgImg.rectTransform.sizeDelta.x);
            pos.y = (pos.y / bgImg.rectTransform.sizeDelta.y);

            inputvector = new Vector3(pos.x * 3 + 1, 0, pos.y * 3 - 1);
            inputvector = (inputvector.magnitude > 1.0f) ? inputvector.normalized : inputvector;

            //Move joystick image
            joystickImg.rectTransform.anchoredPosition = new Vector3(inputvector.x * (bgImg.rectTransform.sizeDelta.x / 3), inputvector.z * (bgImg.rectTransform.sizeDelta.y / 3));
        }
    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }

    public virtual void OnPointerUp(PointerEventData ped)
    {
        inputvector = Vector3.zero;
        joystickImg.rectTransform.anchoredPosition = Vector3.zero;
    }
    public float Horizontal()
    {
        if (inputvector.x != 0)
            return inputvector.x;
        else
            return Input.GetAxis("Horizontal");
    }
    public float Vertical()
    {
        if (inputvector.z != 0)
            return inputvector.z;
        else
            return Input.GetAxis("Vertical");
    }
}