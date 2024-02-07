using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
public class UINickname : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button TwoWordbtn;
    [SerializeField] private Button ThreeWordbtn;
    [SerializeField] private TMP_Text Changetext;
    void Start()
    {
        this.inputField.onValueChanged.AddListener((word) =>
        {
            if (word.Length < 3)
            {
                this.TwoWordbtn.gameObject.SetActive(true);
                this.ThreeWordbtn.gameObject.SetActive(false);

            }
            else if (word.Length >= 3)
            {
                this.TwoWordbtn.gameObject.SetActive(false);
                this.ThreeWordbtn.gameObject.SetActive(true);
            }
            this.ThreeWordbtn.onClick.AddListener(() =>
            {
                this.Changetext.text = string.Format("바뀐 닉네임 : {0}", word);
                this.ThreeWordbtn.onClick.AddListener(() =>
                {
                    this.Changetext.text = string.Format("닉네임이 똑같습니다");
                });
            });
        });
    }

}