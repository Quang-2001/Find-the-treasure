using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float HorizontalInput;

    public float VerticalInput;

    public bool MouseButtonDown;

    public bool SpaceKeyDown;
    
    void Update()
    {
        if (!MouseButtonDown && Time.timeScale !=0)
        {
            MouseButtonDown = Input.GetMouseButtonDown(0);
        }

        if(!SpaceKeyDown && Time.deltaTime != 0)
        {
            SpaceKeyDown = Input.GetKeyDown(KeyCode.Space);
        }
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");
    }

    private void OnDisable()
    {
        ClearCache();
    }

    public void ClearCache()
    {
        SpaceKeyDown = false;
        MouseButtonDown = false;
        HorizontalInput = 0;
        VerticalInput = 0;
    }
}
