public class ArgumentException : SystemException, ISerializable // TypeDefIndex: 166
{	// Fields
	private string m_paramName; // 0x88

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1553040 Offset: 0x1551640 VA: 0x181553040
	public void .ctor() { }

	// RVA: 0x15530F0 Offset: 0x15516F0 VA: 0x1815530F0
	public void .ctor(string message) { }

	// RVA: 0x1552F30 Offset: 0x1551530 VA: 0x181552F30
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15530A0 Offset: 0x15516A0 VA: 0x1815530A0
	public void .ctor(string message, string paramName, Exception innerException) { }

	// RVA: 0x1552F60 Offset: 0x1551560 VA: 0x181552F60
	public void .ctor(string message, string paramName) { }

	// RVA: 0x1552FB0 Offset: 0x15515B0 VA: 0x181552FB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1553120 Offset: 0x1551720 VA: 0x181553120 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1552E40 Offset: 0x1551440 VA: 0x181552E40 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

public class ArgumentNullException : ArgumentException // TypeDefIndex: 167
{	// Methods

	// RVA: 0x1553230 Offset: 0x1551830 VA: 0x181553230
	public void .ctor() { }

	// RVA: 0x1553300 Offset: 0x1551900 VA: 0x181553300
	public void .ctor(string paramName) { }

	// RVA: 0x15532A0 Offset: 0x15518A0 VA: 0x1815532A0
	public void .ctor(string paramName, string message) { }

	// RVA: 0x1552FB0 Offset: 0x15515B0 VA: 0x181552FB0
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

	// RVA: 0x15539C0 Offset: 0x1551FC0 VA: 0x1815539C0
	private static string get_RangeMessage() { }

	// RVA: 0x1553500 Offset: 0x1551B00 VA: 0x181553500
	public void .ctor() { }

	// RVA: 0x15535B0 Offset: 0x1551BB0 VA: 0x1815535B0
	public void .ctor(string paramName) { }

	// RVA: 0x1553550 Offset: 0x1551B50 VA: 0x181553550
	public void .ctor(string paramName, string message) { }

	// RVA: 0x1553730 Offset: 0x1551D30 VA: 0x181553730
	public void .ctor(string paramName, object actualValue, string message) { }

	// RVA: 0x15537B0 Offset: 0x1551DB0 VA: 0x1815537B0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1553390 Offset: 0x1551990 VA: 0x181553390 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1553620 Offset: 0x1551C20 VA: 0x181553620
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public struct ArgIterator // TypeDefIndex: 347
{	// Fields
	private IntPtr sig; // 0x0
	private IntPtr args; // 0x8
	private int next_arg; // 0x10
	private int num_args; // 0x14

	// Methods

	// RVA: 0x1F2330 Offset: 0x1F1730 VA: 0x1801F2330 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x14C2F0 Offset: 0x14B6F0 VA: 0x18014C2F0 Slot: 2
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

	// RVA: 0x146D8F0 Offset: 0x146BEF0 VA: 0x18146D8F0
	public void .ctor(MethodBase method, ArgInfoType type) { }

	// RVA: 0x146D7D0 Offset: 0x146BDD0 VA: 0x18146D7D0
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

	// RVA: 0x180B0F0 Offset: 0x18096F0 VA: 0x18180B0F0
	public Object get_unityObjectArgument() { }

	// RVA: 0x180B0E0 Offset: 0x18096E0 VA: 0x18180B0E0
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0x180B0C0 Offset: 0x18096C0 VA: 0x18180B0C0
	public int get_intArgument() { }

	// RVA: 0x180B0B0 Offset: 0x18096B0 VA: 0x18180B0B0
	public float get_floatArgument() { }

	// RVA: 0x180B0D0 Offset: 0x18096D0 VA: 0x18180B0D0
	public string get_stringArgument() { }

	// RVA: 0x180B0A0 Offset: 0x18096A0 VA: 0x18180B0A0
	public bool get_boolArgument() { }

	// RVA: 0x180AEB0 Offset: 0x18094B0 VA: 0x18180AEB0
	private void TidyAssemblyTypeName() { }

	// RVA: 0x180AEA0 Offset: 0x18094A0 VA: 0x18180AEA0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x180AEA0 Offset: 0x18094A0 VA: 0x18180AEA0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public static class ArgEx // TypeDefIndex: 11695
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9ED2D0 Offset: 0x9EB8D0 VA: 0x1809ED2D0
	public static BasePlayer GetPlayer_Clientside(ConsoleSystem.Arg arg, int iArgNum) { }

}

