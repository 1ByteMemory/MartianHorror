using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connectors : MonoBehaviour
{
    public Mesh gizmoMesh;
    public Transform[] connectorList;


    public Transform GetPointWorldPos(int index)
	{
        return connectorList[index];
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

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
