using UnityEngine;

public class NewEmptyCSharpScript : MonoBehaviour {
  public Vector3 desplazamiento;
  private Vector3 posicionOriginal;
  void Start() {
    posicionOriginal = transform.position;
  }

  void Update() {
    if (Input.GetAxis("Jump") > 0) {
      Debug.Log("Espacio pulsado");
      transform.position = posicionOriginal + desplazamiento;
    } else {
      transform.position = posicionOriginal;
    }
  }
}
