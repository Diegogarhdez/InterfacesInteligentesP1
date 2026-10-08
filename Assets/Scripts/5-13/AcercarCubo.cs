using UnityEngine;

public class AcercarCubo : MonoBehaviour {
  public float speed = 5f;
  public Transform objetivoEsfera;

  void Update() {
    Vector3 direccion = objetivoEsfera.position - transform.position;
    direccion.y = 0;
    direccion = direccion.normalized;

    transform.Translate(direccion * speed * Time.deltaTime, Space.World);
  }
}
