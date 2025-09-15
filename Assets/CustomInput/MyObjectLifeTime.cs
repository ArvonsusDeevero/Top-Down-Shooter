using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class MyObjectLifeTime : MonoBehaviour
{
    public float lifeTime;
    public float blinkingDelay;
    public UnityEvent OnTimerReachedZero;

    private float timer;
    private SpriteRenderer spriteRenderer;
    private bool eventTriggered;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        timer = lifeTime;
        StartCoroutine(BlinkingRoutine());
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0 && !eventTriggered)
        {
            eventTriggered = true;
            OnTimerReachedZero?.Invoke();
        }
    }

    private IEnumerator BlinkingRoutine()
    {
        yield return new WaitForSeconds(lifeTime * 0.7f);

        Color defaultColor = spriteRenderer.color;
        Color blinkColor = defaultColor;
        blinkColor.a = 0.5f;

        while (timer > 0)
        {
            spriteRenderer.color = blinkColor;
            yield return new WaitForSeconds(blinkingDelay);

            spriteRenderer.color = defaultColor;
            yield return new WaitForSeconds(blinkingDelay);
        }
    }
}
