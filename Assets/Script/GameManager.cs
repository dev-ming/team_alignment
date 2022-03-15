using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject TeamPrefab;
    public GameObject ContainerRight;
    public GameObject ContainerLeft;


    public Text TeamCountInput;


    int TeamCount;

    // Start is called before the first frame update
    void Start()
    {
        TeamCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TeamAdd()
    {
        TeamCount = int.Parse(TeamCountInput.text);
        Debug.Log(TeamCount);
        CreateTeam();
    }

    public void CreateTeam()
    {
        int Half = TeamCount / 2;
        Debug.Log(Half);
        for (int i = 1; i <= TeamCount; i++)
        {
            if (i <= Half)
            {
                GameObject Team = Instantiate(TeamPrefab, ContainerLeft.transform);
                Team.GetComponent<TeamPrefab>().Init(i, this);
            }
            else
            {
                GameObject Team = Instantiate(TeamPrefab, ContainerRight.transform);
                Team.GetComponent<TeamPrefab>().Init(i, this);
            }
        }
    }
}
