using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlerHand : MonoBehaviour
{
    List<Card> list = new List<Card>();

    //手札に追加＝listに追加して自分の子要素にする
    public void Add(Card card)
    {
        list.Add(card);
    }
    public void Remove(Card card)
    {
        list.Remove(card);
    }

}
