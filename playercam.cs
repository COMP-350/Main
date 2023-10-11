using UnityEngine;

public class playercam : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform player;
    private void Update() {
        //player follow only
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);

        //if we use scene to scene transitions instead of endless scrolling this camera would need a hitbox at end of scene to transition to next scene
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position,z), ref velocity, speed);
    }
    /*public void MoveScene(Transform _newScene) {
        currentPosX = _newScene.position.x;
    } again if we use scene transitions*/
}
