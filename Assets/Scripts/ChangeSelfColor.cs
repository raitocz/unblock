using UnityEngine;
using System.Collections;

public class ChangeSelfColor : MonoBehaviour
{

    public float colorDuration = 100;

    public Gradient gradient;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float t = Mathf.Repeat(Time.time, colorDuration) / colorDuration;

        this.GetComponent<SpriteRenderer>().color = gradient.Evaluate(t);

        if (this.GetComponent<ParticleSystem>() != null)
        {
            ParticleSystem ps = GetComponent<ParticleSystem>();
            ps.startColor = gradient.Evaluate(t);
        }
    }
}
