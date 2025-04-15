using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class SceneChanger : MonoBehaviour
{
    public int SceneNumber;
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
