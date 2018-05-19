using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace IRL
{
    public class ScanButton : MonoBehaviour
    {
        [SerializeField]
        private string number;
        [SerializeField]
        private string theme;

        [SerializeField]
        private Text numberText;
        [SerializeField]
        private Text themeText;

        void Start()
        {
            numberText.text = number;
            themeText.text = theme;
        }
    }
}
