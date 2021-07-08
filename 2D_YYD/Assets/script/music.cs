using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    [Header("安靜")]
    public Sprite sprMute;
    [Header("有聲")]
    public Sprite sprVoc;

    /// <summary>
    /// order-button
    /// </summary>
    private Button btnVoc;

    /// <summary>
    /// order-button
    /// </summary>
    private Image imgVoc;

    private AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        imgVoc = GameObject.Find("voice").GetComponent<Image>();
        btnVoc = imgVoc.GetComponent<Button>();

        aud = GameObject.Find("Main Camera").GetComponent<AudioSource>();

        imgVoc.sprite = sprMute;
        btnVoc.onClick.AddListener(mute);
    }

    private void mute()
    {
        aud.mute = true;
        imgVoc.sprite = sprVoc;
        btnVoc.onClick.RemoveListener(mute);
        btnVoc.onClick.AddListener(voice);
    }

    private void voice()
    {
        aud.mute = false;
        imgVoc.sprite = sprMute;
        btnVoc.onClick.RemoveListener(voice);
        btnVoc.onClick.AddListener(mute);
    }

}
