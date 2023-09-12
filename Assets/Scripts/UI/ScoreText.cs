using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField]
    private TMP_Text text;

    [SerializeField] 
    private PlayerController player;
    
    void Update()
    {
        text.text = player.GetScore().ToString();
    }
}
