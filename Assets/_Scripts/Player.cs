using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    //玩家信息
    public GameObject Stg1_Name, Stg2_Portrait, Stg3_Tag;
    public GameObject PlayerStat;

    //头像
    public static Sprite Portrait;
    public GameObject PorImage;

    //名字
    public GameObject NameInput, NameText;
    public static string Name;

    //当前场景
    public static int SceneNum = 0;

    void Start()
    {
        //关闭玩家信息
        PlayerStat.SetActive(false);

        //检查选项菜单
        if (OptionsStg1.activeSelf == true)
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

    //开始游戏
    public void GameStart()
    {

    }

    //玩家信息设置
    public void SetName()
    {
        Debug.Log($"{NameInput.GetComponent<TextMeshProUGUI>().text.Length}");

        if (NameInput.GetComponent<TextMeshProUGUI>().text.Length < 2)
        {
        }
        else
        {
            NameText.GetComponent<TextMeshProUGUI>().text = NameInput.GetComponent<TextMeshProUGUI>().text;
            Stg1_Name.SetActive(false);
            Stg2_Portrait.SetActive(true);
        }
    }

    public void SetProtrait(Sprite P)
    {
        Portrait = P;
        PorImage.GetComponent<Image>().sprite = P;
        Stg2_Portrait.SetActive(false);
        Stg3_Tag.SetActive(true);
    }

    public void SetTag()
    {
        Stg3_Tag.SetActive(false);
        PlayerStat.SetActive(true);
    }
}
