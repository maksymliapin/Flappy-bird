using UnityEngine;

public class ScrollObject : MonoBehaviour
{
    public float speed = 0.5f;
    public float checkPosition = 0f;
    private RectTransform rec;

    private void Start()
    {
        rec = GetComponent<RectTransform>();  
    }
    private void Update()
    {
        if (rec.offsetMin.y >= checkPosition)
        {
            rec.offsetMin += new Vector2(rec.offsetMin.x, speed);
            rec.offsetMax += new Vector2(rec.offsetMax.x, speed);
        }
    }
}
