using System.Collections;
using UnityEngine;

public class GenerationSta : MonoBehaviour
{
    public GameObject star;

    void Start()
    {
        StartCoroutine(Genration());
    }
    IEnumerator Genration()
    {
        while (true)
        {
            var position = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane / 2f));
            Instantiate(star, position, Quaternion.Euler(0,0,Random.Range(0f,360)));
            yield return new WaitForSeconds(1.0f);
        }
    }
}
