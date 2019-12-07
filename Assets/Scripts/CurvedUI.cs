using UnityEngine;
using System.Collections;

namespace CurvedUI
{
    public class CUI_CameraController : MonoBehaviour
    {
        public static CUI_CameraController instance;
        [SerializeField]
        Transform CameraObject;
        float rotationMargin = 25;

        void Awake()
        {
            instance = this;
        }

        void Update()
        {
           // CameraObject.localEulerAngles = new Vector3(Input.mousePosition.y.Remap(0, Screen.height, rotationMargin, -rotationMargin),
                                                     //   Input.mousePosition.x.Remap(0, Screen.width, -rotationMargin, rotationMargin), 0);
        }
    }
}
