using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi
{
    /// <summary>
    /// Geminin max h�z limiti
    /// </summary>
    int maksimumHiz;

    /// <summary>
    /// uzay gemisinin rengi
    /// </summary>
    string renk;

    /// <summary>
    /// max h�z de�erini d�ner
    /// </summary>
    public int MaksimumHiz
    {
        get
        {
            return maksimumHiz;
        }
    }

    /// <summary>
    /// geminin rengini d�ner.
    /// </summary>
    public string Renk
    {
        get
        {
            return renk;
        }
    }

    /// <summary>
    /// max h�z ve rengi yaz�n
    /// </summary>
    /// <param name="maksimumHiz"></param>
    /// <param name="renk"></param>
    public UzayGemisi(int maksimumHiz, string renk)
    {
        this.maksimumHiz = maksimumHiz;
        this.renk = renk;
    }

    public UzayGemisi(int maksimumHiz)
    {
        this.maksimumHiz = maksimumHiz;
    }


    /// <summary>
    /// Uzay Gemisi H�zland�rma S�per G�c�
    /// </summary>
    public void Hizlandirici()
    {
        maksimumHiz += Random.Range(5, 20);
        Debug.Log(maksimumHiz);
    }

    /// <summary>
    /// Uzay Gemisi Yava�latma
    /// </summary>
    public void Yavaslatici()
    {
        maksimumHiz -= Random.Range(5, 15);
        Debug.Log(maksimumHiz);
    }
}
