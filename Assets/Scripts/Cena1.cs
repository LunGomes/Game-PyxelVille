using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cena1 : MonoBehaviour
{
   void OnEnable()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
}
