using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connectors : MonoBehaviour
{
    public Mesh gizmoMesh;
    public Transform[] connectorList;

    public int maxRoooms = 2;
    public static int rooms = 0;


    public Transform GetPointWorldPos(int index)
	{
        return connectorList[index];
	}

    public void MakeConnectionTo(Transform room, Transform fromConnector, Transform toConnector)
	{
        room.position = fromConnector.position + toConnector.localPosition;

	}


	private void OnDrawGizmos()
	{
		for (int i = 0; i < connectorList.Length; i++)
		{
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(connectorList[i].position, 0.25f);

            Vector3 pos = connectorList[i].position + (connectorList[i].forward * 0.5f);
            Vector3 size = new Vector3(0.1f, 0.1f, 1);

            if (gizmoMesh != null)
                Gizmos.DrawMesh(gizmoMesh, pos, Quaternion.LookRotation(connectorList[i].forward), size);

		}
	}

}
