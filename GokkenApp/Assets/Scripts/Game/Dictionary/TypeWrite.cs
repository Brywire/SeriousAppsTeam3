using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypeWrite : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _TMP;

    public string[] stringArray;

    [SerializeField] float timeBtwnChars;
    [SerializeField] float timeBtwnWords;

    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        EndCheck();
    }

    void EndCheck()
    {
       if(i <= stringArray.Length - 1)
        {
            _TMP.text = stringArray[i];
            StartCoroutine(TextVisible());
        }
    }

    private IEnumerator TextVisible()
    {
        _TMP.ForceMeshUpdate();
        int totalVisibleCharacters = _TMP.textInfo.characterCount;
        int counter = 0;

        while (true)
        {
            int visibleCount = counter % (totalVisibleCharacters + 1);
            _TMP.maxVisibleCharacters = visibleCount;

            if(visibleCount >- totalVisibleCharacters)
            {
                i += 1;
                Invoke("EndCheck", timeBtwnWords);
                break;
            }

            counter += 1;
            yield return new WaitForSeconds(timeBtwnChars);
        }
    }
}
