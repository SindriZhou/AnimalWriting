using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Click_Level1 : MonoBehaviour
{
    public GameObject OpenObject;

    public string targetTag = "Level1"; // ����ı�ǩ

    void Update()
    {
        // ������������
        if (Input.GetMouseButtonDown(0) && Click.allowClicking)
        {
            // ����һ�����߼���Ƿ�����������
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hit");

                // ����������ָ����ǩ�����壬���ƶ��������Ŀ��λ�ò�������ת
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
