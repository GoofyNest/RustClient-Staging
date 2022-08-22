public class ArgumentException : SystemException, ISerializable // TypeDefIndex: 166
{	// Fields
	private string m_paramName; // 0x88

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1553CB0 Offset: 0x15522B0 VA: 0x181553CB0
	public void .ctor() { }

	// RVA: 0x1553D60 Offset: 0x1552360 VA: 0x181553D60
	public void .ctor(string message) { }

	// RVA: 0x1553BA0 Offset: 0x15521A0 VA: 0x181553BA0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1553D10 Offset: 0x1552310 VA: 0x181553D10
	public void .ctor(string message, string paramName, Exception innerException) { }

	// RVA: 0x1553BD0 Offset: 0x15521D0 VA: 0x181553BD0
	public void .ctor(string message, string paramName) { }

	// RVA: 0x1553C20 Offset: 0x1552220 VA: 0x181553C20
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1553D90 Offset: 0x1552390 VA: 0x181553D90 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1553AB0 Offset: 0x15520B0 VA: 0x181553AB0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

public class ArgumentNullException : ArgumentException // TypeDefIndex: 167
{	// Methods

	// RVA: 0x1553EA0 Offset: 0x15524A0 VA: 0x181553EA0
	public void .ctor() { }

	// RVA: 0x1553F70 Offset: 0x1552570 VA: 0x181553F70
	public void .ctor(string paramName) { }

	// RVA: 0x1553F10 Offset: 0x1552510 VA: 0x181553F10
	public void .ctor(string paramName, string message) { }

	// RVA: 0x1553C20 Offset: 0x1552220 VA: 0x181553C20
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public class ArgumentOutOfRangeException : ArgumentException, ISerializable // TypeDefIndex: 168
{	// Fields
	private static string _rangeMessage; // 0x0
	private object m_actualValue; // 0x90

	// Properties
	private static string RangeMessage { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x1554630 Offset: 0x1552C30 VA: 0x181554630
	private static string get_RangeMessage() { }

	// RVA: 0x1554170 Offset: 0x1552770 VA: 0x181554170
	public void .ctor() { }

	// RVA: 0x1554220 Offset: 0x1552820 VA: 0x181554220
	public void .ctor(string paramName) { }

	// RVA: 0x15541C0 Offset: 0x15527C0 VA: 0x1815541C0
	public void .ctor(string paramName, string message) { }

	// RVA: 0x15543A0 Offset: 0x15529A0 VA: 0x1815543A0
	public void .ctor(string paramName, object actualValue, string message) { }

	// RVA: 0x1554420 Offset: 0x1552A20 VA: 0x181554420 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1554000 Offset: 0x1552600 VA: 0x181554000 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1554290 Offset: 0x1552890 VA: 0x181554290
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public struct ArgIterator // TypeDefIndex: 347
{	// Fields
	private IntPtr sig; // 0x0
	private IntPtr args; // 0x8
	private int next_arg; // 0x10
	private int num_args; // 0x14

	// Methods

	// RVA: 0x1F1F10 Offset: 0x1F1310 VA: 0x1801F1F10 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x14C4D0 Offset: 0x14B8D0 VA: 0x18014C4D0 Slot: 2
	public override int GetHashCode() { }

}

internal enum ArgInfoType // TypeDefIndex: 1221
{	// Fields
	public byte value__; // 0x0
	public const ArgInfoType In = 0;
	public const ArgInfoType Out = 1;

}

internal class ArgInfo // TypeDefIndex: 1222
{	// Fields
	private int[] _paramMap; // 0x10
	private int _inoutArgCount; // 0x18
	private MethodBase _method; // 0x20

	// Methods

	// RVA: 0x146E560 Offset: 0x146CB60 VA: 0x18146E560
	public void .ctor(MethodBase method, ArgInfoType type) { }

	// RVA: 0x146E440 Offset: 0x146CA40 VA: 0x18146E440
	public object[] GetInOutArgs(object[] args) { }

}

internal class ArgumentCache : ISerializationCallbackReceiver // TypeDefIndex: 3626
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xDF110 Offset: 0xDE510 VA: 0x1800DF110
	[SerializeField] // RVA: 0xDF110 Offset: 0xDE510 VA: 0x1800DF110
	private Object m_ObjectArgument; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xDF280 Offset: 0xDE680 VA: 0x1800DF280
	[SerializeField] // RVA: 0xDF280 Offset: 0xDE680 VA: 0x1800DF280
	private string m_ObjectArgumentAssemblyTypeName; // 0x18
	[SerializeField] // RVA: 0xDF3C0 Offset: 0xDE7C0 VA: 0x1800DF3C0
	[FormerlySerializedAsAttribute] // RVA: 0xDF3C0 Offset: 0xDE7C0 VA: 0x1800DF3C0
	private int m_IntArgument; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xDF580 Offset: 0xDE980 VA: 0x1800DF580
	[SerializeField] // RVA: 0xDF580 Offset: 0xDE980 VA: 0x1800DF580
	private float m_FloatArgument; // 0x24
	[FormerlySerializedAsAttribute] // RVA: 0xDF5D0 Offset: 0xDE9D0 VA: 0x1800DF5D0
	[SerializeField] // RVA: 0xDF5D0 Offset: 0xDE9D0 VA: 0x1800DF5D0
	private string m_StringArgument; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_BoolArgument; // 0x30

	// Properties
	public Object unityObjectArgument { get; }
	public string unityObjectArgumentAssemblyTypeName { get; }
	public int intArgument { get; }
	public float floatArgument { get; }
	public string stringArgument { get; }
	public bool boolArgument { get; }

	// Methods

	// RVA: 0x181D9F0 Offset: 0x181BFF0 VA: 0x18181D9F0
	public Object get_unityObjectArgument() { }

	// RVA: 0x181D9E0 Offset: 0x181BFE0 VA: 0x18181D9E0
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0x181D9C0 Offset: 0x181BFC0 VA: 0x18181D9C0
	public int get_intArgument() { }

	// RVA: 0x181D9B0 Offset: 0x181BFB0 VA: 0x18181D9B0
	public float get_floatArgument() { }

	// RVA: 0x181D9D0 Offset: 0x181BFD0 VA: 0x18181D9D0
	public string get_stringArgument() { }

	// RVA: 0x181D9A0 Offset: 0x181BFA0 VA: 0x18181D9A0
	public bool get_boolArgument() { }

	// RVA: 0x181D7B0 Offset: 0x181BDB0 VA: 0x18181D7B0
	private void TidyAssemblyTypeName() { }

	// RVA: 0x181D7A0 Offset: 0x181BDA0 VA: 0x18181D7A0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x181D7A0 Offset: 0x181BDA0 VA: 0x18181D7A0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public static class ArgEx // TypeDefIndex: 11695
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9ECB20 Offset: 0x9EB120 VA: 0x1809ECB20
	public static BasePlayer GetPlayer_Clientside(ConsoleSystem.Arg arg, int iArgNum) { }

}

