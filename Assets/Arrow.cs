using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ַο� �߻��ϴ� ��ũ��Ʈ.
/// </summary>
public class Arrow : MonoBehaviour
{
    public GameObject arrowGo;

    public Transform arrowSpawnPosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //�ַο츦 �߻�.
            Instantiate(arrowGo, arrowSpawnPosition.position, transform.rotation);
            // transform.position // world ���� ������.
            // transform.localPosition
        }
    }
}
