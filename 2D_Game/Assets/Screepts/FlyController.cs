using UnityEngine;

public class FlyController : MonoBehaviour
{
    public bool clicked;
    public GameObject cube;
    public GameObject detectedClicks;
    private readonly float forceTapUp = 20f;
    private readonly float forceTapForword = 3f;    

    private void FixedUpdate()
    {
        clicked = detectedClicks.GetComponent<DetectClics>().clicked;
        if (Input.GetKey(KeyCode.Mouse0)&&clicked)
        {
            clicked = detectedClicks.GetComponent<DetectClics>().clicked;
            cube.GetComponent<Rigidbody>().AddForce(new Vector3(forceTapForword, forceTapUp, 0));
        }
        Camera.main.transform.position = new Vector3(cube.transform.position.x , Camera.main.transform.position.y, Camera.main.transform.position.z);
    }
}
      
