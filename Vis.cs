public static class Vis // TypeDefIndex: 10054
{	private static int colCount; // 0x0
	private static Collider[] colBuffer; // 0x8


	private static void Buffer(Vector3 position, float radius, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }

	public static bool AnyColliders(Vector3 position, float radius, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 1) { }

	public static void Colliders<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Colliders<object>
	|-Vis.Colliders<Collider>
	*/

	public static void Components<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Components<object>
	|-Vis.Components<Rigidbody>
	|-Vis.Components<WaterVolume>
	*/

	public static void Entities<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Entities<BaseEntity>
	|-Vis.Entities<BasePlayer>
	|-Vis.Entities<BaseVehicle>
	|-Vis.Entities<BuildingBlock>
	|-Vis.Entities<CollectableEasterEgg>
	|-Vis.Entities<DroppedItem>
	|-Vis.Entities<GraveyardFence>
	|-Vis.Entities<IOEntity>
	|-Vis.Entities<SleepingBag>
	|-Vis.Entities<object>
	*/

	public static void EntityComponents<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.EntityComponents<object>
	*/

	private static void Buffer(OBB bounds, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }

	public static void Colliders<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Colliders<object>
	*/

	public static void Components<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Components<object>
	*/

	public static void Entities<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Entities<object>
	*/

	public static void EntityComponents<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.EntityComponents<object>
	*/

	private static void Buffer(Vector3 startPosition, Vector3 endPosition, float radius, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }

	public static void Entities<T>(Vector3 startPosition, Vector3 endPosition, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Entities<object>
	*/

	private static void .cctor() { }

}

public class Vis : ConsoleSystem // TypeDefIndex: 11977
{	[ClientVar] // RVA: 0xC2160 Offset: 0xC1560 VA: 0x1800C2160
	[HelpAttribute] // RVA: 0xC2160 Offset: 0xC1560 VA: 0x1800C2160
	public static bool lerp; // 0x0
	[ServerVar] // RVA: 0xC3680 Offset: 0xC2A80 VA: 0x1800C3680
	[HelpAttribute] // RVA: 0xC3680 Offset: 0xC2A80 VA: 0x1800C3680
	public static bool damage; // 0x1
	[ServerVar] // RVA: 0xC3750 Offset: 0xC2B50 VA: 0x1800C3750
	[ClientVar] // RVA: 0xC3750 Offset: 0xC2B50 VA: 0x1800C3750
	[HelpAttribute] // RVA: 0xC3750 Offset: 0xC2B50 VA: 0x1800C3750
	public static bool attack; // 0x2
	[ServerVar] // RVA: 0xC3910 Offset: 0xC2D10 VA: 0x1800C3910
	[ClientVar] // RVA: 0xC3910 Offset: 0xC2D10 VA: 0x1800C3910
	[HelpAttribute] // RVA: 0xC3910 Offset: 0xC2D10 VA: 0x1800C3910
	public static bool protection; // 0x3
	[ServerVar] // RVA: 0xC3B30 Offset: 0xC2F30 VA: 0x1800C3B30
	[HelpAttribute] // RVA: 0xC3B30 Offset: 0xC2F30 VA: 0x1800C3B30
	public static bool weakspots; // 0x4
	[ServerVar] // RVA: 0xC4FA0 Offset: 0xC43A0 VA: 0x1800C4FA0
	[HelpAttribute] // RVA: 0xC4FA0 Offset: 0xC43A0 VA: 0x1800C4FA0
	public static bool triggers; // 0x5
	[ServerVar] // RVA: 0xC50E0 Offset: 0xC44E0 VA: 0x1800C50E0
	[HelpAttribute] // RVA: 0xC50E0 Offset: 0xC44E0 VA: 0x1800C50E0
	public static bool hitboxes; // 0x6
	[ServerVar] // RVA: 0xC52A0 Offset: 0xC46A0 VA: 0x1800C52A0
	[HelpAttribute] // RVA: 0xC52A0 Offset: 0xC46A0 VA: 0x1800C52A0
	public static bool lineofsight; // 0x7
	[ServerVar] // RVA: 0xC52E0 Offset: 0xC46E0 VA: 0x1800C52E0
	[HelpAttribute] // RVA: 0xC52E0 Offset: 0xC46E0 VA: 0x1800C52E0
	public static bool sense; // 0x8


	public void .ctor() { }

	private static void .cctor() { }

}

