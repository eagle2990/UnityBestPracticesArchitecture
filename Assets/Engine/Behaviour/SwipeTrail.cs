using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

[RequireComponent(typeof(TrailRenderer))]
public class SwipeTrail : MonoBehaviour
{
	[SerializeField]
	private List<Vector3> positions;
	private int totalPoints;
	private int savedPositionsCounter;
	private TrailRenderer trailRenderer;

	private void Start()
	{
		trailRenderer = GetComponent<TrailRenderer>();
		savedPositionsCounter = 0;
	}

	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			Plane objPlane = new Plane(Camera.main.transform.forward * -1, this.transform.position);
			Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			float rayDistance;
			if (objPlane.Raycast(mRay, out rayDistance))
				this.transform.position = mRay.GetPoint(rayDistance);
		}

		if (Input.GetMouseButtonUp(0))
		{
			totalPoints = trailRenderer.positionCount;
			while (savedPositionsCounter < totalPoints)
			{
				positions.Add(trailRenderer.GetPosition(savedPositionsCounter));
				savedPositionsCounter++;
			}
		}
	}
}
