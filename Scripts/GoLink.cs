using UnityEngine;
using UnityEngine.EventSystems;

public class GoLink : MonoBehaviour, IPointerClickHandler
{
    public string URL;

    public void OnPointerClick(PointerEventData eventData)
    {
        Application.OpenURL(URL);
    }
}
