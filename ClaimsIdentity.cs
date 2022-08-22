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

	// RVA: 0x16F8250 Offset: 0x16F6850 VA: 0x1816F8250
	public void .ctor() { }

	// RVA: 0x16F8280 Offset: 0x16F6880 VA: 0x1816F8280
	public void .ctor(IEnumerable<Claim> claims) { }

	// RVA: 0x16F8220 Offset: 0x16F6820 VA: 0x1816F8220
	public void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	// RVA: 0x16F7CA0 Offset: 0x16F62A0 VA: 0x1816F7CA0
	internal void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	// RVA: 0x16F82B0 Offset: 0x16F68B0 VA: 0x1816F82B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 6
	public virtual string get_AuthenticationType() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public ClaimsIdentity get_Actor() { }

	// RVA: 0x16F84A0 Offset: 0x16F6AA0 VA: 0x1816F84A0
	public void set_Actor(ClaimsIdentity value) { }

	[IteratorStateMachineAttribute] // RVA: 0xC64E0 Offset: 0xC58E0 VA: 0x1800C64E0
	// RVA: 0x16F8400 Offset: 0x16F6A00 VA: 0x1816F8400 Slot: 7
	public virtual IEnumerable<Claim> get_Claims() { }

	// RVA: 0x16F8470 Offset: 0x16F6A70 VA: 0x1816F8470 Slot: 8
	public virtual string get_Name() { }

	// RVA: 0x16F6650 Offset: 0x16F4C50 VA: 0x1816F6650 Slot: 9
	public virtual ClaimsIdentity Clone() { }

	// RVA: 0x16F7920 Offset: 0x16F5F20 VA: 0x1816F7920
	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	// RVA: 0x16F7880 Offset: 0x16F5E80 VA: 0x1816F7880
	private void SafeAddClaim(Claim claim) { }

	// RVA: 0x16F7060 Offset: 0x16F5660 VA: 0x1816F7060 Slot: 10
	public virtual Claim FindFirst(string type) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16F7800 Offset: 0x16F5E00 VA: 0x1816F7800
	private void OnSerializingMethod(StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16F7680 Offset: 0x16F5C80 VA: 0x1816F7680
	private void OnDeserializedMethod(StreamingContext context) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16F7750 Offset: 0x16F5D50 VA: 0x1816F7750
	private void OnDeserializingMethod(StreamingContext context) { }

	// RVA: 0x16F7220 Offset: 0x16F5820 VA: 0x1816F7220 Slot: 11
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16F67E0 Offset: 0x16F4DE0 VA: 0x1816F67E0
	private void DeserializeClaims(string serializedClaims) { }

	// RVA: 0x16F7B10 Offset: 0x16F6110 VA: 0x1816F7B10
	private string SerializeClaims() { }

	// RVA: 0x16F7630 Offset: 0x16F5C30 VA: 0x1816F7630
	private bool IsCircular(ClaimsIdentity subject) { }

	// RVA: 0x16F6A40 Offset: 0x16F5040 VA: 0x1816F6A40
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
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x170B490 Offset: 0x1709A90 VA: 0x18170B490 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x170B100 Offset: 0x1709700 VA: 0x18170B100 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x170B540 Offset: 0x1709B40 VA: 0x18170B540
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x170B440 Offset: 0x1709A40 VA: 0x18170B440 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x170B3A0 Offset: 0x17099A0 VA: 0x18170B3A0 Slot: 4
	private IEnumerator<Claim> System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x170B3A0 Offset: 0x17099A0 VA: 0x18170B3A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

