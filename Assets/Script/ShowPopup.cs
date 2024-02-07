using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowPopup : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Button btn;
    [SerializeField] private Button closebtn;


    void Start()
    {
        this.btn.onClick.AddListener(() =>
        {
            this.image.gameObject.SetActive(true);
        });
        this.closebtn.onClick.AddListener(() =>
        {
            this.image.gameObject.SetActive(false);
        });
    }
}
