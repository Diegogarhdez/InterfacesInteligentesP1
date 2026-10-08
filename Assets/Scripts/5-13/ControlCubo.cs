using UnityEngine;

public class ControlCubo : MonoBehaviour {
  public float speed = 0.1f;

  void Update() {
    float x = 0f;
    float z = 0f;

    if (Input.GetKey(KeyCode.RightArrow)) { x = 1f; }
    if (Input.GetKey(KeyCode.LeftArrow))  { x = -1f; }

    if (Input.GetKey(KeyCode.UpArrow)) { z = 1f; }
    if (Input.GetKey(KeyCode.DownArrow)) { z = -1f; }

    transform.Translate(x * speed * Time.deltaTime, 0, z * speed * Time.deltaTime);
  }
}
