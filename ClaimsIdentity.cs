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

	// RVA: 0x16F6100 Offset: 0x16F4700 VA: 0x1816F6100
	public void .ctor() { }

	// RVA: 0x16F6130 Offset: 0x16F4730 VA: 0x1816F6130
	public void .ctor(IEnumerable<Claim> claims) { }

	// RVA: 0x16F60D0 Offset: 0x16F46D0 VA: 0x1816F60D0
	public void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	// RVA: 0x16F5B50 Offset: 0x16F4150 VA: 0x1816F5B50
	internal void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	// RVA: 0x16F6160 Offset: 0x16F4760 VA: 0x1816F6160
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 6
	public virtual string get_AuthenticationType() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public ClaimsIdentity get_Actor() { }

	// RVA: 0x16F6350 Offset: 0x16F4950 VA: 0x1816F6350
	public void set_Actor(ClaimsIdentity value) { }

	[IteratorStateMachineAttribute] // RVA: 0xC64E0 Offset: 0xC58E0 VA: 0x1800C64E0
	// RVA: 0x16F62B0 Offset: 0x16F48B0 VA: 0x1816F62B0 Slot: 7
	public virtual IEnumerable<Claim> get_Claims() { }

	// RVA: 0x16F6320 Offset: 0x16F4920 VA: 0x1816F6320 Slot: 8
	public virtual string get_Name() { }

	// RVA: 0x16F4500 Offset: 0x16F2B00 VA: 0x1816F4500 Slot: 9
	public virtual ClaimsIdentity Clone() { }

	// RVA: 0x16F57D0 Offset: 0x16F3DD0 VA: 0x1816F57D0
	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	// RVA: 0x16F5730 Offset: 0x16F3D30 VA: 0x1816F5730
	private void SafeAddClaim(Claim claim) { }

	// RVA: 0x16F4F10 Offset: 0x16F3510 VA: 0x1816F4F10 Slot: 10
	public virtual Claim FindFirst(string type) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16F56B0 Offset: 0x16F3CB0 VA: 0x1816F56B0
	private void OnSerializingMethod(StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16F5530 Offset: 0x16F3B30 VA: 0x1816F5530
	private void OnDeserializedMethod(StreamingContext context) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16F5600 Offset: 0x16F3C00 VA: 0x1816F5600
	private void OnDeserializingMethod(StreamingContext context) { }

	// RVA: 0x16F50D0 Offset: 0x16F36D0 VA: 0x1816F50D0 Slot: 11
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16F4690 Offset: 0x16F2C90 VA: 0x1816F4690
	private void DeserializeClaims(string serializedClaims) { }

	// RVA: 0x16F59C0 Offset: 0x16F3FC0 VA: 0x1816F59C0
	private string SerializeClaims() { }

	// RVA: 0x16F54E0 Offset: 0x16F3AE0 VA: 0x1816F54E0
	private bool IsCircular(ClaimsIdentity subject) { }

	// RVA: 0x16F48F0 Offset: 0x16F2EF0 VA: 0x1816F48F0
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
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1709340 Offset: 0x1707940 VA: 0x181709340 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1708FB0 Offset: 0x17075B0 VA: 0x181708FB0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x17093F0 Offset: 0x17079F0 VA: 0x1817093F0
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17092F0 Offset: 0x17078F0 VA: 0x1817092F0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1709250 Offset: 0x1707850 VA: 0x181709250 Slot: 4
	private IEnumerator<Claim> System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1709250 Offset: 0x1707850 VA: 0x181709250 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

