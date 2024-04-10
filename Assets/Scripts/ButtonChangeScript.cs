using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChangeScript : MonoBehaviour
{
    public Button yourButton; // ваша кнопка
    public Sprite muteSprite; // изображение для состояния "mute"
    public Sprite unmuteSprite; // изображение для состояния "unmute"

    private bool isMuted = false; // состояние звука

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        isMuted = !isMuted; // переключаем состояние звука

        if (isMuted)
        {
            yourButton.image.sprite = muteSprite; // меняем изображение на "mute"
        }
        else
        {
            yourButton.image.sprite = unmuteSprite; // меняем изображение на "unmute"
        }

        // здесь вы можете добавить код для включения/выключения звука
    }
}
