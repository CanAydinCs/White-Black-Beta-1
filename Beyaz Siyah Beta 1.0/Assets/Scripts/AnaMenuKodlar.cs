using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenuKodlar : MonoBehaviour {
    public GameObject anaMenu, ayarlar, levelSecme;

    public void AnaMenuToLevelSecme()
    {
        anaMenu.SetActive(false);
        levelSecme.SetActive(true);
    }

    public void AnaMenuGo()
    {
        anaMenu.SetActive(true);
        levelSecme.SetActive(false);
        ayarlar.SetActive(false);
    }

    public void AnaMenuToAyarlar()
    {
        anaMenu.SetActive(false);
        ayarlar.SetActive(true);
    }

    public void Kapat()
    {
        Application.Quit();
    }

    public void LeveleGit(int index)
    {
        SceneManager.LoadScene(index);
    }
}
