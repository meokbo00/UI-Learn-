using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIComponent : MonoBehaviour
{
    [SerializeField] private Button btn1;
    [SerializeField] private Button btn2;
    [SerializeField] private Button btn3;
    [SerializeField] private Button btn4;
    void Start()
    {
       
        this.btn1.onClick.AddListener(() =>
        {
            // 2,3번 비활성화
            this.btn2.gameObject.SetActive(false);
            this.btn3.gameObject.SetActive(false);
        });
        this.btn4.onClick.AddListener(() =>
        {
            // 2,3번 비활성화
            this.btn2.gameObject.SetActive(true);
            this.btn3.gameObject.SetActive(true);
        });
    }
}