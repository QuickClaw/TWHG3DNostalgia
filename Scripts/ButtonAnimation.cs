using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAnimation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject MenuButton;

    public void OnPointerEnter(PointerEventData eventData)
    {
        MenuButton.GetComponent<Animator>().Play("Highlighted");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        MenuButton.GetComponent<Animator>().Play("Normal");
    }
}
