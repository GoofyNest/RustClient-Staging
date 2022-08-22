public class BasePathFinder // TypeDefIndex: 8966
{	// Fields
	private static Vector3[] preferedTopologySamples; // 0x0
	private static Vector3[] topologySamples; // 0x8
	private Vector3 chosenPosition; // 0x10
	private const float halfPI = 0,01745329;

	// Methods

	// RVA: 0xA52840 Offset: 0xA50E40 VA: 0x180A52840 Slot: 4
	public virtual Vector3 GetRandomPatrolPoint() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public virtual AIMovePoint GetBestRoamPoint(Vector3 anchorPos, Vector3 currentPos, Vector3 currentDirection, float anchorClampDistance, float lookupMaxRange = 20) { }

	// RVA: 0xA525E0 Offset: 0xA50BE0 VA: 0x180A525E0
	public void DebugDraw() { }

	// RVA: 0xA528B0 Offset: 0xA50EB0 VA: 0x180A528B0 Slot: 6
	public virtual Vector3 GetRandomPositionAround(Vector3 position, float minDistFrom = 0, float maxDistFrom = 2) { }

	// RVA: 0xA52750 Offset: 0xA50D50 VA: 0x180A52750
	public static Vector3 GetPointOnCircle(Vector3 center, float radius, float degrees) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA52AB0 Offset: 0xA510B0 VA: 0x180A52AB0
	private static void .cctor() { }

}

