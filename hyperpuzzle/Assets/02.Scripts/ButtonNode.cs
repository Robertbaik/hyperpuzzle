using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class ButtonNode : MonoBehaviour
{
    public int idx;

    public int xPos;
    public int yPos;

    public ButtonNode rightNode = null;
    public ButtonNode leftNode = null;

    public float test;

    public Button button;
    public TextMeshProUGUI textMesh;

    public Transform pos;
    
    void Start()
    {
        button = GetComponent<Button>();
        textMesh = this.GetComponentInChildren<TextMeshProUGUI>();
        button.onClick.AddListener(Onclick_Button);

        textMesh.fontSize = 100;
        SetNameIdx(idx);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Onclick_Button()
    {
        transform.DOMoveX(test, 1);
        Debug.Log($"Onclick : {transform.name}");
    }

    public void SetNameIdx(int num)
    {
        textMesh.text = num.ToString();
    }
}
