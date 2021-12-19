using UnityEngine;
using UnityEngine.UI;

public class ColissionCube : MonoBehaviour
{
    public GameObject reset;
    public Text youLose;
    public GameObject startPlatforme;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (transform.position.x > startPlatforme.transform.position.x + 5f)
        {
            youLose.gameObject.SetActive(true);
            Destroy(gameObject,1f);
            reset.gameObject.SetActive(true);
        }
    }
}
