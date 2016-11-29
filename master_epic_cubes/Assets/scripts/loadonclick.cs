using UnityEngine;
using System.Collections;

public class loadonclick : MonoBehaviour
{
    public GameObject loadingImage;


    public void LoadScene(int level)
    {

        loadingImage.SetActive(true);
        Application.LoadLevel(level);


    }

}
