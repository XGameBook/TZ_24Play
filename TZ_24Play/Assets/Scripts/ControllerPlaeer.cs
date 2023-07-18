using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Rendering;
using UnityEngine;

public class ControllerPlaeer : MonoBehaviour
{

    public float speed = 1.0f;
    private float MaxPisitionX = 2;
    void Update()
    {
        Controller();
      //  Controller2();
    }

    private void Controller()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float pisitoonX = touch.deltaPosition.x;

            Vector3 pisitoon1 = new Vector3(pisitoonX, 0f, 0f) * speed * Time.deltaTime;
            Vector3 pisitoon2 = transform.position + pisitoon1;

            pisitoon2.x = math.clamp(pisitoon2.x, -MaxPisitionX, MaxPisitionX);
            transform.position = pisitoon2;
        }
    }

    private void Controller2()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        // Вычисляем новую позицию объекта
        Vector3 movement = new Vector3(moveHorizontal, 0f, 0f) * speed * Time.deltaTime;
        Vector3 newPosition = transform.position + movement;

        // Применяем ограничения по горизонтали и вертикали
        newPosition.x = Mathf.Clamp(newPosition.x, -2, 2);

        // Обновляем позицию объекта
        transform.position = newPosition;

    }
}
