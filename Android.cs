public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 4463
{
// Namespace: UnityEngine
public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 4463
	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1464520 Offset: 0x1462B20 VA: 0x181464520 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AndroidJavaException : Exception // TypeDefIndex: 4464
{	// Fields
	private string mJavaStackTrace; // 0x88

	// Properties
	public override string StackTrace { get; }

	// Methods

	// RVA: 0x2276580 Offset: 0x2274B80 VA: 0x182276580
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x2276600 Offset: 0x2274C00 VA: 0x182276600 Slot: 8
	public override string get_StackTrace() { }

}

internal class AndroidJavaRunnableProxy : AndroidJavaProxy // TypeDefIndex: 4466
{	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x2277DA0 Offset: 0x22763A0 VA: 0x182277DA0
	public void .ctor(AndroidJavaRunnable runnable) { }

}

public class AndroidJavaProxy // TypeDefIndex: 4467
{	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0x2277CA0 Offset: 0x22762A0 VA: 0x182277CA0
	public void .ctor(string javaInterface) { }

	// RVA: 0x2277D40 Offset: 0x2276340 VA: 0x182277D40
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x2277030 Offset: 0x2275630 VA: 0x182277030 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2277460 Offset: 0x2275A60 VA: 0x182277460 Slot: 4
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x2277280 Offset: 0x2275880 VA: 0x182277280 Slot: 5
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x2277110 Offset: 0x2275710 VA: 0x182277110
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x2277170 Offset: 0x2275770 VA: 0x182277170
	internal IntPtr GetRawProxy() { }

	// RVA: 0x2277BD0 Offset: 0x22761D0 VA: 0x182277BD0
	private static void .cctor() { }

}

public class AndroidJavaObject : IDisposable // TypeDefIndex: 4468
{	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x2276FF0 Offset: 0x22755F0 VA: 0x182276FF0
	public void .ctor(string className, object[] args) { }

	// RVA: 0x2276900 Offset: 0x2274F00 VA: 0x182276900 Slot: 4
	public void Dispose() { }

	// RVA: 0x4D2120 Offset: 0x4D0720 VA: 0x1804D2120
	public IntPtr GetRawObject() { }

	// RVA: 0x855180 Offset: 0x853780 VA: 0x180855180
	public IntPtr GetRawClass() { }

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244AB0 Offset: 0x12430B0 VA: 0x181244AB0
	|-AndroidJavaObject.Call<bool>
	|-AndroidJavaObject.Call<char>
	|-AndroidJavaObject.Call<double>
	|-AndroidJavaObject.Call<short>
	|-AndroidJavaObject.Call<int>
	|-AndroidJavaObject.Call<long>
	|-AndroidJavaObject.Call<object>
	|-AndroidJavaObject.Call<sbyte>
	|-AndroidJavaObject.Call<float>
	|-AndroidJavaObject.Call<string>
	|-AndroidJavaObject.Call<AndroidJavaObject>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244AB0 Offset: 0x12430B0 VA: 0x181244AB0
	|-AndroidJavaObject.CallStatic<int>
	|-AndroidJavaObject.CallStatic<object>
	|-AndroidJavaObject.CallStatic<AndroidJavaObject>
	*/

	// RVA: 0x2276870 Offset: 0x2274E70 VA: 0x182276870
	protected void DebugPrint(string msg) { }

	// RVA: 0x2276A70 Offset: 0x2275070 VA: 0x182276A70
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x2276EA0 Offset: 0x22754A0 VA: 0x182276EA0
	internal void .ctor(IntPtr jobject) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x22769D0 Offset: 0x2274FD0 VA: 0x1822769D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2276970 Offset: 0x2274F70 VA: 0x182276970 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12466C0 Offset: 0x1244CC0 VA: 0x1812466C0
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x1247510 Offset: 0x1245B10 VA: 0x181247510
	|-AndroidJavaObject._Call<char>
	|
	|-RVA: 0x1248360 Offset: 0x1246960 VA: 0x181248360
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x1249240 Offset: 0x1247840 VA: 0x181249240
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x124A090 Offset: 0x1248690 VA: 0x18124A090
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x124AEB0 Offset: 0x12494B0 VA: 0x18124AEB0
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x124BCF0 Offset: 0x124A2F0 VA: 0x18124BCF0
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x124CAC0 Offset: 0x124B0C0 VA: 0x18124CAC0
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x124D910 Offset: 0x124BF10 VA: 0x18124D910
	|-AndroidJavaObject._Call<float>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244AD0 Offset: 0x12430D0 VA: 0x181244AD0
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x12458F0 Offset: 0x1243EF0 VA: 0x1812458F0
	|-AndroidJavaObject._CallStatic<object>
	*/

	// RVA: 0x2276750 Offset: 0x2274D50 VA: 0x182276750
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x2276630 Offset: 0x2274C30 VA: 0x182276630
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0x4D2120 Offset: 0x4D0720 VA: 0x1804D2120
	protected IntPtr _GetRawObject() { }

	// RVA: 0x855180 Offset: 0x853780 VA: 0x180855180
	protected IntPtr _GetRawClass() { }

	// RVA: 0x2276E60 Offset: 0x2275460 VA: 0x182276E60
	private static void .cctor() { }

}

public class AndroidJavaClass : AndroidJavaObject // TypeDefIndex: 4469
{	// Methods

	// RVA: 0x2276450 Offset: 0x2274A50 VA: 0x182276450
	public void .ctor(string className) { }

	// RVA: 0x2276260 Offset: 0x2274860 VA: 0x182276260
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x2276350 Offset: 0x2274950 VA: 0x182276350
	internal void .ctor(IntPtr jclass) { }

}

internal class AndroidReflection // TypeDefIndex: 4470
{	// Fields
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Methods

	// RVA: 0x22785B0 Offset: 0x2276BB0 VA: 0x1822785B0
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x2278580 Offset: 0x2276B80 VA: 0x182278580
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x2278470 Offset: 0x2276A70 VA: 0x182278470
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x22780A0 Offset: 0x22766A0 VA: 0x1822780A0
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x2277EA0 Offset: 0x22764A0 VA: 0x182277EA0
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x22781B0 Offset: 0x22767B0 VA: 0x1822781B0
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x22785D0 Offset: 0x2276BD0 VA: 0x1822785D0
	public static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x22786C0 Offset: 0x2276CC0 VA: 0x1822786C0
	public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound) { }

	// RVA: 0x2278800 Offset: 0x2276E00 VA: 0x182278800
	private static void .cctor() { }

}

public static class AndroidJNIHelper // TypeDefIndex: 4473
{	// Methods

	// RVA: 0x22727F0 Offset: 0x2270DF0 VA: 0x1822727F0
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x2272800 Offset: 0x2270E00 VA: 0x182272800
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x2272490 Offset: 0x2270A90 VA: 0x182272490
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x22722C0 Offset: 0x22708C0 VA: 0x1822722C0
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x22722B0 Offset: 0x22708B0 VA: 0x1822722B0
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x22725C0 Offset: 0x2270BC0 VA: 0x1822725C0
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x22726F0 Offset: 0x2270CF0 VA: 0x1822726F0
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244AA0 Offset: 0x12430A0 VA: 0x181244AA0
	|-AndroidJNIHelper.ConvertFromJNIArray<bool>
	|-AndroidJNIHelper.ConvertFromJNIArray<char>
	|-AndroidJNIHelper.ConvertFromJNIArray<double>
	|-AndroidJNIHelper.ConvertFromJNIArray<short>
	|-AndroidJNIHelper.ConvertFromJNIArray<int>
	|-AndroidJNIHelper.ConvertFromJNIArray<long>
	|-AndroidJNIHelper.ConvertFromJNIArray<object>
	|-AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|-AndroidJNIHelper.ConvertFromJNIArray<float>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC1880 Offset: 0xEBFE80 VA: 0x180EC1880
	|-AndroidJNIHelper.GetMethodID<bool>
	|-AndroidJNIHelper.GetMethodID<char>
	|-AndroidJNIHelper.GetMethodID<double>
	|-AndroidJNIHelper.GetMethodID<short>
	|-AndroidJNIHelper.GetMethodID<int>
	|-AndroidJNIHelper.GetMethodID<long>
	|-AndroidJNIHelper.GetMethodID<object>
	|-AndroidJNIHelper.GetMethodID<sbyte>
	|-AndroidJNIHelper.GetMethodID<float>
	*/

}

public static class AndroidJNI // TypeDefIndex: 4474
{	// Methods

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275950 Offset: 0x2273F50 VA: 0x182275950
	public static IntPtr FindClass(string name) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275B50 Offset: 0x2274150 VA: 0x182275B50
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275920 Offset: 0x2273F20 VA: 0x182275920
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x22758F0 Offset: 0x2273EF0 VA: 0x1822758F0
	public static void ExceptionClear() { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275DD0 Offset: 0x22743D0 VA: 0x182275DD0
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275830 Offset: 0x2273E30 VA: 0x182275830
	public static void DeleteGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275F40 Offset: 0x2274540 VA: 0x182275F40
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x22758B0 Offset: 0x2273EB0 VA: 0x1822758B0
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275E10 Offset: 0x2274410 VA: 0x182275E10
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275870 Offset: 0x2273E70 VA: 0x182275870
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275EA0 Offset: 0x22744A0 VA: 0x182275EA0
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275CF0 Offset: 0x22742F0 VA: 0x182275CF0
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275C50 Offset: 0x2274250 VA: 0x182275C50
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275D30 Offset: 0x2274330 VA: 0x182275D30
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x2275F00 Offset: 0x2274500 VA: 0x182275F00
	public static IntPtr NewString(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275F00 Offset: 0x2274500 VA: 0x182275F00
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275D90 Offset: 0x2274390 VA: 0x182275D90
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x22757D0 Offset: 0x2273DD0 VA: 0x1822757D0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275290 Offset: 0x2273890 VA: 0x182275290
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x22751D0 Offset: 0x22737D0 VA: 0x1822751D0
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275050 Offset: 0x2273650 VA: 0x182275050
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275350 Offset: 0x2273950 VA: 0x182275350
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x22752F0 Offset: 0x22738F0 VA: 0x1822752F0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x22750B0 Offset: 0x22736B0 VA: 0x1822750B0
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275170 Offset: 0x2273770 VA: 0x182275170
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275110 Offset: 0x2273710 VA: 0x182275110
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275230 Offset: 0x2273830 VA: 0x182275230
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275710 Offset: 0x2273D10 VA: 0x182275710
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x22755F0 Offset: 0x2273BF0 VA: 0x1822755F0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275530 Offset: 0x2273B30 VA: 0x182275530
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x22753B0 Offset: 0x22739B0 VA: 0x1822753B0
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x22756B0 Offset: 0x2273CB0 VA: 0x1822756B0
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275650 Offset: 0x2273C50 VA: 0x182275650
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275410 Offset: 0x2273A10 VA: 0x182275410
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x22754D0 Offset: 0x2273AD0 VA: 0x1822754D0
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275470 Offset: 0x2273A70 VA: 0x182275470
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275590 Offset: 0x2273B90 VA: 0x182275590
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275770 Offset: 0x2273D70 VA: 0x182275770
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275FD0 Offset: 0x22745D0 VA: 0x182275FD0
	public static IntPtr ToBooleanArray(bool[] array) { }

	[ThreadSafeAttribute] // RVA: 0xC1550 Offset: 0xC0950 VA: 0x1800C1550
	[ObsoleteAttribute] // RVA: 0xC1550 Offset: 0xC0950 VA: 0x1800C1550
	// RVA: 0x2276010 Offset: 0x2274610 VA: 0x182276010
	public static IntPtr ToByteArray(byte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x22761E0 Offset: 0x22747E0 VA: 0x1822761E0
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2276050 Offset: 0x2274650 VA: 0x182276050
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2276220 Offset: 0x2274820 VA: 0x182276220
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2276110 Offset: 0x2274710 VA: 0x182276110
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2276150 Offset: 0x2274750 VA: 0x182276150
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x22760D0 Offset: 0x22746D0 VA: 0x1822760D0
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2276090 Offset: 0x2274690 VA: 0x182276090
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2276190 Offset: 0x2274790 VA: 0x182276190
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275990 Offset: 0x2273F90 VA: 0x182275990
	public static bool[] FromBooleanArray(IntPtr array) { }

	[ObsoleteAttribute] // RVA: 0xC1D70 Offset: 0xC1170 VA: 0x1800C1D70
	[ThreadSafeAttribute] // RVA: 0xC1D70 Offset: 0xC1170 VA: 0x1800C1D70
	// RVA: 0x22759D0 Offset: 0x2273FD0 VA: 0x1822759D0
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275B90 Offset: 0x2274190 VA: 0x182275B90
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275A10 Offset: 0x2274010 VA: 0x182275A10
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275BD0 Offset: 0x22741D0 VA: 0x182275BD0
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275AD0 Offset: 0x22740D0 VA: 0x182275AD0
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275B10 Offset: 0x2274110 VA: 0x182275B10
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275A90 Offset: 0x2274090 VA: 0x182275A90
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275A50 Offset: 0x2274050 VA: 0x182275A50
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275C10 Offset: 0x2274210 VA: 0x182275C10
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275E50 Offset: 0x2274450 VA: 0x182275E50
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275CB0 Offset: 0x22742B0 VA: 0x182275CB0
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x2275F80 Offset: 0x2274580 VA: 0x182275F80
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

}

internal class AndroidJNISafe // TypeDefIndex: 4475
{	// Methods

	// RVA: 0x22738E0 Offset: 0x2271EE0 VA: 0x1822738E0
	public static void CheckException() { }

	// RVA: 0x2273A90 Offset: 0x2272090 VA: 0x182273A90
	public static void DeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x2273B70 Offset: 0x2272170 VA: 0x182273B70
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x2273B00 Offset: 0x2272100 VA: 0x182273B00
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x22748B0 Offset: 0x2272EB0 VA: 0x1822748B0
	public static IntPtr NewString(string chars) { }

	// RVA: 0x2274730 Offset: 0x2272D30 VA: 0x182274730
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x22745B0 Offset: 0x2272BB0 VA: 0x1822745B0
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x2274660 Offset: 0x2272C60 VA: 0x182274660
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x2274420 Offset: 0x2272A20 VA: 0x182274420
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x2274160 Offset: 0x2272760 VA: 0x182274160
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x2273BE0 Offset: 0x22721E0 VA: 0x182273BE0
	public static IntPtr FindClass(string name) { }

	// RVA: 0x22747E0 Offset: 0x2272DE0 VA: 0x1822747E0
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273760 Offset: 0x2271D60 VA: 0x182273760
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273420 Offset: 0x2271A20 VA: 0x182273420
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273690 Offset: 0x2271C90 VA: 0x182273690
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273020 Offset: 0x2271620 VA: 0x182273020
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22730F0 Offset: 0x22716F0 VA: 0x1822730F0
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22731C0 Offset: 0x22717C0 VA: 0x1822731C0
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273350 Offset: 0x2271950 VA: 0x182273350
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22735C0 Offset: 0x2271BC0 VA: 0x1822735C0
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22734F0 Offset: 0x2271AF0 VA: 0x1822734F0
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272F50 Offset: 0x2271550 VA: 0x182272F50
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273290 Offset: 0x2271890 VA: 0x182273290
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272CE0 Offset: 0x22712E0 VA: 0x182272CE0
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273810 Offset: 0x2271E10 VA: 0x182273810
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22728E0 Offset: 0x2270EE0 VA: 0x1822728E0
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22729B0 Offset: 0x2270FB0 VA: 0x1822729B0
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272A80 Offset: 0x2271080 VA: 0x182272A80
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272C10 Offset: 0x2271210 VA: 0x182272C10
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272E80 Offset: 0x2271480 VA: 0x182272E80
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272DB0 Offset: 0x22713B0 VA: 0x182272DB0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272810 Offset: 0x2270E10 VA: 0x182272810
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272B50 Offset: 0x2271150 VA: 0x182272B50
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273DF0 Offset: 0x22723F0 VA: 0x182273DF0
	public static char[] FromCharArray(IntPtr array) { }

	// RVA: 0x2273EA0 Offset: 0x22724A0 VA: 0x182273EA0
	public static double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x2273F50 Offset: 0x2272550 VA: 0x182273F50
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x22740B0 Offset: 0x22726B0 VA: 0x1822740B0
	public static long[] FromLongArray(IntPtr array) { }

	// RVA: 0x22742C0 Offset: 0x22728C0 VA: 0x1822742C0
	public static short[] FromShortArray(IntPtr array) { }

	// RVA: 0x2273D40 Offset: 0x2272340 VA: 0x182273D40
	public static byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x2274210 Offset: 0x2272810 VA: 0x182274210
	public static sbyte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x2273C90 Offset: 0x2272290 VA: 0x182273C90
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x2274000 Offset: 0x2272600 VA: 0x182274000
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x2274E30 Offset: 0x2273430 VA: 0x182274E30
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x2274AC0 Offset: 0x22730C0 VA: 0x182274AC0
	public static IntPtr ToCharArray(char[] array) { }

	// RVA: 0x2274B70 Offset: 0x2273170 VA: 0x182274B70
	public static IntPtr ToDoubleArray(double[] array) { }

	// RVA: 0x2274C20 Offset: 0x2273220 VA: 0x182274C20
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x2274D80 Offset: 0x2273380 VA: 0x182274D80
	public static IntPtr ToLongArray(long[] array) { }

	// RVA: 0x2274FA0 Offset: 0x22735A0 VA: 0x182274FA0
	public static IntPtr ToShortArray(short[] array) { }

	// RVA: 0x2274A10 Offset: 0x2273010 VA: 0x182274A10
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x2274EF0 Offset: 0x22734F0 VA: 0x182274EF0
	public static IntPtr ToSByteArray(sbyte[] array) { }

	// RVA: 0x2274960 Offset: 0x2272F60 VA: 0x182274960
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x2274CD0 Offset: 0x22732D0 VA: 0x182274CD0
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x22744F0 Offset: 0x2272AF0 VA: 0x1822744F0
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x2274370 Offset: 0x2272970 VA: 0x182274370
	public static int GetArrayLength(IntPtr array) { }

}

