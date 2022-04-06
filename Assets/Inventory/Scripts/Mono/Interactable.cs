using System;
using UnityEngine;

namespace XEntity
{
    //The base class for all objects that the interactor can interact with.
    public abstract class Interactable : MonoBehaviour
    {
        //This method is called when the interactor attempts to interact with the object.
        //The passed in Interactor is the interactor that is attempting to interact.
        public virtual void OnInteract(Interactor interactor)
        {
            Debug.Log("Interacting...");
        }

        internal void OnDefocused()
        {
            throw new NotImplementedException();
        }

        internal void OnFocused(Transform transform)
        {
            throw new NotImplementedException();
        }
    }
}
