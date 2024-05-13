using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NicknameUpdater : MonoBehaviour
{
    public InputField inputField;
    public Text nicknameText;
    public GameObject gameObj;

       
    public void UpdateNickname()
    {
        //gameObject.transform.parent.parent.gameObject.SetActive(false);       // gameObj�� ���� ��� = �θ� ������Ʈ ã��
        if (inputField.text.Length >= 2 && inputField.text.Length <= 10)
        {
            nicknameText.text = inputField.text;
            gameObj.SetActive(false);
        }
        else
        {
            Debug.Log("�г����� 2���� �̻�, 10���� ���Ϸ� �Է��ϼ���");
        }
    }
}
