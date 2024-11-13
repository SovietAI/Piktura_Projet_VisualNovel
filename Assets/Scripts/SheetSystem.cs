using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using Tymski; // Nécessaire pour la reference de scene

public class SheetSystem : MonoBehaviour
{
    public SceneReference linkedScene;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && EventSystem.current.IsPointerOverGameObject()) // Si pointeur sur objet et click
        {
            SceneChange();
        }
    }

    public void SceneChange() // Script de changement de scene
    {
        SceneManager.LoadScene(linkedScene);
    }


}
