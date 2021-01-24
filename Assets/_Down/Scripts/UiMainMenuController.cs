using UnityEngine;
using UnityEngine.SceneManagement;

namespace _DownGame
{
    public class MainMenuController : MonoBehaviour
    {
   
        public void StartGame()
        {
            SceneManager.LoadScene(1); // load game scene
        }
        public void Exit()
        {
            Application.Quit();
        }

    }
}