using UnityEngine;

public class StarAnimation : MonoBehaviour
{
    private SpriteRenderer star;
    private float movementSpeed = 1.5f;
    
    void Start()
    {
        star = GetComponent<SpriteRenderer>();
        Destroy(gameObject, 5f);
    }
   
    void Update()
    {
        star.color = new Color(star.color.r, star.color.g, star.color.b, Mathf.PingPong(Time.time / 2.5f, 1f));
        transform.position += transform.up * Time.deltaTime * movementSpeed;
    }
}
