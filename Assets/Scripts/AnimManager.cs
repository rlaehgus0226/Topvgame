using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour
{
    public List<RuntimeAnimatorController> anims;
    public RuntimeAnimatorController anim1;
    public RuntimeAnimatorController anim2;
    public Animator nowAnim;
    public GameObject player;
    public bool anim1t = true;
    public bool anim2t = true;

    private void Start()
    {
        nowAnim = player.GetComponent<Animator>();
    }

    public void ChangeAnim1()
    {
       if (nowAnim.runtimeAnimatorController == anim1)
        {
            nowAnim.runtimeAnimatorController = anim2;
        }
        else
        {
            Debug.Log("이미 선택되었습니다");
        }
    }

    public void ChangeAnim2()
    {
        if (nowAnim.runtimeAnimatorController == anim2)
        {
            nowAnim.runtimeAnimatorController = anim1;
        }
        else
        {
            Debug.Log("이미 선택되었습니다");
        }
    }


}
