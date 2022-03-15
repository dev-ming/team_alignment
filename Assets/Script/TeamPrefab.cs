using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeamPrefab : MonoBehaviour
{
    public int id;
    public string name;
    public GameManager gameManager;
    public Text TeamName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Init(int id_, GameManager gameManager_)
    {
        id = id_;
        gameManager = gameManager_;

        TeamName.text = id + "조";
        //ChannelName.text = name;
    }
}
