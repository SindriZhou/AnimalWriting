using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //ѡ��˵�
    public GameObject OptionsStg1;
    bool OptionsOpened = false;

    //Ǯ
    public int point = 0;

    //�����Ϣ
    public GameObject Stg1_Name, Stg2_Portrait, Stg3_Tag;
    public GameObject PlayerStat;

    //ͷ��
    public static Sprite Portrait;
    public GameObject PorImage;

    //����
    public GameObject NameInput, NameText;
    public static string Name;

    //��ǰ����
    public static int SceneNum = 0;

    void Start()
    {
        //�ر������Ϣ
        PlayerStat.SetActive(false);

        //���ѡ��˵�
        if (OptionsStg1.activeSelf == true)
            OptionsStg1.SetActive(false);
    }

    void Update()
    {
        //ѡ��˵�
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

    //��ʼ��Ϸ
    public void GameStart()
    {

    }

    //�����Ϣ����
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
