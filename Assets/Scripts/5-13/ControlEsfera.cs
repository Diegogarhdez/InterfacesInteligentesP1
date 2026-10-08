using UnityEngine;

public class ControlEsfera : MonoBehaviour {
  public float speed = 0.1f;

  void Update() {
    float x = 0f;
    float z = 0f;
    if (Input.GetKey(KeyCode.D)) { x = 1f; }
    if (Input.GetKey(KeyCode.A)) { x = -1f; }
    if (Input.GetKey(KeyCode.W)) { z = 1f; }
    if (Input.GetKey(KeyCode.S)) { z = -1f; }
    transform.Translate(x * speed * Time.deltaTime, 0, z * speed * Time.deltaTime);
  }
}
