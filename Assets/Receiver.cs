using System;
using System.Linq;
using UnityEngine;

public abstract class Receiver : MonoBehaviour
{
    protected GameObject target;

    void Start()
    {
        foreach (var transmitter in
            FindObjectsOfType<Transmitter>()
            .Select(o => o.GetComponent<Transmitter>()))
        {
            transmitter.TransmissionChanged += Transmitter_TransmissionChanged;
        }
    }

    void Transmitter_TransmissionChanged(object sender, EventArgs e)
    {
        Transmitter_TransmissionChanged((Transmitter)sender, e);
    }

    protected abstract void Transmitter_TransmissionChanged(Transmitter sender, EventArgs e);

    void Update()
    {
        InteractWithTarget();
    }

    protected abstract void InteractWithTarget();
}
