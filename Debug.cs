internal static class Debug // TypeDefIndex: 2456
{	// Methods

	// RVA: 0x1216F30 Offset: 0x1215530 VA: 0x181216F30
	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = 80) { }

	// RVA: 0x1216E10 Offset: 0x1215410 VA: 0x181216E10
	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = 80) { }

}

public class Debug // TypeDefIndex: 3371
{	// Fields
	internal static ILogger s_Logger; // 0x146DA

	// Properties
	public static ILogger unityLogger { get; }

	// Methods

	// RVA: 0x1829900 Offset: 0x1827F00 VA: 0x181829900
	public static ILogger get_unityLogger() { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18286B0 Offset: 0x1826CB0 VA: 0x1818286B0
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1828880 Offset: 0x1826E80 VA: 0x181828880
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[FreeFunctionAttribute] // RVA: 0x7BEA0 Offset: 0x7B2A0 VA: 0x18007BEA0
	// RVA: 0x18287D0 Offset: 0x1826DD0 VA: 0x1818287D0
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1828BC0 Offset: 0x18271C0 VA: 0x181828BC0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1828990 Offset: 0x1826F90 VA: 0x181828990
	public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	// RVA: 0x1828A40 Offset: 0x1827040 VA: 0x181828A40
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	// RVA: 0x18296D0 Offset: 0x1827CD0 VA: 0x1818296D0
	public static void Log(object message) { }

	// RVA: 0x18297A0 Offset: 0x1827DA0 VA: 0x1818297A0
	public static void Log(object message, Object context) { }

	// RVA: 0x1829270 Offset: 0x1827870 VA: 0x181829270
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x1828F20 Offset: 0x1827520 VA: 0x181828F20
	public static void LogError(object message) { }

	// RVA: 0x1828FF0 Offset: 0x18275F0 VA: 0x181828FF0
	public static void LogError(object message, Object context) { }

	// RVA: 0x1828E40 Offset: 0x1827440 VA: 0x181828E40
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x1828D50 Offset: 0x1827350 VA: 0x181828D50
	public static void LogErrorFormat(Object context, string format, object[] args) { }

	// RVA: 0x18291A0 Offset: 0x18277A0 VA: 0x1818291A0
	public static void LogException(Exception exception) { }

	// RVA: 0x18290D0 Offset: 0x18276D0 VA: 0x1818290D0
	public static void LogException(Exception exception, Object context) { }

	// RVA: 0x1829520 Offset: 0x1827B20 VA: 0x181829520
	public static void LogWarning(object message) { }

	// RVA: 0x18295F0 Offset: 0x1827BF0 VA: 0x1818295F0
	public static void LogWarning(object message, Object context) { }

	// RVA: 0x1829350 Offset: 0x1827950 VA: 0x181829350
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x1829430 Offset: 0x1827A30 VA: 0x181829430
	public static void LogWarningFormat(Object context, string format, object[] args) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x1828220 Offset: 0x1826820 VA: 0x181828220
	public static void Assert(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x1828300 Offset: 0x1826900 VA: 0x181828300
	public static void Assert(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x18283E0 Offset: 0x18269E0 VA: 0x1818283E0
	public static void Assert(bool condition, string message, Object context) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x1828C80 Offset: 0x1827280 VA: 0x181828C80
	public static void LogAssertion(object message) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18284D0 Offset: 0x1826AD0 VA: 0x1818284D0
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	// RVA: 0x1829880 Offset: 0x1827E80 VA: 0x181829880
	private static void .cctor() { }

	// RVA: 0x1828640 Offset: 0x1826C40 VA: 0x181828640
	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }

}

public static class Debug // TypeDefIndex: 7146
{	// Fields
	private static TextWriter writer; // 0x2B11524

	// Methods

	// RVA: 0x22E5590 Offset: 0x22E3B90 VA: 0x1822E5590
	private static void .cctor() { }

	// RVA: 0x22E5340 Offset: 0x22E3940 VA: 0x1822E5340
	public static void SetOut(TextWriter writer) { }

	// RVA: 0x22E54E0 Offset: 0x22E3AE0 VA: 0x1822E54E0
	public static void WriteLine(string format, object[] args) { }

}

public sealed class Debug.WriterDelegate : MulticastDelegate // TypeDefIndex: 7147
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E3190 Offset: 0x12E1790 VA: 0x1812E3190 Slot: 12
	public virtual void Invoke(string message) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class Debug.DummyWriter : TextWriter // TypeDefIndex: 7148
{	// Fields
	private Debug.WriterDelegate writer; // 0x28

	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x16298B0 Offset: 0x1627EB0 VA: 0x1816298B0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x22E5740 Offset: 0x22E3D40 VA: 0x1822E5740
	public void .ctor(Debug.WriterDelegate writer) { }

	// RVA: 0x22E5720 Offset: 0x22E3D20 VA: 0x1822E5720 Slot: 19
	public override void WriteLine(string value) { }

}

private sealed class Debug.DummyWriter.<>c // TypeDefIndex: 7149
{	// Fields
	public static readonly Debug.DummyWriter.<>c <>9; // 0x0
	public static Debug.WriterDelegate <>9__3_0; // 0x8

	// Methods

	// RVA: 0x22E8940 Offset: 0x22E6F40 VA: 0x1822E8940
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <.ctor>b__3_0(string msg) { }

}

