using UnityEngine;
namespace _DownGame
{
    public class UiMenuController : MonoBehaviour
    {

        [SerializeField]
        GameObject pauseMenu;

        public static bool GameIsPaused = false;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (GameIsPaused)
                {
                    HidePauseMenu();
                }
                else
                {
                    ShowPauseMenu();
                }
            }
        }

        public void HidePauseMenu()
        {
            pauseMenu.SetActive(false);
            GameIsPaused = false;
            Time.timeScale = 1f;
        }

        public void ShowPauseMenu()
        {
            pauseMenu.SetActive(true);
            GameIsPaused = true;
            Time.timeScale = 0f;
        }
        public void Quit()
        {
            Application.Quit();
        }

    }
}