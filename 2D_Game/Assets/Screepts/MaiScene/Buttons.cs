using UnityEngine;

public class Buttons : MonoBehaviour
{
    private void OnMouseDown()
    {
        transform.localScale = new Vector3(transform.localScale.x*1.1f, transform.localScale.y*1.1f, transform.position.z*1.1f);
        Debug.Log("The functionality of this button is planned to be added in the next updates.");
    }
    private void OnMouseUp()
    {
        transform.localScale = new Vector3(transform.localScale.x / 1.1f, transform.localScale.y / 1.1f, transform.position.z / 1.1f);
    }
}
