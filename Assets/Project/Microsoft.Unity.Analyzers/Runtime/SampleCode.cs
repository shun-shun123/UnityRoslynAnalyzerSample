using UnityEngine;

namespace Project.Microsoft.Unity.Analyzers.Runtime
{
    public class SampleCode : MonoBehaviour
    {
        [SerializeField]
        private Transform target;
        
        void Start()
        {
        }

        void Update()
        {
            var foo = Time.fixedDeltaTime;
            var message = target != null ? "not null" : "null";
        }
    }
}
