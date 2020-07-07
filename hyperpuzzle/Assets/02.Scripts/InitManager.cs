using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InitManager : MonoBehaviour
{
    public int gameLevel = 3;
    public GridLayoutGroup grid;
    public GameObject buttonObj;
    public ButtonNode[] buttonNodes;
    
    private void Start()
    {
        grid = GetComponent<GridLayoutGroup>();
        grid.constraintCount = gameLevel;

        buttonNodes = new ButtonNode[gameLevel * gameLevel];

        for (int i = 0; i < buttonNodes.Length; i++)
        {
            int idx = i + 1;

            GameObject obj = Instantiate(buttonObj) as GameObject;
            obj.transform.SetParent(this.transform);
            obj.transform.name = idx.ToString();
            buttonNodes[i] = obj.GetComponent<ButtonNode>();
            buttonNodes[i].idx = idx;
        }
    }

}
