public class DeliveryDroneConfig : BaseScriptableObject // TypeDefIndex: 8800
{	// Fields
	public Vector3 vendingMachineOffset; // 0x20
	public float maxDistanceFromVendingMachine; // 0x2C
	public Vector3 halfExtents; // 0x30
	public float testHeight; // 0x3C
	public LayerMask layerMask; // 0x40

	// Methods

	// RVA: 0x84C170 Offset: 0x84A770 VA: 0x18084C170
	public void FindDescentPoints(VendingMachine vendingMachine, float currentY, out Vector3 waitPosition, out Vector3 descendPosition) { }

	// RVA: 0x84C600 Offset: 0x84AC00 VA: 0x18084C600
	public bool IsVendingMachineAccessible(VendingMachine vendingMachine, Vector3 offset, out RaycastHit hitInfo) { }

	// RVA: 0x84C880 Offset: 0x84AE80 VA: 0x18084C880
	public void .ctor() { }

}

