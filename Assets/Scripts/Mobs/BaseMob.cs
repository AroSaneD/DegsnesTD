using UnityEngine;

namespace Assets.Scripts.Mobs
{
    public class BaseMob : MonoBehaviour
    {

        protected NavMeshAgent NavMeshAgent;
        protected Rigidbody Rigidbody;

        // Use this for initialization
        void Start ()
        {
            this.NavMeshAgent = this.GetComponent<NavMeshAgent>();
        }
	
        // Update is called once per frame
        void Update () {
	        this.NavMeshAgent.Move(new Vector3(20, 1, 0) * Time.deltaTime * 0.5f);
            //this.NavMeshAgent.Move();
            //Todo: Get the end position from the game manager
        }
    }
}
