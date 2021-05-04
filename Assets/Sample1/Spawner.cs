using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Transform> spawnPoint;
    private float spawnInverval = 1f;
    public bool IsPlaying = true;
    public GameObject monster;

    private IEnumerator Start()
    {
        // List���� ����� �� �ִ� �پ��� �ݺ���
        //// ���1.
        //for (int i = 0; i < spawnPoint.Count; i++)
        //{
        //    var x = spawnPoint[i];
        //    Debug.Log(x, x);
        //}

        //// ���2.
        //foreach (var x in spawnPoint)
        //{
        //    Debug.Log(x, x);
        //}

        // ���3.
        spawnPoint.ForEach(x => Debug.Log(x, x));

        while (IsPlaying)
        {
            //// ȣ���Ҷ����� ������ ��Ҹ� ��������.
            Transform selected = GetRandomPoint();
            SpawnMonster(selected);
            yield return new WaitForSeconds(spawnInverval);
        }
    }

    private void SpawnMonster(Transform selected)
    {
        Debug.Log(selected.name);
        Instantiate(monster, selected);
    }

    private Transform GetRandomPoint()
    {
        int selectedIndex;

        //// �⺻ C#�� ���� �Լ� ����.
        //System.Random random = new System.Random();
        //selectedIndex = random.Next(0, spawnPoint.Count);

        // UnityEngine���� �����ϴ� ���� �Լ� ����.
        selectedIndex = UnityEngine.Random.Range(0, spawnPoint.Count);

        return spawnPoint[selectedIndex];
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            Debug.Log(GetRandomPoint());
    }
}