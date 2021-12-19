using UnityEngine;

public class TrigereScore : MonoBehaviour
{    
    public static int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        count++;
    }
}
