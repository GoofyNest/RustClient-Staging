public class TreeMarkerData : PrefabAttribute, IServerComponent // TypeDefIndex: 11429
{
	public TreeMarkerData.GenerationArc[] GenerationArcs;
	public TreeMarkerData.MarkerLocation[] Markers;
	public Vector3 GenerationStartPoint;
	public float GenerationRadius;
	public float MaxY;
	public float MinY;
	public bool ProcessAngleChecks;


	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

public struct TreeMarkerData.MarkerLocation // TypeDefIndex: 11430
{
	public Vector3 LocalPosition;
	public Vector3 LocalNormal;

}

public struct TreeMarkerData.GenerationArc // TypeDefIndex: 11431
{
	public Vector3 CentrePoint;
	public float Radius;
	public Vector3 Rotation;
	public int OverrideCount;

}

