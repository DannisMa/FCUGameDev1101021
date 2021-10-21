using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameSystem : MonoBehaviour
{
    public int ans; //用來存放答案的變數
    public GameObject input_text; //用來存放輸入框物件的變數
    public GameObject show_text; //用來存放顯示文字物件的變數

    // Start is called before the first frame update
    void Start()
    {
        ans = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick(){

        string it = input_text.GetComponent<Text>().text; //先拿到玩家輸入的文字
        int num; //用來儲存把文字轉成數字後的值

        if( it == "" ){ //如果玩家沒輸入
            show_text.GetComponent<Text>().text  = "輸入值不能為空";
        }
        else if( it != "")
        {
            num = int.Parse(it); //將玩家輸入文字轉成文字

            if(num == ans){
                show_text.GetComponent<Text>().text  = "猜對了";
            }
            else if(num > ans){
                show_text.GetComponent<Text>().text  = "太大了";
            }
            else if( num < ans){
                show_text.GetComponent<Text>().text  = "太小了";
            }
        }
    }
}
