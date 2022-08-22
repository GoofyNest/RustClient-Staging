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

	// RVA: 0x17C82A0 Offset: 0x17C68A0 VA: 0x1817C82A0
	public void .ctor(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	// RVA: 0x17C8260 Offset: 0x17C6860 VA: 0x1817C8260
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17C7A60 Offset: 0x17C6060 VA: 0x1817C7A60 Slot: 14
	public void Dispose() { }

	// RVA: 0x17C7AB0 Offset: 0x17C60B0 VA: 0x1817C7AB0
	public static WindowsIdentity GetCurrent() { }

	// RVA: 0x17C7C80 Offset: 0x17C6280 VA: 0x1817C7C80 Slot: 15
	public virtual WindowsImpersonationContext Impersonate() { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370 Slot: 6
	public sealed override string get_AuthenticationType() { }

	// RVA: 0x17C8420 Offset: 0x17C6A20 VA: 0x1817C8420 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17C7E70 Offset: 0x17C6470 VA: 0x1817C7E70 Slot: 12
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x17C8130 Offset: 0x17C6730 VA: 0x1817C8130 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17C7D40 Offset: 0x17C6340 VA: 0x1817C7D40
	private void SetToken(IntPtr token) { }

	// RVA: 0x17C7AA0 Offset: 0x17C60A0 VA: 0x1817C7AA0
	internal static IntPtr GetCurrentToken() { }

	// RVA: 0x17C7AA0 Offset: 0x17C60A0 VA: 0x1817C7AA0
	private static string GetTokenName(IntPtr token) { }

	// RVA: 0x17C8220 Offset: 0x17C6820 VA: 0x1817C8220
	private static void .cctor() { }

}

