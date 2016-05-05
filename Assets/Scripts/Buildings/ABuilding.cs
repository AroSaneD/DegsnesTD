using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Buildings
{
    public class ABuilding : MonoBehaviour, IBuilding
    {
        protected BoxCollider RangeCollider;

        void Start()
        {
            this.RangeCollider = GetComponent<BoxCollider>(); //Todo: Arunas figure out how to use multiple components of the same type.
        }
    }
}
