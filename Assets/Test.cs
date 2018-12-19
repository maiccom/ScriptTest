//課題：配列を宣言して出力しましょう

using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
        int[] array = { 10, 20, 30, 40, 50 };

        //for文を使い、配列の各要素の値を順番に表示
        for (int i=0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //for文を使い、配列の各要素の値を順番に表示
        for (int i = array.Length - 1; i > -1; i--) 
        {
            Debug.Log(array[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}