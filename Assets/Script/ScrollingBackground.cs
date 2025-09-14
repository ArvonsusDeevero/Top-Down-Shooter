using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    [Header("Scrolling Settings")]
    [SerializeField] private float speed = 2f;
    [SerializeField] private Transform[] backgrounds;

    private float backgroundHeight;
    private Vector3 scrollDirection;

    private void Start()
    {
        scrollDirection = Vector3.down;

        if (backgrounds.Length > 0)
        {
            SpriteRenderer renderer = backgrounds[0].GetComponent<SpriteRenderer>();
            if (renderer != null)
            {
                backgroundHeight = renderer.bounds.size.y;
            }
            else
            {
                Debug.LogWarning("Tidak ada SpriteRenderer, gunakan default height 10");
                backgroundHeight = 10f;
            }
        }
    }

    private void Update()
    {
        ScrollBackgrounds();
        CheckAndResetPositions();
    }

    private void ScrollBackgrounds()
    {
        Vector3 movement = scrollDirection * speed * Time.deltaTime;

        foreach (Transform bg in backgrounds)
        {
            bg.position += movement;
        }
    }

    private void CheckAndResetPositions()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            if (backgrounds[i].position.y <= -backgroundHeight)
            {
                MoveToTop(i);
            }
        }
    }

    private void MoveToTop(int index)
    {
        int otherIndex = (index == 0) ? 1 : 0;
        float topY = backgrounds[otherIndex].position.y + backgroundHeight;

        backgrounds[index].position = new Vector3(
            backgrounds[index].position.x,
            topY,
            backgrounds[index].position.z
        );
    }
}