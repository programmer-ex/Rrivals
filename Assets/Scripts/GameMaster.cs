using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] Battler player;
    //Battlerというクラスの中のplayer」＝Battleというスクリプトの中で定義されたplayer?でも定義してないから、Battlerで定義されたものを使ってここでplayerを定義するよてこと？クラスの指定はなんの意味がある？
    //Inspectorでは、Player(Battler)と表示されてる。じゃあこのBattlerは買ってに決めれる属性？

    [SerializeField] Battler enemy;
    [SerializeField] CardGenerator cardGenerator;
    //「カードを生成するためにはCardGeneratorを引っ張ってこないといけない」

    private void Start()
    {
        Setup();
    }

    //カードを生成して配る
    void Setup()//初登場やんな？以下はSetupの定義？
    {
        for (int i = 0; i < 8; i++)
        {
            Card card = cardGenerator.Spawn(i);//「カードを渡される」
                                               //「これをプレイヤーの手札に追加」
            player.Hand.Add(card);
        }
    }

}
