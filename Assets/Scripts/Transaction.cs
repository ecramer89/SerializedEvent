using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Transaction: MonoBehaviour  {

	private IEnumerator<Action> dispatch;
	private Queue<SerializedEvent> events=new Queue<SerializedEvent>();

	private static Transaction instance;
	public static Transaction Instance{
		get {
			return instance;

		}
	}


	public void EnqueueEvent(SerializedEvent evt){
		events.Enqueue(evt);

	}

	public void Awake(){
		instance = this;
        GameObject.DontDestroyOnLoad(gameObject);
	}


	public void Update(){

		if(dispatch != null && dispatch.MoveNext()){
			do{
				dispatch.Current();
			}while(dispatch.MoveNext());

			return;
		}

		if(events.Count > 0){
			List<Action> subscribers = events.Dequeue().Subscribers();
			dispatch = subscribers.GetEnumerator();

		}

	}


}






