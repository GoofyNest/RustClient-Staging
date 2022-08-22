public class DeliveryDroneConfig : BaseScriptableObject // TypeDefIndex: 8800
{	// Fields
	public Vector3 vendingMachineOffset; // 0x20
	public float maxDistanceFromVendingMachine; // 0x2C
	public Vector3 halfExtents; // 0x30
	public float testHeight; // 0x3C
	public LayerMask layerMask; // 0x40

	// Methods

	// RVA: 0x84C7D0 Offset: 0x84ADD0 VA: 0x18084C7D0
	public void FindDescentPoints(VendingMachine vendingMachine, float currentY, out Vector3 waitPosition, out Vector3 descendPosition) { }

	// RVA: 0x84CC60 Offset: 0x84B260 VA: 0x18084CC60
	public bool IsVendingMachineAccessible(VendingMachine vendingMachine, Vector3 offset, out RaycastHit hitInfo) { }

	// RVA: 0x84CEE0 Offset: 0x84B4E0 VA: 0x18084CEE0
	public void .ctor() { }

}

