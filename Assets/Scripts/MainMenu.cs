using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IRL
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField]
        private GameObject contentButtons;
        [SerializeField]
        private GameObject background;
        [SerializeField]
        private GameObject hud;

        void Start()
        {
            DisplayDefaultView();
        }

        public void DisplayDefaultView()
        {
            //Display objects
            contentButtons.SetActive(true);
            background.SetActive(true);

            //Hide objects
            hud.SetActive(false);
        }

        public void DisplayThemeView()
        {
            //Display objects
            hud.SetActive(true);

            //Hide objects
            contentButtons.SetActive(false);
            background.SetActive(false);
        }
    }
}