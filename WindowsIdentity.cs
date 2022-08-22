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

	// RVA: 0x17CA750 Offset: 0x17C8D50 VA: 0x1817CA750
	public void .ctor(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	// RVA: 0x17CA710 Offset: 0x17C8D10 VA: 0x1817CA710
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17C9F10 Offset: 0x17C8510 VA: 0x1817C9F10 Slot: 14
	public void Dispose() { }

	// RVA: 0x17C9F60 Offset: 0x17C8560 VA: 0x1817C9F60
	public static WindowsIdentity GetCurrent() { }

	// RVA: 0x17CA130 Offset: 0x17C8730 VA: 0x1817CA130 Slot: 15
	public virtual WindowsImpersonationContext Impersonate() { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0 Slot: 6
	public sealed override string get_AuthenticationType() { }

	// RVA: 0x17CA8D0 Offset: 0x17C8ED0 VA: 0x1817CA8D0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17CA320 Offset: 0x17C8920 VA: 0x1817CA320 Slot: 12
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x17CA5E0 Offset: 0x17C8BE0 VA: 0x1817CA5E0 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17CA1F0 Offset: 0x17C87F0 VA: 0x1817CA1F0
	private void SetToken(IntPtr token) { }

	// RVA: 0x17C9F50 Offset: 0x17C8550 VA: 0x1817C9F50
	internal static IntPtr GetCurrentToken() { }

	// RVA: 0x17C9F50 Offset: 0x17C8550 VA: 0x1817C9F50
	private static string GetTokenName(IntPtr token) { }

	// RVA: 0x17CA6D0 Offset: 0x17C8CD0 VA: 0x1817CA6D0
	private static void .cctor() { }

}

