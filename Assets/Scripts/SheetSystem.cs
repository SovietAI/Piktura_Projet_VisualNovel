using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class SheetSystem : MonoBehaviour
{
    public string linkedSceneName;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && EventSystem.current.IsPointerOverGameObject()) // Si pointeur sur objet et click
        {
            SceneChange();
        }
    }

    private void SceneChange() // Script de changement de scene
    {
        SceneManager.LoadScene(linkedSceneName);
    }


}
