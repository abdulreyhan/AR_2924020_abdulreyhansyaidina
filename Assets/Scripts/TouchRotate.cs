using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    // Kecepatan putaran, bisa diatur lewat Inspector Unity
    public float rotationSpeed = 0.2f; 

    void Update()
    {
        // Mengecek apakah ada setidaknya satu jari yang menyentuh layar
        if (Input.touchCount > 0)
        {
            // Mengambil data sentuhan pertama (indeks 0)
            Touch touch = Input.GetTouch(0);

            // Mengecek apakah jari sedang bergerak mengusap layar
            if (touch.phase == TouchPhase.Moved)
            {
                // Menghitung jarak pergeseran jari
                float rotationX = touch.deltaPosition.x * rotationSpeed;
                float rotationY = touch.deltaPosition.y * rotationSpeed;

                // Memutar objek berdasarkan arah gesekan (sumbu Y untuk horizontal, sumbu X untuk vertikal)
                transform.Rotate(Vector3.up, -rotationX, Space.World);
                transform.Rotate(Vector3.right, rotationY, Space.World);
            }
        }
    }
}