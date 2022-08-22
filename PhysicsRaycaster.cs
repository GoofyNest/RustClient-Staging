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

	// RVA: 0x10C79F0 Offset: 0x10C5FF0 VA: 0x1810C79F0
	protected void .ctor() { }

	// RVA: 0x10C83C0 Offset: 0x10C69C0 VA: 0x1810C83C0 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x10C8300 Offset: 0x10C6900 VA: 0x1810C8300 Slot: 22
	public virtual int get_depth() { }

	// RVA: 0x10C8460 Offset: 0x10C6A60 VA: 0x1810C8460
	public int get_finalEventMask() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public LayerMask get_eventMask() { }

	// RVA: 0x79C680 Offset: 0x79AC80 VA: 0x18079C680
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x5DE340 Offset: 0x5DC940 VA: 0x1805DE340
	public int get_maxRayIntersections() { }

	// RVA: 0x10B8D50 Offset: 0x10B7350 VA: 0x1810B8D50
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x10C7A20 Offset: 0x10C6020 VA: 0x1810C7A20
	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref float distanceToClipPlane) { }

	// RVA: 0x10C7E00 Offset: 0x10C6400 VA: 0x1810C7E00 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

}

private class PhysicsRaycaster.RaycastHitComparer : IComparer<RaycastHit> // TypeDefIndex: 5094
{	// Fields
	public static PhysicsRaycaster.RaycastHitComparer instance; // 0x135E0

	// Methods

	// RVA: 0x763DE0 Offset: 0x7623E0 VA: 0x180763DE0 Slot: 4
	public int Compare(RaycastHit x, RaycastHit y) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x10CA710 Offset: 0x10C8D10 VA: 0x1810CA710
	private static void .cctor() { }

}

