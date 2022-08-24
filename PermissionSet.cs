public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback // TypeDefIndex: 902
{	private static object[] psUnrestricted; // 0x0
	private PermissionState state; // 0x10
	private ArrayList list; // 0x18
	private bool _declsec; // 0x20
	private bool[] _ignored; // 0x28
	private static object[] action; // 0x8

	public virtual int Count { get; }
	public virtual object SyncRoot { get; }


	internal void .ctor() { }

	public void .ctor(PermissionState state) { }

	internal void .ctor(IPermission perm) { }

	public virtual void CopyTo(Array array, int index) { }

	public void Demand() { }

	internal void CasOnlyDemand(int skip) { }

	public IEnumerator GetEnumerator() { }

	public bool IsEmpty() { }

	public bool IsUnrestricted() { }

	public override string ToString() { }

	public virtual SecurityElement ToXml() { }

	public virtual int get_Count() { }

	public virtual object get_SyncRoot() { }

	[MonoTODOAttribute] // RVA: 0xC1BD0 Offset: 0xC0FD0 VA: 0x1800C1BD0
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[ComVisibleAttribute] // RVA: 0x75DF0 Offset: 0x751F0 VA: 0x180075DF0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75DF0 Offset: 0x751F0 VA: 0x180075DF0
	public override int GetHashCode() { }

	private static void .cctor() { }

}

