public class BasePathFinder // TypeDefIndex: 8966
{	// Fields
	private static Vector3[] preferedTopologySamples; // 0x0
	private static Vector3[] topologySamples; // 0x8
	private Vector3 chosenPosition; // 0x10
	private const float halfPI = 0,01745329;

	// Methods

	// RVA: 0xA52370 Offset: 0xA50970 VA: 0x180A52370 Slot: 4
	public virtual Vector3 GetRandomPatrolPoint() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public virtual AIMovePoint GetBestRoamPoint(Vector3 anchorPos, Vector3 currentPos, Vector3 currentDirection, float anchorClampDistance, float lookupMaxRange = 20) { }

	// RVA: 0xA52110 Offset: 0xA50710 VA: 0x180A52110
	public void DebugDraw() { }

	// RVA: 0xA523E0 Offset: 0xA509E0 VA: 0x180A523E0 Slot: 6
	public virtual Vector3 GetRandomPositionAround(Vector3 position, float minDistFrom = 0, float maxDistFrom = 2) { }

	// RVA: 0xA52280 Offset: 0xA50880 VA: 0x180A52280
	public static Vector3 GetPointOnCircle(Vector3 center, float radius, float degrees) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA525E0 Offset: 0xA50BE0 VA: 0x180A525E0
	private static void .cctor() { }

}

