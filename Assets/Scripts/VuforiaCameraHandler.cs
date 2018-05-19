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
                gameObject.SetActive(false);
            }
        }
    }
}
