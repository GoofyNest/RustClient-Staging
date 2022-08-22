public class ArgumentException : SystemException, ISerializable // TypeDefIndex: 166
{	// Fields
	private string m_paramName; // 0x88

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1553F70 Offset: 0x1552570 VA: 0x181553F70
	public void .ctor() { }

	// RVA: 0x1554020 Offset: 0x1552620 VA: 0x181554020
	public void .ctor(string message) { }

	// RVA: 0x1553E60 Offset: 0x1552460 VA: 0x181553E60
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1553FD0 Offset: 0x15525D0 VA: 0x181553FD0
	public void .ctor(string message, string paramName, Exception innerException) { }

	// RVA: 0x1553E90 Offset: 0x1552490 VA: 0x181553E90
	public void .ctor(string message, string paramName) { }

	// RVA: 0x1553EE0 Offset: 0x15524E0 VA: 0x181553EE0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1554050 Offset: 0x1552650 VA: 0x181554050 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1553D70 Offset: 0x1552370 VA: 0x181553D70 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

public class ArgumentNullException : ArgumentException // TypeDefIndex: 167
{	// Methods

	// RVA: 0x1554160 Offset: 0x1552760 VA: 0x181554160
	public void .ctor() { }

	// RVA: 0x1554230 Offset: 0x1552830 VA: 0x181554230
	public void .ctor(string paramName) { }

	// RVA: 0x15541D0 Offset: 0x15527D0 VA: 0x1815541D0
	public void .ctor(string paramName, string message) { }

	// RVA: 0x1553EE0 Offset: 0x15524E0 VA: 0x181553EE0
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

	// RVA: 0x15548F0 Offset: 0x1552EF0 VA: 0x1815548F0
	private static string get_RangeMessage() { }

	// RVA: 0x1554430 Offset: 0x1552A30 VA: 0x181554430
	public void .ctor() { }

	// RVA: 0x15544E0 Offset: 0x1552AE0 VA: 0x1815544E0
	public void .ctor(string paramName) { }

	// RVA: 0x1554480 Offset: 0x1552A80 VA: 0x181554480
	public void .ctor(string paramName, string message) { }

	// RVA: 0x1554660 Offset: 0x1552C60 VA: 0x181554660
	public void .ctor(string paramName, object actualValue, string message) { }

	// RVA: 0x15546E0 Offset: 0x1552CE0 VA: 0x1815546E0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x15542C0 Offset: 0x15528C0 VA: 0x1815542C0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1554550 Offset: 0x1552B50 VA: 0x181554550
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

	// RVA: 0x146E820 Offset: 0x146CE20 VA: 0x18146E820
	public void .ctor(MethodBase method, ArgInfoType type) { }

	// RVA: 0x146E700 Offset: 0x146CD00 VA: 0x18146E700
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

	// RVA: 0x181DCB0 Offset: 0x181C2B0 VA: 0x18181DCB0
	public Object get_unityObjectArgument() { }

	// RVA: 0x181DCA0 Offset: 0x181C2A0 VA: 0x18181DCA0
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0x181DC80 Offset: 0x181C280 VA: 0x18181DC80
	public int get_intArgument() { }

	// RVA: 0x181DC70 Offset: 0x181C270 VA: 0x18181DC70
	public float get_floatArgument() { }

	// RVA: 0x181DC90 Offset: 0x181C290 VA: 0x18181DC90
	public string get_stringArgument() { }

	// RVA: 0x181DC60 Offset: 0x181C260 VA: 0x18181DC60
	public bool get_boolArgument() { }

	// RVA: 0x181DA70 Offset: 0x181C070 VA: 0x18181DA70
	private void TidyAssemblyTypeName() { }

	// RVA: 0x181DA60 Offset: 0x181C060 VA: 0x18181DA60 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x181DA60 Offset: 0x181C060 VA: 0x18181DA60 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public static class ArgEx // TypeDefIndex: 11695
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9ECDE0 Offset: 0x9EB3E0 VA: 0x1809ECDE0
	public static BasePlayer GetPlayer_Clientside(ConsoleSystem.Arg arg, int iArgNum) { }

}

