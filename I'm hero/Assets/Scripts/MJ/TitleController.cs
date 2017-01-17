using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    //씬 전환이 되길 바람
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("Startscene");
    }
}


