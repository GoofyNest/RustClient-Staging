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

	// RVA: 0x17B41A0 Offset: 0x17B27A0 VA: 0x1817B41A0
	internal void .ctor() { }

	// RVA: 0x17B4120 Offset: 0x17B2720 VA: 0x1817B4120
	public void .ctor(PermissionState state) { }

	// RVA: 0x17B4210 Offset: 0x17B2810 VA: 0x1817B4210
	internal void .ctor(IPermission perm) { }

	// RVA: 0x17B3380 Offset: 0x17B1980 VA: 0x1817B3380 Slot: 10
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x17B34E0 Offset: 0x17B1AE0 VA: 0x1817B34E0 Slot: 11
	public void Demand() { }

	// RVA: 0x17B3300 Offset: 0x17B1900 VA: 0x1817B3300
	internal void CasOnlyDemand(int skip) { }

	// RVA: 0x17B38A0 Offset: 0x17B1EA0 VA: 0x1817B38A0 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x17B3920 Offset: 0x17B1F20 VA: 0x1817B3920
	public bool IsEmpty() { }

	// RVA: 0x17B3B90 Offset: 0x17B2190 VA: 0x1817B3B90
	public bool IsUnrestricted() { }

	// RVA: 0x17B3BA0 Offset: 0x17B21A0 VA: 0x1817B3BA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x17B3BE0 Offset: 0x17B21E0 VA: 0x1817B3BE0 Slot: 12
	public virtual SecurityElement ToXml() { }

	// RVA: 0x1520A60 Offset: 0x151F060 VA: 0x181520A60 Slot: 13
	public virtual int get_Count() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 14
	public virtual object get_SyncRoot() { }

	[MonoTODOAttribute] // RVA: 0xC1A40 Offset: 0xC0E40 VA: 0x1800C1A40
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17B36E0 Offset: 0x17B1CE0 VA: 0x1817B36E0 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17B38D0 Offset: 0x17B1ED0 VA: 0x1817B38D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17B3FA0 Offset: 0x17B25A0 VA: 0x1817B3FA0
	private static void .cctor() { }

}

