using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minimap
{
    public class MinimapController : MonoBehaviour
    {
        private bool isMinimapVisible = false;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                ToggleMinimap();
            }
        }

        void ToggleMinimap()
        {
            isMinimapVisible = !isMinimapVisible;
            if (isMinimapVisible)
            {
                ShowMinimap();
            }
            else
            {
                HideMinimap();
            }
        }

        void ShowMinimap()
        {
            // Implement your logic to show the minimap here
            // For example, you can enable the minimap GameObject or set its visibility to true.
            // For demonstration purposes, let's assume you have a "minimapCanvas" GameObject that represents the minimap UI canvas.
            GameObject minimapCanvas = GameObject.Find("minimap_controller");
            if (minimapCanvas != null)
            {
                minimapCanvas.SetActive(true);
            }
        }

        void HideMinimap()
        {
            // Implement your logic to hide the minimap here
            // For example, you can disable the minimap GameObject or set its visibility to false.
            // For demonstration purposes, let's assume you have a "minimapCanvas" GameObject that represents the minimap UI canvas.
            GameObject minimapCanvas = GameObject.Find("minimap_controller");
            if (minimapCanvas != null)
            {
                minimapCanvas.SetActive(false);
            }
        }
    }
}

   