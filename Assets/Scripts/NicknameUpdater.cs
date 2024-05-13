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
        //gameObject.transform.parent.parent.gameObject.SetActive(false);       // gameObj와 같은 방법 = 부모 오브젝트 찾기
        if (inputField.text.Length >= 2 && inputField.text.Length <= 10)
        {
            nicknameText.text = inputField.text;
            gameObj.SetActive(false);
        }
        else
        {
            Debug.Log("닉네임은 2글자 이상, 10글자 이하로 입력하세요");
        }
    }
}
