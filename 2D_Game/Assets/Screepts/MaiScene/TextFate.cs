using UnityEngine;
using UnityEngine.UI;

public class TextFate : MonoBehaviour
{
    private Text txt;
    private Outline outline;
    void Start()
    {
        txt = GetComponent<Text>();
        outline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, Mathf.PingPong(Time.time/1.2f, 1.0f));
        outline.effectColor = new Color(outline.effectColor.r, outline.effectColor.g, outline.effectColor.b, txt.color.a -0.3f);
    }
}
