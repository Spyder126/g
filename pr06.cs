using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class shake : MonoBehaviour
{
public float power = 0.7f;
public float duration = 1.0f;
public Transform cameraTransform;
public float slowDownAmount = 1.0f;
Vector3 startPosition;
public bool Shake = false;
float initialDuration;
// Start is called before the first frame update
void Start()
{
cameraTransform = Camera.main.transform;
startPosition = cameraTransform.localPosition;
initialDuration = duration;
}
// Update is called once per frame
void Update()
{
if (Shake)
{
if (duration > 0)
{
cameraTransform.localPosition = startPosition + Random.insideUnitSphere * power;
duration -= Time.deltaTime * slowDownAmount;
}
else
{
Shake = false;
duration = initialDuration;
cameraTransform.localPosition = startPosition;
}
}
}
public void StartShake()
{
Shake = true;
}
}