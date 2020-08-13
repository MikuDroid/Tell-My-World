using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour, IDragHandler, IEndDragHandler
{
    Vector2 pictureOnePos;
    public GameObject pictureTwo;
    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;

    void Start()
    {
        pictureOnePos = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        float distance = Vector3.Distance(transform.position, pictureTwo.transform.position);
        if (distance < 50)
        {
            transform.localScale = pictureTwo.transform.localScale;
            transform.position = pictureTwo.transform.position;
            source.clip = correct[UnityEngine.Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            source.clip = incorrect;
            source.Play();
            transform.position = pictureOnePos;
        }
    }
}