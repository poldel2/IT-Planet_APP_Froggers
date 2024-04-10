using UnityEngine;
using System.Collections;
using TMPro;

public class FadeInText : MonoBehaviour
{
    public float delay = 1f;
    public float typeSpeed = 0.05f; // скорость появления текста

    [SerializeField] private TMP_Text textComponent;
    private Coroutine fadeInCoroutine;
    private string fullText;

    private void Start()
    {
        fullText = textComponent.text;
        textComponent.text = "";
    }

    public void StartFadeIn()
    {
        if (fadeInCoroutine != null)
        {
            StopCoroutine(fadeInCoroutine);
        }

        textComponent.text = ""; // очищаем текст перед началом анимации
        fadeInCoroutine = StartCoroutine(FadeInCoroutine());
    }

    private IEnumerator FadeInCoroutine()
    {
        yield return new WaitForSeconds(delay);

        //string fullText = textComponent.text;


        for (int i = 0; i < fullText.Length; i++)
        {
            textComponent.text += fullText[i];
            yield return new WaitForSeconds(typeSpeed);
        }
    }

    public void SkipFadeIn()
    {
        if (fadeInCoroutine != null)
        {
            StopCoroutine(fadeInCoroutine);
        }

        textComponent.text = fullText; // отображаем весь текст сразу
    }

    public void HideText()
    {
        if (textComponent.enabled)
            textComponent.enabled = false;
        else
            textComponent.enabled = true;
    }
}
