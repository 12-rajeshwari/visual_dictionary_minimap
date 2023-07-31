 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 namespace Minimap
 {
     public class minimap_window : MonoBehaviour
     {
         private static minimap_window instance;

         private void Awake()
         {
             instance = this;
         }

         void Update()
         {
             if (Input.GetKeyDown(KeyCode.M))
             {
                 ToggleMinimap(true);
             }

             if (Input.GetKeyDown(KeyCode.N))
             {
                 ToggleMinimap(false);
             }
         }

         void ToggleMinimap(bool show)
         {
             if (show)
             {
                 Show();
             }
             else
             {
                 Hide();
             }
         }
         void Show()
        {
            instance.gameObject.SetActive(true);
        }
        
         void Hide()
        {
            instance.gameObject.SetActive(false);
        }
    }  
 }

