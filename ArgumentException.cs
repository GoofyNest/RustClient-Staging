public class ArgumentException : SystemException, ISerializable // TypeDefIndex: 166
{	private string m_paramName; // 0x88

	public override string Message { get; }


	public void .ctor() { }

	public void .ctor(string message) { }

	public void .ctor(string message, Exception innerException) { }

	public void .ctor(string message, string paramName, Exception innerException) { }

	public void .ctor(string message, string paramName) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public override string get_Message() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

public class ArgumentNullException : ArgumentException // TypeDefIndex: 167
{
	public void .ctor() { }

	public void .ctor(string paramName) { }

	public void .ctor(string paramName, string message) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public class ArgumentOutOfRangeException : ArgumentException, ISerializable // TypeDefIndex: 168
{	private static string _rangeMessage; // 0x0
	private object m_actualValue; // 0x90

	private static string RangeMessage { get; }
	public override string Message { get; }


	private static string get_RangeMessage() { }

	public void .ctor() { }

	public void .ctor(string paramName) { }

	public void .ctor(string paramName, string message) { }

	public void .ctor(string paramName, object actualValue, string message) { }

	public override string get_Message() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public struct ArgIterator // TypeDefIndex: 347
{	private IntPtr sig; // 0x0
	private IntPtr args; // 0x8
	private int next_arg; // 0x10
	private int num_args; // 0x14


	public override bool Equals(object o) { }

	public override int GetHashCode() { }

}

internal enum ArgInfoType // TypeDefIndex: 1221
{	public byte value__; // 0x0
	public const ArgInfoType In = 0;
	public const ArgInfoType Out = 1;

}

internal class ArgInfo // TypeDefIndex: 1222
{	private int[] _paramMap; // 0x10
	private int _inoutArgCount; // 0x18
	private MethodBase _method; // 0x20


	public void .ctor(MethodBase method, ArgInfoType type) { }

	public object[] GetInOutArgs(object[] args) { }

}

internal class ArgumentCache : ISerializationCallbackReceiver // TypeDefIndex: 3626
{	[SerializeField] // RVA: 0xDF240 Offset: 0xDE640 VA: 0x1800DF240
	[FormerlySerializedAsAttribute] // RVA: 0xDF240 Offset: 0xDE640 VA: 0x1800DF240
	private Object m_ObjectArgument; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xDF370 Offset: 0xDE770 VA: 0x1800DF370
	[SerializeField] // RVA: 0xDF370 Offset: 0xDE770 VA: 0x1800DF370
	private string m_ObjectArgumentAssemblyTypeName; // 0x18
	[SerializeField] // RVA: 0xDF4C0 Offset: 0xDE8C0 VA: 0x1800DF4C0
	[FormerlySerializedAsAttribute] // RVA: 0xDF4C0 Offset: 0xDE8C0 VA: 0x1800DF4C0
	private int m_IntArgument; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xDF6A0 Offset: 0xDEAA0 VA: 0x1800DF6A0
	[SerializeField] // RVA: 0xDF6A0 Offset: 0xDEAA0 VA: 0x1800DF6A0
	private float m_FloatArgument; // 0x24
	[SerializeField] // RVA: 0xDF6F0 Offset: 0xDEAF0 VA: 0x1800DF6F0
	[FormerlySerializedAsAttribute] // RVA: 0xDF6F0 Offset: 0xDEAF0 VA: 0x1800DF6F0
	private string m_StringArgument; // 0x28
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool m_BoolArgument; // 0x30

	public Object unityObjectArgument { get; }
	public string unityObjectArgumentAssemblyTypeName { get; }
	public int intArgument { get; }
	public float floatArgument { get; }
	public string stringArgument { get; }
	public bool boolArgument { get; }


	public Object get_unityObjectArgument() { }

	public string get_unityObjectArgumentAssemblyTypeName() { }

	public int get_intArgument() { }

	public float get_floatArgument() { }

	public string get_stringArgument() { }

	public bool get_boolArgument() { }

	private void TidyAssemblyTypeName() { }

	public void OnBeforeSerialize() { }

	public void OnAfterDeserialize() { }

	public void .ctor() { }

}

public static class ArgEx // TypeDefIndex: 11699
{
	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static BasePlayer GetPlayer_Clientside(ConsoleSystem.Arg arg, int iArgNum) { }

}

