using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    //ѡ��˵�
    public GameObject OptionsStg1;
    bool OptionsOpened = false;

    //Ǯ
    public int point = 0; 

    // Start is called before the first frame update
    void Start()
    {
        //���ѡ��˵�
        if(OptionsStg1.activeSelf == true)
            OptionsStg1.SetActive(false);
    }

    // Update is called once per frame
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
}
