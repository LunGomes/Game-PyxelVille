using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introducao : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Cena1", LoadSceneMode.Single);
    }

}
