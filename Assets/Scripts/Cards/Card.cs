using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

/*
Canvasは普通字幕みたいになってて、カメラに張り付いてるもの（Transformを指定できない）→Render ModeをWorld Spaceにしたらそれが解除
panelがframe、Source Image（Background）を指定、ぼやけていたらFilterModeをNonFilterにしたらOK
画像のSprite Editorで、緑の線を9スライスの位置に置く、panelのImage TypeをSlicedにすると、角が引き伸ばされず、真ん中だけ引き伸ばされる
Transformの左のStretchは何？センターの決定？
Prefabフォルダを作って、"Card"を入れるだけでPrefab作成完了、Hierarcyの方は削除




Rrivalsの作り方オフライン編
・新規作成/素材のインポート
・カードPrefabの作成
・カードの作成
・GameMasterとBattlerの作成
・手札にカードを配る
・カードを選択して場に出す（SubmitPositionの作成）
・決定ボタンを押してEnemyのカードを出す（PlayerInpotとRandom）
・勝敗をジャッジする（簡易）
・結果を表示する（GameUIの作成）
・次のターンの準備をする
・ライフを実装する
・勝敗を表示する
・カードの効果を実装する
・タイトル画面とUIを整える
*/