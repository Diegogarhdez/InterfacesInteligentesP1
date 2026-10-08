using UnityEngine;

public class MovimientoCoche : MonoBehaviour {
  public float speed = 5f;
  public float velocidadGiro = 100f; 
  void Update() {
    float giro = Input.GetAxis("Horizontal");
    transform.Rotate(0, giro * velocidadGiro * Time.deltaTime, 0);
    transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    Debug.DrawRay(transform.position, transform.forward * 5f, Color.red);
  }
}