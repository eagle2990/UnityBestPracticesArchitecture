using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailManager : MonoBehaviour
{

	public GameObject trailPrefab;
	GameObject thisTrail;
	Vector3 startPos;
	Plane plane;
	List<GameObject> trails;

	// Use this for initialization
	void Start()
	{
		plane = new Plane(Camera.main.transform.forward * -1, this.transform.position);
		trails = new List<GameObject>();
		startPos = Vector3.zero;
		thisTrail = null;
	}

	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			if (thisTrail == null)
			{
				thisTrail = (GameObject)Instantiate(trailPrefab,
												this.transform.position,
												Quaternion.identity);
			}

			Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			float rayDistance;
			if (plane.Raycast(mRay, out rayDistance))
			{
				thisTrail.transform.position = mRay.GetPoint(rayDistance);
				if (startPos == Vector3.zero)
				{
					startPos = thisTrail.transform.position;
				}

				
			}
		}

		if (Input.GetMouseButtonUp(0))
		{
			if (Vector3.Distance(thisTrail.transform.position, startPos) < 0.1f)
			{
				Destroy(thisTrail);
			}
			else
			{
				startPos = Vector3.zero;
				trails.Add(thisTrail);
				thisTrail = null;
			}
		}
	}
}
