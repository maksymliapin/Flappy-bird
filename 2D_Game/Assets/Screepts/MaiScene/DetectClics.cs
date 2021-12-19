using UnityEngine;
using UnityEngine.UI;

public class DetectClics : MonoBehaviour
{
    public Text playTxt;
    public GameObject platform;
    public GameObject otherPlatform;
    public Text gameName;
    public float speed = 8;
    public GameObject buttons, cube;
    public bool clicked;
    private Vector3 startPosition = new Vector3(-2.8f, 1.8f, -1.5f);
    private void OnMouseDown()
    {
        if (clicked == false)
        {
            clicked = true;
            playTxt.gameObject.SetActive(false);
            buttons.gameObject.SetActive(false);
            cube.GetComponent<Animation>().Play("StartGame");
            Instantiate(platform, startPosition, Quaternion.identity);
            for (int i = 0; i < 200; i++)
            {
                Instantiate(otherPlatform, new Vector3(startPosition.x + (i + 1) * speed, Random.Range(11, 7), startPosition.z), Quaternion.identity);
            }
            cube.AddComponent<Rigidbody>();
            cube.GetComponent<Rigidbody>().freezeRotation = true;
        }
    }
    private void FixedUpdate()
    {
        if (clicked == true)
        {
            gameName.text =$"Score: {TrigereScore.count.ToString()}";
        }
    }
}
