using System.Collections;
using UnityEngine;

public class Lightshow : MonoBehaviour
{
    private const float AngularVelocityPerSecond = Mathf.PI;

    private void Update()
    {
        // Move our lights around a bit each frame
        float dA = Time.deltaTime * AngularVelocityPerSecond;

        foreach (var light in gameObject.GetComponentsInChildren<Light>())
        {
            Vector3 P = light.transform.localPosition;
            float R = P.magnitude;
            float A = Mathf.Atan2(P.y, P.x);

            A += dA;
            P.x = R * Mathf.Cos(A);
            P.y = R * Mathf.Sin(A);

            light.transform.localPosition = P;
        }
    }
}
