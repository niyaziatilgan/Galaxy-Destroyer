using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float controlSpeed = 50f;
    [SerializeField] float xClampRange = 35f;
    [SerializeField] float yClampRange = 20f;
    Vector2 movement;

    void Update()
    {
        //transform.rotation = Quaternion.identity;
        ProcessTranslation();
    }

    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    private void ProcessTranslation()
    {
        float xOffset = movement.x * controlSpeed * Time.deltaTime;
        float rawXPos = transform.localPosition.x + xOffset;
        float clampedXPos = Mathf.Clamp(rawXPos, -xClampRange, xClampRange);

        float yOffset = movement.y * controlSpeed * Time.deltaTime;
        float rawYPos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawYPos, -yClampRange, yClampRange);



        //float xOffset = movement.x * controlSpeed * Time.deltaTime;
        //float yOffset = movement.y * controlSpeed * Time.deltaTime;
        //float clampedXPos = Mathf.Clamp(xOffset, -xClampRange, xClampRange);
        //float clampedYPos = Mathf.Clamp(yOffset, -yClampRange, yClampRange);

        //transform.position += new Vector3(clampedXPos, clampedYPos, 0f);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, transform.localPosition.z);
    }

}
