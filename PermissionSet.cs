public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback // TypeDefIndex: 902
{	// Fields
	private static object[] psUnrestricted; // 0x0
	private PermissionState state; // 0x10
	private ArrayList list; // 0x18
	private bool _declsec; // 0x20
	private bool[] _ignored; // 0x28
	private static object[] action; // 0x8

	// Properties
	public virtual int Count { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x17B6650 Offset: 0x17B4C50 VA: 0x1817B6650
	internal void .ctor() { }

	// RVA: 0x17B65D0 Offset: 0x17B4BD0 VA: 0x1817B65D0
	public void .ctor(PermissionState state) { }

	// RVA: 0x17B66C0 Offset: 0x17B4CC0 VA: 0x1817B66C0
	internal void .ctor(IPermission perm) { }

	// RVA: 0x17B5830 Offset: 0x17B3E30 VA: 0x1817B5830 Slot: 10
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x17B5990 Offset: 0x17B3F90 VA: 0x1817B5990 Slot: 11
	public void Demand() { }

	// RVA: 0x17B57B0 Offset: 0x17B3DB0 VA: 0x1817B57B0
	internal void CasOnlyDemand(int skip) { }

	// RVA: 0x17B5D50 Offset: 0x17B4350 VA: 0x1817B5D50 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x17B5DD0 Offset: 0x17B43D0 VA: 0x1817B5DD0
	public bool IsEmpty() { }

	// RVA: 0x17B6040 Offset: 0x17B4640 VA: 0x1817B6040
	public bool IsUnrestricted() { }

	// RVA: 0x17B6050 Offset: 0x17B4650 VA: 0x1817B6050 Slot: 3
	public override string ToString() { }

	// RVA: 0x17B6090 Offset: 0x17B4690 VA: 0x1817B6090 Slot: 12
	public virtual SecurityElement ToXml() { }

	// RVA: 0x1521990 Offset: 0x151FF90 VA: 0x181521990 Slot: 13
	public virtual int get_Count() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 14
	public virtual object get_SyncRoot() { }

	[MonoTODOAttribute] // RVA: 0xC1A40 Offset: 0xC0E40 VA: 0x1800C1A40
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17B5B90 Offset: 0x17B4190 VA: 0x1817B5B90 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17B5D80 Offset: 0x17B4380 VA: 0x1817B5D80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17B6450 Offset: 0x17B4A50 VA: 0x1817B6450
	private static void .cctor() { }

}

