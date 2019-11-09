using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public GameObject completeLevelUI;

    public GameObject youlostUI;

    public void EndGame()
    {
        FixedUpdate();
        youlostUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene("level01");
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        FixedUpdate();
    }

    void FixedUpdate()
    {

        if (Input.GetKey("r"))
        {
            Restart();
        }

    }

}

