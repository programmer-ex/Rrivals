using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] Card cardPrefab;

    private void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            Spawn();
        }
    }
    //Cardの生成
    public void Spawn()//()は、今からこの関数作りますって意味？でもStart()とかがあるってことは、元々意味がある関数を使うっていうこと？
    {
        Instantiate(cardPrefab);
    }
}
