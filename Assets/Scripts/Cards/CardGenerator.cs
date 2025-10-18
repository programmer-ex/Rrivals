using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] CardBase[] cardBases;//CardBaseからリストを作成？名前はcardBases?
    [SerializeField] Card cardPrefab;

    /*「これはテスト用」
    private void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            Spawn(i);//どこにspawnすんねん？spawnはそれだけで意味通じる？
        }
    }*/

    //Cardの生成
    public Card Spawn(int number)//()は、今からこの関数作りますって意味？でもStart()とかがあるってことは、元々意味がある関数を使うっていうこと？
    //「spawnは関数実行するだけじゃ取得ができないから”Card"」
    {
        Card card = Instantiate(cardPrefab);
        card.Set(cardBases[number]);
        ///0番目が与えられたら、0番目のやつをデータとしてセットする関数
        /// (int number)のnumberがここのnumberに渡されてる？なぜSet関数の呼び出しはこっち？カード
        return card;
        //「カードを生成して返すまでをする
    }
}
