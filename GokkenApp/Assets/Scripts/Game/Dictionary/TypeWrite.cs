using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class TypeWrite : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Tekst;
    [SerializeField] TextMeshProUGUI Name;

    public string[] stringTekstArray;
    public string[] stringNameArray;

    [SerializeField] float timeBtwnChars;
    [SerializeField] float timeBtwnWords;

    int i = 0;

    void Start()
    {
        EndCheck();
        BackCheck();
    }

    public void EndCheck()
    {
        if (i <= stringTekstArray.Length - 1)
        {
            Tekst.text = stringTekstArray[i];
            StartCoroutine(TextVisible());
        }
        if (i <= stringNameArray.Length - 1)
        {
            Name.text = stringNameArray[i];
        }
    }

    public void BackCheck()
    {
        if (i <= stringTekstArray.Length + 1)
        {
            Tekst.text = stringTekstArray[i];
            StartCoroutine(TextVisible());
        }
        if (i <= stringNameArray.Length + 1)
        {
            Name.text = stringNameArray[i];
        }
    }

    private IEnumerator TextVisible()
    {
        Tekst.ForceMeshUpdate();
        Name.ForceMeshUpdate();
        int totalVisibleTekstCharacters = Tekst.textInfo.characterCount;
        int counter = 0;

        while (true)
        {
            int visibleCount = counter % (totalVisibleTekstCharacters + 1);
            int visibleBackCount = counter % (totalVisibleTekstCharacters + 1);
            Tekst.maxVisibleCharacters = visibleCount;
            Tekst.maxVisibleCharacters = visibleBackCount;

            if (visibleCount >= totalVisibleTekstCharacters)
            {
                i += 1;
                //Invoke("EndCheck", timeBtwnWords);
                break;
            }
            if (visibleBackCount >= totalVisibleTekstCharacters)
            {
                i -= 1;
                //Invoke("EndCheck", timeBtwnWords);
                break;
            }

                counter += 1;
                yield return new WaitForSeconds(timeBtwnChars);


        }
    }
}