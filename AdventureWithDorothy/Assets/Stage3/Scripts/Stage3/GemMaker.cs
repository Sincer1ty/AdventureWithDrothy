using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemMaker : MonoBehaviour
{
    public GameObject gemPrefab;
    public int gemCounts = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < gemCounts; i++)
        {
            MakeGems();
        }
    }
    void MakeGems()
    {
        float randomX = Random.Range(-59f, 66f);
        float randomZ = Random.Range(-63f, 4f);

        Debug.Log("Gem ����");

        if (true)
        {
            GameObject GemPrefab = (GameObject)Instantiate(gemPrefab, new Vector3(randomX, 6f, randomZ), Quaternion.identity);
            GemPrefab.transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        

        

    }
}
