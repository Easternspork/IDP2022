using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CustomEditorWindow : EditorWindow
{
   [MenuItem("Tools/CustomWindow")]
   public static void ShowWindow()
    {
        GetWindow<CustomEditorWindow>("CustomEditorWindow");
    }

    void OnGUI()
    {
        //GUILayout.Label("Cube Spawner", EditorStyles.boldLabel);
        //if(GUILayout.Button("Spawn Cube"))
        //{
        //    SpawnCube();
        //}

        GUILayout.Label("Reload Item Database", EditorStyles.boldLabel);
        if(GUILayout.Button("Reload Items"))
        {
            GameObject.Find("Databases").GetComponent<LoadExcel>().LoadItemData();
        }
    }

    //void SpawnCube()
    //{
        //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //cube.transform.position = new Vector3(0, 0, 0);
    //}

}
