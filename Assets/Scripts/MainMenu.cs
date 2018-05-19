using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IRL
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField]
        private GameObject contentButtons;

        void Start()
        {
            DisplayDefaultView();
        }

        public void DisplayDefaultView()
        {
            contentButtons.SetActive(true);
        }

        public void DisplayThemeView()
        {
            contentButtons.SetActive(false);
        }
    }
}