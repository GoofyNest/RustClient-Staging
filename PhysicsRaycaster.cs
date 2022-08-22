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

	// RVA: 0x10C6F80 Offset: 0x10C5580 VA: 0x1810C6F80
	protected void .ctor() { }

	// RVA: 0x10C7950 Offset: 0x10C5F50 VA: 0x1810C7950 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x10C7890 Offset: 0x10C5E90 VA: 0x1810C7890 Slot: 22
	public virtual int get_depth() { }

	// RVA: 0x10C79F0 Offset: 0x10C5FF0 VA: 0x1810C79F0
	public int get_finalEventMask() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public LayerMask get_eventMask() { }

	// RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public int get_maxRayIntersections() { }

	// RVA: 0x10B82E0 Offset: 0x10B68E0 VA: 0x1810B82E0
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x10C6FB0 Offset: 0x10C55B0 VA: 0x1810C6FB0
	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref float distanceToClipPlane) { }

	// RVA: 0x10C7390 Offset: 0x10C5990 VA: 0x1810C7390 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

}

private class PhysicsRaycaster.RaycastHitComparer : IComparer<RaycastHit> // TypeDefIndex: 5094
{	// Fields
	public static PhysicsRaycaster.RaycastHitComparer instance; // 0x13803

	// Methods

	// RVA: 0x763E90 Offset: 0x762490 VA: 0x180763E90 Slot: 4
	public int Compare(RaycastHit x, RaycastHit y) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x10C9CA0 Offset: 0x10C82A0 VA: 0x1810C9CA0
	private static void .cctor() { }

}

