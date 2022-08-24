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
{	[ClientVar] // RVA: 0xC1D10 Offset: 0xC1110 VA: 0x1800C1D10
	[HelpAttribute] // RVA: 0xC1D10 Offset: 0xC1110 VA: 0x1800C1D10
	public static bool lerp; // 0x0
	[ServerVar] // RVA: 0xC1F00 Offset: 0xC1300 VA: 0x1800C1F00
	[HelpAttribute] // RVA: 0xC1F00 Offset: 0xC1300 VA: 0x1800C1F00
	public static bool damage; // 0x1
	[ServerVar] // RVA: 0xC1FE0 Offset: 0xC13E0 VA: 0x1800C1FE0
	[ClientVar] // RVA: 0xC1FE0 Offset: 0xC13E0 VA: 0x1800C1FE0
	[HelpAttribute] // RVA: 0xC1FE0 Offset: 0xC13E0 VA: 0x1800C1FE0
	public static bool attack; // 0x2
	[ServerVar] // RVA: 0xC21D0 Offset: 0xC15D0 VA: 0x1800C21D0
	[ClientVar] // RVA: 0xC21D0 Offset: 0xC15D0 VA: 0x1800C21D0
	[HelpAttribute] // RVA: 0xC21D0 Offset: 0xC15D0 VA: 0x1800C21D0
	public static bool protection; // 0x3
	[ServerVar] // RVA: 0xC2300 Offset: 0xC1700 VA: 0x1800C2300
	[HelpAttribute] // RVA: 0xC2300 Offset: 0xC1700 VA: 0x1800C2300
	public static bool weakspots; // 0x4
	[ServerVar] // RVA: 0xC2450 Offset: 0xC1850 VA: 0x1800C2450
	[HelpAttribute] // RVA: 0xC2450 Offset: 0xC1850 VA: 0x1800C2450
	public static bool triggers; // 0x5
	[ServerVar] // RVA: 0xC3860 Offset: 0xC2C60 VA: 0x1800C3860
	[HelpAttribute] // RVA: 0xC3860 Offset: 0xC2C60 VA: 0x1800C3860
	public static bool hitboxes; // 0x6
	[ServerVar] // RVA: 0xC39D0 Offset: 0xC2DD0 VA: 0x1800C39D0
	[HelpAttribute] // RVA: 0xC39D0 Offset: 0xC2DD0 VA: 0x1800C39D0
	public static bool lineofsight; // 0x7
	[ServerVar] // RVA: 0xC3AE0 Offset: 0xC2EE0 VA: 0x1800C3AE0
	[HelpAttribute] // RVA: 0xC3AE0 Offset: 0xC2EE0 VA: 0x1800C3AE0
	public static bool sense; // 0x8


	public void .ctor() { }

	private static void .cctor() { }

}

