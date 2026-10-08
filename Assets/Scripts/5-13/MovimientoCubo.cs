using UnityEngine;

public class MovimientoCubo : MonoBehaviour {
  public Vector3 moveDirection;
  public float speed;

  public bool usarSistemaMundial = false;

  void Start() {
    transform.position = new Vector3(transform.position.x, 0, transform.position.z);
  }

  void Update() {
    float x = moveDirection.x * speed;
    float y = moveDirection.y * speed;
    float z = moveDirection.z * speed;

    if (usarSistemaMundial) {
      transform.Translate(x, y, z, Space.World);
    }
    else {
      transform.Translate(x, y, z, Space.Self);
    }
  }
}
