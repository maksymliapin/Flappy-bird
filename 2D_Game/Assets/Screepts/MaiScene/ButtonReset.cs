using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonReset : MonoBehaviour
{
    private void OnMouseDown()
    {
        transform.localScale = new Vector3(transform.localScale.x * 1.1f, transform.localScale.y * 1.1f, transform.position.z * 1.1f);
        SceneManager.LoadScene("SampleScene");
        TrigereScore.count = 0;
    }
    private void OnMouseUp()
    {
        transform.localScale = new Vector3(transform.localScale.x / 1.1f, transform.localScale.y / 1.1f, transform.position.z / 1.1f);
    }
}
