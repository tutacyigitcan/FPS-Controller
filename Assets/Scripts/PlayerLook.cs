using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
   [SerializeField] private float sensitivityX = 2f;
   [SerializeField] private float sensitivityY = 2f;

   private float rotationX = 0f;
   private float rotationY = 0f;

   private void Start()
   {
      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
   }

   private void Update()
   {
      float mouseX = Input.GetAxis("Mouse X") * sensitivityX;
      float mouseY = Input.GetAxis("Mouse Y") * sensitivityY;

      rotationX -= mouseY;
      rotationX = Mathf.Clamp(rotationX, -90f, 90f);

      rotationY += mouseX;

      transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);
   }
   
}
