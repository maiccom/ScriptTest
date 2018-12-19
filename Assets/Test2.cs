//発展課題:Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう

using UnityEngine;
using System.Collections;

public class Boss
{
    private int mp = 53; // int型の変数mpを宣言し、53で初期化


    //mpを消費して魔法攻撃をするMagic関数
    public void Magic()
    {
        //Magic関数内でmpを5減らし、「魔法攻撃をした。残りMPは〇〇。」
        //mpが足りない場合、「MPが足りないため魔法が使えない」

        if (mp > 5)
        {
            // 残りmpを減らす
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");

        }
        else { 
            Debug.Log("MPが足りないため魔法が使えない。");
        }

     }
}

public class Test2 : MonoBehaviour
{

    void Start()
    {

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //Magic関数を呼び出して、魔法を10回使ってください
        for (int i = 0; i<=10; i++)
        {
            // Magic用の関数を呼び出す
            lastboss.Magic();

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}