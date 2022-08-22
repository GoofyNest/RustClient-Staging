public class TreeMarkerData : PrefabAttribute, IServerComponent // TypeDefIndex: 9678
{	// Fields
	public TreeMarkerData.GenerationArc[] GenerationArcs; // 0x98
	public TreeMarkerData.MarkerLocation[] Markers; // 0xA0
	public Vector3 GenerationStartPoint; // 0xA8
	public float GenerationRadius; // 0xB4
	public float MaxY; // 0xB8
	public float MinY; // 0xBC
	public bool ProcessAngleChecks; // 0xC0

	// Methods

	// RVA: 0xA1EDC0 Offset: 0xA1D3C0 VA: 0x180A1EDC0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0xA1EE20 Offset: 0xA1D420 VA: 0x180A1EE20
	public void .ctor() { }

}

public struct TreeMarkerData.MarkerLocation // TypeDefIndex: 9679
{	// Fields
	public Vector3 LocalPosition; // 0x0
	public Vector3 LocalNormal; // 0xC

}

public struct TreeMarkerData.GenerationArc // TypeDefIndex: 9680
{	// Fields
	public Vector3 CentrePoint; // 0x0
	public float Radius; // 0xC
	public Vector3 Rotation; // 0x10
	public int OverrideCount; // 0x1C

}

