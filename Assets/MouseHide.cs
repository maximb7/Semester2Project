using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHide : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
  
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

