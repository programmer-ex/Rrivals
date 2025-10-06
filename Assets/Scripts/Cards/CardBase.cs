using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]//ScriptableObjectの特徴？
public class CardBase : ScriptableObject
{
    //カードの基礎データ、MonoBehaviorじゃなくScriptableObjectの方が便利？
    [SerializeField] new string name;
    [SerializeField] CardType type;
    [SerializeField] int number;
    [SerializeField] Sprite icon;
    [TextArea]
    [SerializeField] string description;

    public string Name { get => name; }
    public CardType Type { get => type; }
    public int Number { get => number; }
    public Sprite Icon { get => icon; }
    public string Description { get => description; }

    ///SerializeFieldってなんやっけ、publicとprivateの中間的な感じやったと思うけど
    /// publicはゲーム中に値をいじりたいとき
    /// [SerializeField]はunityのInspectorでは調節したいけど外部からいじれないようにしたい時
    /// privateはコードの内部で値を決めたい時
    /// プロパティ化は読み取り専用として表示させたい時


}

public enum CardType
{
    Clown,
    Princess,
    Spy,
    Assassin,
    Minister,
    Witch,
    Shogun,
    Prince,

}
