using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffDrop : MonoBehaviour
{
    public GameObject staffPrefab;
    float span = 3.0f; //ȭ�� ���� �ֱ�
    float delta = 0; //���� ��� �ð�
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;//deltaTime: ���� �����ӿ��� ���� ������ ������ ��� �ð�
        if (delta > span)
        {
            delta = 0;
            GameObject StaffPrefab = Instantiate(staffPrefab);
            StaffPrefab.transform.position = target.position + new Vector3(0f, 2f, 0f);
            StaffPrefab.transform.parent = transform;
        }
    }
}
