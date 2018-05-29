using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IRL
{
    public class VuforiaCameraHandler : MonoBehaviour
    {
        [SerializeField]
        private bool disableCameraOnStart;

        void Start()
        {
            if (disableCameraOnStart)
            {
                TurnOff();
            }
        }

        public void TurnOff()
        {
            gameObject.SetActive(false);
        }

        public void TurnOn()
        {
            gameObject.SetActive(true);
        }
    }
}
