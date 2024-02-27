using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //选项菜单
    public GameObject OptionsStg1;
    bool OptionsOpened = false;

    //钱
    public int point = 0;

    //头像
    public static Sprite Portrait;
    public GameObject PorImage;

    void Start()
    {
        //检查选项菜单
        if(OptionsStg1.activeSelf == true)
            OptionsStg1.SetActive(false);
    }

    void Update()
    {
            //选项菜单
            if (Input.GetKeyDown(KeyCode.Escape))
        {
            OptionMenu();
        }
    }

    public void OptionMenu()
    {
        if (!OptionsOpened)
        {
            OptionsOpened = true;
            OptionsStg1.SetActive(true);
        }
        else
        {
            OptionsOpened = false;
            OptionsStg1.SetActive(false);
        }
    }

    public void SetProtrait(Sprite P)
    {
        Portrait = P;
        PorImage.GetComponent<Image>().sprite = P;
    }
}
