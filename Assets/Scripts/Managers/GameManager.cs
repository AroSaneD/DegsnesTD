using Assets.Scripts.Movement;
using UnityEngine;

namespace Assets.Scripts.Managers
{
    public class GameManager : MonoBehaviour
    {
        //Todo: Make this class globally public and its instance reachable (singleton?)

        public GameObject StartPointPrefab;
        public GameObject EndPointPrefab;

        private StartPosition _startingPointObject;
        private EndPosition _endPointObject;

        //Mob types
        public Object BaseMob;
        //private Object BaseMob
        //{
        //    get
        //    {
        //        if (_baseMob == null)
        //        {
        //            //Todo: Look into how Resources.Load() works
        //            _baseMob = Resources.Load("Mob");
        //        }
        //        return _baseMob;
        //    }
        //}

        // Use this for initialization
        void Start () {
            this.PlaceStartPoint();
            this.PlaceEndPoint();
            
            //Todo: Spawn enemies at start point
            this.SpawnMob();
        }
	
        // Update is called once per frame
        void Update () {
	        //Todo: Check if any mobs are alive
        }

        #region Mob spawning

        private void SpawnMob()
        {
            Instantiate(this.BaseMob, this._startingPointObject.transform.position, Quaternion.identity);
        }

        #endregion


        #region point positioning and spawning

        private void PlaceStartPoint()
        {
            Vector3 startPoint = new Vector3(-20f, 1f, 0f);
            this._startingPointObject = ((GameObject)Instantiate(this.StartPointPrefab, startPoint, Quaternion.identity)).GetComponent<StartPosition>();
        }

        private void PlaceEndPoint()
        {
            Vector3 endPoint = new Vector3(20f, 1f, 0f);
            this._endPointObject = ((GameObject)Instantiate(this.EndPointPrefab, endPoint, Quaternion.identity)).GetComponent<EndPosition>();
        }

        #endregion
    }
}
