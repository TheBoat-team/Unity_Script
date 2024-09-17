using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Courotine_Coint : MonoBehaviour
{
    public static Courotine_Coint instance;
    public Text Coint;
    public TMP_Text AllCoint;
    public TMP_Text CointsX2;

    public int courotine = 0;  
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Coint.text = "X " + courotine.ToString(); 
    }

    public void AddPoints()
    {
        courotine += 1;
        Coint.text = "X " + courotine.ToString();
        AllCoint.text = courotine.ToString();
        CointsX2.text = "+ " + (courotine * 2).ToString();
    }

    public void killEnemy()
    {
        courotine += 2;
        Coint.text = "X " + courotine.ToString();
        AllCoint.text = courotine.ToString();
        CointsX2.text = "+ " + (courotine * 2).ToString();
    }

}
