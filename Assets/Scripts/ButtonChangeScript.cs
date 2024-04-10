using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChangeScript : MonoBehaviour
{
    public Button yourButton; // ���� ������
    public Sprite muteSprite; // ����������� ��� ��������� "mute"
    public Sprite unmuteSprite; // ����������� ��� ��������� "unmute"

    private bool isMuted = false; // ��������� �����

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        isMuted = !isMuted; // ����������� ��������� �����

        if (isMuted)
        {
            yourButton.image.sprite = muteSprite; // ������ ����������� �� "mute"
        }
        else
        {
            yourButton.image.sprite = unmuteSprite; // ������ ����������� �� "unmute"
        }

        // ����� �� ������ �������� ��� ��� ���������/���������� �����
    }
}
