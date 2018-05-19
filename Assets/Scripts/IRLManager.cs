using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IRL
{
    public class IRLManager : MonoBehaviour
    {
        [SerializeField]
        private MainMenu mainMenu;
        [SerializeField]
        private VuforiaCameraHandler vuforiaCamera;

        public void OnClickDisplayTheme()
        {
            mainMenu.DisplayThemeView();
            vuforiaCamera.TurnOn();
        }

        public void OnClickDisplayDefaultView()
        {
            mainMenu.DisplayDefaultView();
            vuforiaCamera.TurnOff();
        }
    }
}
