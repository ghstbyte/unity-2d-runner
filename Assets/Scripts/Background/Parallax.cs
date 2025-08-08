using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Parallax : MonoBehaviour 
{
    private float startPosX, lenght;
    public GameObject cam;
    public float parallaxEffect;
    private void Start() {
        startPosX = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    private void FixedUpdate() {
        float distanceX = cam.transform.position.x * parallaxEffect;
        float movement = cam.transform.position.x * (1 - parallaxEffect);

        transform.position = new Vector3 (startPosX + distanceX, transform.position.y, transform.position.z);

        if (movement > startPosX + lenght) { 
            startPosX += lenght;
        } 
        else if (movement < startPosX - lenght) 
        {
            startPosX -= lenght;
        }
    }

}
