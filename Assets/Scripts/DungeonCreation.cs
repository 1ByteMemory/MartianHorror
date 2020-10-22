using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCreation : MonoBehaviour
{
    public GameObject[] Rooms;
    Connectors[] conectors;

	private void Start()
	{
		conectors = new Connectors[Rooms.Length];

		for (int i = 0; i < Rooms.Length; i++)
		{
			conectors[i] = Rooms[i].GetComponentInChildren<Connectors>();
		}
	}

	void GenerateDungeon(int numberOfRooms)
	{

	}
}
