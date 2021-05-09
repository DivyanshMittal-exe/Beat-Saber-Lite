using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //score
    public Text scoreTxt;

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = Spawn.score.ToString();
    }
}
