using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadmanager : MonoBehaviour
{
    public void Sair()
    {
        Application.Quit();
    }
    public void Carregarcena(string name)
    {
        Application.LoadLevel(name);
    }
}
