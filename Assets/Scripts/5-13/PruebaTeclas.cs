using UnityEngine;

public class PruebaTeclas : MonoBehaviour {
  public float velocidad = 5f;
  
  void Update() {
    float valorHorizontal = Input.GetAxis("Horizontal");
    float valorVertical = Input.GetAxis("Vertical");
    if (Input.GetKey(KeyCode.UpArrow)) {
      Debug.Log("Flecha Arriba: " + (velocidad * valorVertical));
    } else if (Input.GetKey(KeyCode.DownArrow)) {
      Debug.Log("Fecha Abajo: " + (velocidad * valorVertical));
    }

    if (Input.GetKey(KeyCode.RightArrow)) {
      Debug.Log("Flecha Derecha: " + (velocidad * valorHorizontal));
    } else if (Input.GetKey(KeyCode.LeftArrow)) {
      Debug.Log("Fecha Izquierda: " + (velocidad * valorHorizontal));
    }
  }
}
