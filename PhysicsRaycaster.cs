public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 5093
{	// Fields
	protected const int kNoEventMaskSet = -1;
	protected Camera m_EventCamera; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected LayerMask m_EventMask; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected int m_MaxRayIntersections; // 0x2C
	protected int m_LastMaxRayIntersections; // 0x30
	private RaycastHit[] m_Hits; // 0x38

	// Properties
	public override Camera eventCamera { get; }
	public virtual int depth { get; }
	public int finalEventMask { get; }
	public LayerMask eventMask { get; set; }
	public int maxRayIntersections { get; set; }

	// Methods

	// RVA: 0x10C6CC0 Offset: 0x10C52C0 VA: 0x1810C6CC0
	protected void .ctor() { }

	// RVA: 0x10C7690 Offset: 0x10C5C90 VA: 0x1810C7690 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x10C75D0 Offset: 0x10C5BD0 VA: 0x1810C75D0 Slot: 22
	public virtual int get_depth() { }

	// RVA: 0x10C7730 Offset: 0x10C5D30 VA: 0x1810C7730
	public int get_finalEventMask() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public LayerMask get_eventMask() { }

	// RVA: 0x7D0C50 Offset: 0x7CF250 VA: 0x1807D0C50
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public int get_maxRayIntersections() { }

	// RVA: 0x10B8020 Offset: 0x10B6620 VA: 0x1810B8020
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x10C6CF0 Offset: 0x10C52F0 VA: 0x1810C6CF0
	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref float distanceToClipPlane) { }

	// RVA: 0x10C70D0 Offset: 0x10C56D0 VA: 0x1810C70D0 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

}

private class PhysicsRaycaster.RaycastHitComparer : IComparer<RaycastHit> // TypeDefIndex: 5094
{	// Fields
	public static PhysicsRaycaster.RaycastHitComparer instance; // 0x13803

	// Methods

	// RVA: 0x763D80 Offset: 0x762380 VA: 0x180763D80 Slot: 4
	public int Compare(RaycastHit x, RaycastHit y) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x10C99E0 Offset: 0x10C7FE0 VA: 0x1810C99E0
	private static void .cctor() { }

}

