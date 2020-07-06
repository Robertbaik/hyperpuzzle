using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonNode : MonoBehaviour
{
    public int idx;

    public int xPos;
    public int yPos;

    public ButtonNode rightNode = null;
    public ButtonNode leftNode = null;

    public Button btn;
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(Onclick_Button);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Onclick_Button()
    {
        transform.DOMoveX(2, 1);
        Debug.Log($"Onclick : {transform.name}");
    }
}
