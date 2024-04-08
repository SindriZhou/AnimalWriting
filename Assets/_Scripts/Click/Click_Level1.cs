using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Click_Level1 : MonoBehaviour
{
    public GameObject OpenObject;

    public string targetTag = "Level1"; // 物体的标签

    void Update()
    {
        // 检测鼠标左键点击
        if (Input.GetMouseButtonDown(0) && Click.allowClicking)
        {
            // 发射一条射线检测是否点击到了物体
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hit");

                // 如果点击到了指定标签的物体，则移动摄像机到目标位置并设置旋转
                if (hit.collider.CompareTag(targetTag))
                {
                    OpenObject.SetActive(true);
                    GameObject.Find("SdM_UI").GetComponent<SdM_ui>().OpenChat();
                    Click.allowClicking = false;
                    GameObject.Find("Flowchart").GetComponent<Flowchart>().SendFungusMessage("Mail1");
                }
            }
        }
    }
}
