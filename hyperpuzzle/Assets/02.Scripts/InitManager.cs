using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Node
{
    public int xPos;
    public int yPos;

    public int idx;

    public Node rightNode;
    public Node leftNode;

    public Node(int i)
    {
        idx = i;
    }
}

public class InitManager : MonoBehaviour
{
    public int gameLevel;
    public GameObject blockBtn;
    void Start()
    {
        InitGameLevel(gameLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitGameLevel(int level)
    {
        for (int i = 0; i < level*level; i++)
        {
            Node node = new Node(i);
            InitBtnObj(node);
        }
    }

    public void InitBtnObj(Node node)
    {

    }

}
