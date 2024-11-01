using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Porta : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IrFinalizacao();
    }

    private void IrFinalizacao()
    {
        SceneManager.LoadScene("Finalizacao");
    }
}
