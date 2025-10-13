using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] Battler player;//Battlerというクラスの中のplayer」＝Battleというスクリプトの中で定義されたplayer?でも定義してないから、Battlerで定義されたものを使ってここでplayerを定義するよてこと？クラスの指定はなんの意味がある？
    [SerializeField] Battler enemy;
    
}
