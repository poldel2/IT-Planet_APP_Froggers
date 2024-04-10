using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackFound : MonoBehaviour
{
    FadeInText fadeInText;

    private void Start()
    {
        Debug.Log("Start");
        fadeInText = FindObjectOfType<FadeInText>();
    }

    public void StartFadeInText()
    {
        if (fadeInText != null)
        {
            Debug.Log("StartFade");
            fadeInText.StartFadeIn();
        }
    }
}
