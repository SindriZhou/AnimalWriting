using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    //选项菜单
    public GameObject OptionsStg1;
    bool OptionsOpened = false;

    //钱
    public int point = 0; 

    // Start is called before the first frame update
    void Start()
    {
        //检查选项菜单
        if(OptionsStg1.activeSelf == true)
            OptionsStg1.SetActive(false);
    }

    // Update is called once per frame
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
}
