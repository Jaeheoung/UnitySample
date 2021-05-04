using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

/// <summary>
/// Ȯ���Լ� ����, �Լ� �̸��� �߿����� ����.
/// </summary>
static public class MyExtension
{
    static public string ToNumber(this int value)
    {
        return $"{value:N0}";
    }

    //static public string GetPath(this Transform t)
    //{
    //    string componentPath = t.name;
    //    Transform tParent = t.parent;
    //    while (tParent != null)
    //    {
    //        componentPath = string.Format("{0}/{1}", tParent.name, componentPath);
    //        tParent = tParent.parent;
    //    }
    //    return componentPath;
    //}

    static public string GetPath(this Transform t)
    {
        // �θ� ������ �θ� ��ο� ��� �����ڸ� �ִ´�.
        StringBuilder sb = new StringBuilder();
        GetParentPath(t, sb);
        return sb.ToString();

        void GetParentPath(Transform tr, StringBuilder sb)
        {
            if (tr.parent != null)
            {
                GetParentPath(tr.parent, sb);

                sb.Append(tr.parent.name);
                sb.Append(System.IO.Path.DirectorySeparatorChar);
            }

            sb.Append(tr.name);
        }
    }
}