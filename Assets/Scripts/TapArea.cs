using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    public AudioSource tapSound;
    public void OnPointerDown (PointerEventData eventData)
    {
        tapSound.PlayOneShot(tapSound.clip);
        GameManager.Instance.CollectByTap (eventData.position, transform);
    }
}