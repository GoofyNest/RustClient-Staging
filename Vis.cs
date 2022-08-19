public static class Vis // TypeDefIndex: 10054
{	// Fields
	private static int colCount; // 0x0
	private static Collider[] colBuffer; // 0x8

	// Methods

	// RVA: 0x7FD760 Offset: 0x7FBD60 VA: 0x1807FD760
	private static void Buffer(Vector3 position, float radius, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }

	// RVA: 0x7FD1C0 Offset: 0x7FB7C0 VA: 0x1807FD1C0
	public static bool AnyColliders(Vector3 position, float radius, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: -1 Offset: -1
	public static void Colliders<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D90D0 Offset: 0x5D76D0 VA: 0x1805D90D0
	|-Vis.Colliders<object>
	|-Vis.Colliders<Collider>
	*/

	// RVA: -1 Offset: -1
	public static void Components<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D9510 Offset: 0x5D7B10 VA: 0x1805D9510
	|-Vis.Components<object>
	|-Vis.Components<Rigidbody>
	|-Vis.Components<WaterVolume>
	*/

	// RVA: -1 Offset: -1
	public static void Entities<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D9C20 Offset: 0x5D8220 VA: 0x1805D9C20
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

	// RVA: -1 Offset: -1
	public static void EntityComponents<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D9E50 Offset: 0x5D8450 VA: 0x1805D9E50
	|-Vis.EntityComponents<object>
	*/

	// RVA: 0x7FD4C0 Offset: 0x7FBAC0 VA: 0x1807FD4C0
	private static void Buffer(OBB bounds, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }

	// RVA: -1 Offset: -1
	public static void Colliders<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D8EA0 Offset: 0x5D74A0 VA: 0x1805D8EA0
	|-Vis.Colliders<object>
	*/

	// RVA: -1 Offset: -1
	public static void Components<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D9300 Offset: 0x5D7900 VA: 0x1805D9300
	|-Vis.Components<object>
	*/

	// RVA: -1 Offset: -1
	public static void Entities<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D9700 Offset: 0x5D7D00 VA: 0x1805D9700
	|-Vis.Entities<object>
	*/

	// RVA: -1 Offset: -1
	public static void EntityComponents<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5DA090 Offset: 0x5D8690 VA: 0x1805DA090
	|-Vis.EntityComponents<object>
	*/

	// RVA: 0x7FD270 Offset: 0x7FB870 VA: 0x1807FD270
	private static void Buffer(Vector3 startPosition, Vector3 endPosition, float radius, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }

	// RVA: -1 Offset: -1
	public static void Entities<T>(Vector3 startPosition, Vector3 endPosition, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D9980 Offset: 0x5D7F80 VA: 0x1805D9980
	|-Vis.Entities<object>
	*/

	// RVA: 0x7FD9B0 Offset: 0x7FBFB0 VA: 0x1807FD9B0
	private static void .cctor() { }

}

public class Vis : ConsoleSystem // TypeDefIndex: 11973
{	// Fields
	[ClientVar] // RVA: 0xC1DF0 Offset: 0xC11F0 VA: 0x1800C1DF0
	[HelpAttribute] // RVA: 0xC1DF0 Offset: 0xC11F0 VA: 0x1800C1DF0
	public static bool lerp; // 0x0
	[ServerVar] // RVA: 0xC1FE0 Offset: 0xC13E0 VA: 0x1800C1FE0
	[HelpAttribute] // RVA: 0xC1FE0 Offset: 0xC13E0 VA: 0x1800C1FE0
	public static bool damage; // 0x1
	[ServerVar] // RVA: 0xC2080 Offset: 0xC1480 VA: 0x1800C2080
	[ClientVar] // RVA: 0xC2080 Offset: 0xC1480 VA: 0x1800C2080
	[HelpAttribute] // RVA: 0xC2080 Offset: 0xC1480 VA: 0x1800C2080
	public static bool attack; // 0x2
	[ServerVar] // RVA: 0xC3570 Offset: 0xC2970 VA: 0x1800C3570
	[ClientVar] // RVA: 0xC3570 Offset: 0xC2970 VA: 0x1800C3570
	[HelpAttribute] // RVA: 0xC3570 Offset: 0xC2970 VA: 0x1800C3570
	public static bool protection; // 0x3
	[ServerVar] // RVA: 0xC3760 Offset: 0xC2B60 VA: 0x1800C3760
	[HelpAttribute] // RVA: 0xC3760 Offset: 0xC2B60 VA: 0x1800C3760
	public static bool weakspots; // 0x4
	[ServerVar] // RVA: 0xC38D0 Offset: 0xC2CD0 VA: 0x1800C38D0
	[HelpAttribute] // RVA: 0xC38D0 Offset: 0xC2CD0 VA: 0x1800C38D0
	public static bool triggers; // 0x5
	[ServerVar] // RVA: 0xC3AA0 Offset: 0xC2EA0 VA: 0x1800C3AA0
	[HelpAttribute] // RVA: 0xC3AA0 Offset: 0xC2EA0 VA: 0x1800C3AA0
	public static bool hitboxes; // 0x6
	[ServerVar] // RVA: 0xC4F00 Offset: 0xC4300 VA: 0x1800C4F00
	[HelpAttribute] // RVA: 0xC4F00 Offset: 0xC4300 VA: 0x1800C4F00
	public static bool lineofsight; // 0x7
	[ServerVar] // RVA: 0xC4FE0 Offset: 0xC43E0 VA: 0x1800C4FE0
	[HelpAttribute] // RVA: 0xC4FE0 Offset: 0xC43E0 VA: 0x1800C4FE0
	public static bool sense; // 0x8

	// Methods

	// RVA: 0x36D790 Offset: 0x36BD90 VA: 0x18036D790
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

