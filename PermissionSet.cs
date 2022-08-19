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

	// RVA: 0x17B6390 Offset: 0x17B4990 VA: 0x1817B6390
	internal void .ctor() { }

	// RVA: 0x17B6310 Offset: 0x17B4910 VA: 0x1817B6310
	public void .ctor(PermissionState state) { }

	// RVA: 0x17B6400 Offset: 0x17B4A00 VA: 0x1817B6400
	internal void .ctor(IPermission perm) { }

	// RVA: 0x17B5570 Offset: 0x17B3B70 VA: 0x1817B5570 Slot: 10
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x17B56D0 Offset: 0x17B3CD0 VA: 0x1817B56D0 Slot: 11
	public void Demand() { }

	// RVA: 0x17B54F0 Offset: 0x17B3AF0 VA: 0x1817B54F0
	internal void CasOnlyDemand(int skip) { }

	// RVA: 0x17B5A90 Offset: 0x17B4090 VA: 0x1817B5A90 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x17B5B10 Offset: 0x17B4110 VA: 0x1817B5B10
	public bool IsEmpty() { }

	// RVA: 0x17B5D80 Offset: 0x17B4380 VA: 0x1817B5D80
	public bool IsUnrestricted() { }

	// RVA: 0x17B5D90 Offset: 0x17B4390 VA: 0x1817B5D90 Slot: 3
	public override string ToString() { }

	// RVA: 0x17B5DD0 Offset: 0x17B43D0 VA: 0x1817B5DD0 Slot: 12
	public virtual SecurityElement ToXml() { }

	// RVA: 0x15216D0 Offset: 0x151FCD0 VA: 0x1815216D0 Slot: 13
	public virtual int get_Count() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 14
	public virtual object get_SyncRoot() { }

	[MonoTODOAttribute] // RVA: 0xC1A80 Offset: 0xC0E80 VA: 0x1800C1A80
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x17B58D0 Offset: 0x17B3ED0 VA: 0x1817B58D0 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x17B5AC0 Offset: 0x17B40C0 VA: 0x1817B5AC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17B6190 Offset: 0x17B4790 VA: 0x1817B6190
	private static void .cctor() { }

}

