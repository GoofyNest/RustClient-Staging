public class BasePathFinder // TypeDefIndex: 8966
{	// Fields
	private static Vector3[] preferedTopologySamples; // 0x0
	private static Vector3[] topologySamples; // 0x8
	private Vector3 chosenPosition; // 0x10
	private const float halfPI = 0,01745329;

	// Methods

	// RVA: 0xA520B0 Offset: 0xA506B0 VA: 0x180A520B0 Slot: 4
	public virtual Vector3 GetRandomPatrolPoint() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public virtual AIMovePoint GetBestRoamPoint(Vector3 anchorPos, Vector3 currentPos, Vector3 currentDirection, float anchorClampDistance, float lookupMaxRange = 20) { }

	// RVA: 0xA51E50 Offset: 0xA50450 VA: 0x180A51E50
	public void DebugDraw() { }

	// RVA: 0xA52120 Offset: 0xA50720 VA: 0x180A52120 Slot: 6
	public virtual Vector3 GetRandomPositionAround(Vector3 position, float minDistFrom = 0, float maxDistFrom = 2) { }

	// RVA: 0xA51FC0 Offset: 0xA505C0 VA: 0x180A51FC0
	public static Vector3 GetPointOnCircle(Vector3 center, float radius, float degrees) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA52320 Offset: 0xA50920 VA: 0x180A52320
	private static void .cctor() { }

}

