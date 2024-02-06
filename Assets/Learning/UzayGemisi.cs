using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi
{
    /// <summary>
    /// Geminin max hýz limiti
    /// </summary>
    int maksimumHiz;

    /// <summary>
    /// uzay gemisinin rengi
    /// </summary>
    string renk;

    /// <summary>
    /// max hýz deðerini döner
    /// </summary>
    public int MaksimumHiz
    {
        get
        {
            return maksimumHiz;
        }
    }

    /// <summary>
    /// geminin rengini döner.
    /// </summary>
    public string Renk
    {
        get
        {
            return renk;
        }
    }

    /// <summary>
    /// max hýz ve rengi yazýn
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
    /// Uzay Gemisi Hýzlandýrma Süper Gücü
    /// </summary>
    public void Hizlandirici()
    {
        maksimumHiz += Random.Range(5, 20);
        Debug.Log(maksimumHiz);
    }

    /// <summary>
    /// Uzay Gemisi Yavaþlatma
    /// </summary>
    public void Yavaslatici()
    {
        maksimumHiz -= Random.Range(5, 15);
        Debug.Log(maksimumHiz);
    }
}
