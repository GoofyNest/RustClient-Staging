public class ClaimsIdentity : IIdentity // TypeDefIndex: 935
{	// Fields
	private byte[] m_userSerializationData; // 0x10
	private List<Claim> m_instanceClaims; // 0x18
	private Collection<IEnumerable<Claim>> m_externalClaims; // 0x20
	private string m_nameType; // 0x28
	private string m_roleType; // 0x30
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private string m_version; // 0x38
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private ClaimsIdentity m_actor; // 0x40
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private string m_authenticationType; // 0x48
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private object m_bootstrapContext; // 0x50
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private string m_label; // 0x58
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private string m_serializedNameType; // 0x60
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private string m_serializedRoleType; // 0x68
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private string m_serializedClaims; // 0x70

	// Properties
	public virtual string AuthenticationType { get; }
	public ClaimsIdentity Actor { get; set; }
	public virtual IEnumerable<Claim> Claims { get; }
	public virtual string Name { get; }

	// Methods

	// RVA: 0x16F8510 Offset: 0x16F6B10 VA: 0x1816F8510
	public void .ctor() { }

	// RVA: 0x16F8540 Offset: 0x16F6B40 VA: 0x1816F8540
	public void .ctor(IEnumerable<Claim> claims) { }

	// RVA: 0x16F84E0 Offset: 0x16F6AE0 VA: 0x1816F84E0
	public void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	// RVA: 0x16F7F60 Offset: 0x16F6560 VA: 0x1816F7F60
	internal void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	// RVA: 0x16F8570 Offset: 0x16F6B70 VA: 0x1816F8570
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 6
	public virtual string get_AuthenticationType() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public ClaimsIdentity get_Actor() { }

	// RVA: 0x16F8760 Offset: 0x16F6D60 VA: 0x1816F8760
	public void set_Actor(ClaimsIdentity value) { }

	[IteratorStateMachineAttribute] // RVA: 0xC64E0 Offset: 0xC58E0 VA: 0x1800C64E0
	// RVA: 0x16F86C0 Offset: 0x16F6CC0 VA: 0x1816F86C0 Slot: 7
	public virtual IEnumerable<Claim> get_Claims() { }

	// RVA: 0x16F8730 Offset: 0x16F6D30 VA: 0x1816F8730 Slot: 8
	public virtual string get_Name() { }

	// RVA: 0x16F6910 Offset: 0x16F4F10 VA: 0x1816F6910 Slot: 9
	public virtual ClaimsIdentity Clone() { }

	// RVA: 0x16F7BE0 Offset: 0x16F61E0 VA: 0x1816F7BE0
	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	// RVA: 0x16F7B40 Offset: 0x16F6140 VA: 0x1816F7B40
	private void SafeAddClaim(Claim claim) { }

	// RVA: 0x16F7320 Offset: 0x16F5920 VA: 0x1816F7320 Slot: 10
	public virtual Claim FindFirst(string type) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16F7AC0 Offset: 0x16F60C0 VA: 0x1816F7AC0
	private void OnSerializingMethod(StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16F7940 Offset: 0x16F5F40 VA: 0x1816F7940
	private void OnDeserializedMethod(StreamingContext context) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16F7A10 Offset: 0x16F6010 VA: 0x1816F7A10
	private void OnDeserializingMethod(StreamingContext context) { }

	// RVA: 0x16F74E0 Offset: 0x16F5AE0 VA: 0x1816F74E0 Slot: 11
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16F6AA0 Offset: 0x16F50A0 VA: 0x1816F6AA0
	private void DeserializeClaims(string serializedClaims) { }

	// RVA: 0x16F7DD0 Offset: 0x16F63D0 VA: 0x1816F7DD0
	private string SerializeClaims() { }

	// RVA: 0x16F78F0 Offset: 0x16F5EF0 VA: 0x1816F78F0
	private bool IsCircular(ClaimsIdentity subject) { }

	// RVA: 0x16F6D00 Offset: 0x16F5300 VA: 0x1816F6D00
	private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext) { }

}

private sealed class ClaimsIdentity.<get_Claims>d__51 : IEnumerable<Claim>, IEnumerable, IEnumerator<Claim>, IDisposable, IEnumerator // TypeDefIndex: 936
{	// Fields
	private int <>1__state; // 0x10
	private Claim <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public ClaimsIdentity <>4__this; // 0x28
	private int <i>5__1; // 0x30
	private int <j>5__2; // 0x34
	private IEnumerator<Claim> <>7__wrap1; // 0x38

	// Properties
	private Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x170B750 Offset: 0x1709D50 VA: 0x18170B750 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x170B3C0 Offset: 0x17099C0 VA: 0x18170B3C0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x170B800 Offset: 0x1709E00 VA: 0x18170B800
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x170B700 Offset: 0x1709D00 VA: 0x18170B700 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x170B660 Offset: 0x1709C60 VA: 0x18170B660 Slot: 4
	private IEnumerator<Claim> System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x170B660 Offset: 0x1709C60 VA: 0x18170B660 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

