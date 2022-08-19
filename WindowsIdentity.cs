public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 932
{	// Fields
	private IntPtr _token; // 0x78
	private string _type; // 0x80
	private WindowsAccountType _account; // 0x88
	private bool _authenticated; // 0x8C
	private string _name; // 0x90
	private SerializationInfo _info; // 0x98
	private static IntPtr invalidWindows; // 0x0

	// Properties
	public sealed override string AuthenticationType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x17CA490 Offset: 0x17C8A90 VA: 0x1817CA490
	public void .ctor(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	// RVA: 0x17CA450 Offset: 0x17C8A50 VA: 0x1817CA450
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x17C9C50 Offset: 0x17C8250 VA: 0x1817C9C50 Slot: 14
	public void Dispose() { }

	// RVA: 0x17C9CA0 Offset: 0x17C82A0 VA: 0x1817C9CA0
	public static WindowsIdentity GetCurrent() { }

	// RVA: 0x17C9E70 Offset: 0x17C8470 VA: 0x1817C9E70 Slot: 15
	public virtual WindowsImpersonationContext Impersonate() { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0 Slot: 6
	public sealed override string get_AuthenticationType() { }

	// RVA: 0x17CA610 Offset: 0x17C8C10 VA: 0x1817CA610 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17CA060 Offset: 0x17C8660 VA: 0x1817CA060 Slot: 12
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x17CA320 Offset: 0x17C8920 VA: 0x1817CA320 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17C9F30 Offset: 0x17C8530 VA: 0x1817C9F30
	private void SetToken(IntPtr token) { }

	// RVA: 0x17C9C90 Offset: 0x17C8290 VA: 0x1817C9C90
	internal static IntPtr GetCurrentToken() { }

	// RVA: 0x17C9C90 Offset: 0x17C8290 VA: 0x1817C9C90
	private static string GetTokenName(IntPtr token) { }

	// RVA: 0x17CA410 Offset: 0x17C8A10 VA: 0x1817CA410
	private static void .cctor() { }

}

