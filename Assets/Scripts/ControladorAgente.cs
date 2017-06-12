using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControladorAgente : MonoBehaviour {
	public enum Status{
		Parado,
		Andar
	};

	private NavMeshAgent _agente;
	public Status _status;
	public float _raio;

	// Use this for initialization
	void Start () {
		_agente = this.GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		switch (_status) {
		case Status.Parado:
			break;

		case Status.Andar:
			if(_agente.hasPath.Equals(false)){
				_agente.destination = new Vector3(this.transform.position.x+Random.Range(-_raio,_raio),
				                                  this.transform.position.y+Random.Range(-_raio,_raio),
				                                  this.transform.position.z+Random.Range(-_raio,_raio));
			}
			break;

		default:
			break;
		}
	}
}
