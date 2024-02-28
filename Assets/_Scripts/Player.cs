using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //摄像头
    public GameObject Camera;
    public float rotationSpeed = 30f; // 旋转速度（度/秒）
    public float targetRotation = 67f; // 目标旋转角度（度）
    private float currentRotation = 0f; // 当前已旋转的角度（度）
    bool CanRotate = false;

    //选项菜单
    public GameObject OptionsStg1;
    bool OptionsOpened = false;

    //玩家信息
    public GameObject Stg1_Name, Stg2_Portrait, Stg3_Tag;
    public GameObject PlayerStat;

    //头像
    public static Sprite Portrait;
    public GameObject PorImage;

    //名字
    public GameObject NameInput, NameText;
    public static string Name;

    //钱
    public int point = 0;

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

        if(CanRotate == true)
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;

            if (currentRotation < targetRotation)
            {
                // 绕着世界坐标系的Y轴旋转，实现相机的水平旋转
                Camera.transform.Rotate(Vector3.right, rotationAmount);
                currentRotation += rotationAmount;
            }
            else
                CanRotate = false;
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
        SceneNum = 1;
        CanRotate = true;
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
