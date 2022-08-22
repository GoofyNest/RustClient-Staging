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

	// RVA: 0x22763C0 Offset: 0x22749C0 VA: 0x1822763C0
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x2276440 Offset: 0x2274A40 VA: 0x182276440 Slot: 8
	public override string get_StackTrace() { }

}

internal class AndroidJavaRunnableProxy : AndroidJavaProxy // TypeDefIndex: 4466
{	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x2277BE0 Offset: 0x22761E0 VA: 0x182277BE0
	public void .ctor(AndroidJavaRunnable runnable) { }

}

public class AndroidJavaProxy // TypeDefIndex: 4467
{	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0x2277AE0 Offset: 0x22760E0 VA: 0x182277AE0
	public void .ctor(string javaInterface) { }

	// RVA: 0x2277B80 Offset: 0x2276180 VA: 0x182277B80
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x2276E70 Offset: 0x2275470 VA: 0x182276E70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x22772A0 Offset: 0x22758A0 VA: 0x1822772A0 Slot: 4
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x22770C0 Offset: 0x22756C0 VA: 0x1822770C0 Slot: 5
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x2276F50 Offset: 0x2275550 VA: 0x182276F50
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x2276FB0 Offset: 0x22755B0 VA: 0x182276FB0
	internal IntPtr GetRawProxy() { }

	// RVA: 0x2277A10 Offset: 0x2276010 VA: 0x182277A10
	private static void .cctor() { }

}

public class AndroidJavaObject : IDisposable // TypeDefIndex: 4468
{	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x2276E30 Offset: 0x2275430 VA: 0x182276E30
	public void .ctor(string className, object[] args) { }

	// RVA: 0x2276740 Offset: 0x2274D40 VA: 0x182276740 Slot: 4
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

	// RVA: 0x22766B0 Offset: 0x2274CB0 VA: 0x1822766B0
	protected void DebugPrint(string msg) { }

	// RVA: 0x22768B0 Offset: 0x2274EB0 VA: 0x1822768B0
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x2276CE0 Offset: 0x22752E0 VA: 0x182276CE0
	internal void .ctor(IntPtr jobject) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x2276810 Offset: 0x2274E10 VA: 0x182276810 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x22767B0 Offset: 0x2274DB0 VA: 0x1822767B0 Slot: 5
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

	// RVA: 0x2276590 Offset: 0x2274B90 VA: 0x182276590
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x2276470 Offset: 0x2274A70 VA: 0x182276470
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0x4D2120 Offset: 0x4D0720 VA: 0x1804D2120
	protected IntPtr _GetRawObject() { }

	// RVA: 0x855180 Offset: 0x853780 VA: 0x180855180
	protected IntPtr _GetRawClass() { }

	// RVA: 0x2276CA0 Offset: 0x22752A0 VA: 0x182276CA0
	private static void .cctor() { }

}

public class AndroidJavaClass : AndroidJavaObject // TypeDefIndex: 4469
{	// Methods

	// RVA: 0x2276290 Offset: 0x2274890 VA: 0x182276290
	public void .ctor(string className) { }

	// RVA: 0x22760A0 Offset: 0x22746A0 VA: 0x1822760A0
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x2276190 Offset: 0x2274790 VA: 0x182276190
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

	// RVA: 0x22783F0 Offset: 0x22769F0 VA: 0x1822783F0
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x22783C0 Offset: 0x22769C0 VA: 0x1822783C0
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x22782B0 Offset: 0x22768B0 VA: 0x1822782B0
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x2277EE0 Offset: 0x22764E0 VA: 0x182277EE0
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x2277CE0 Offset: 0x22762E0 VA: 0x182277CE0
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x2277FF0 Offset: 0x22765F0 VA: 0x182277FF0
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x2278410 Offset: 0x2276A10 VA: 0x182278410
	public static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x2278500 Offset: 0x2276B00 VA: 0x182278500
	public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound) { }

	// RVA: 0x2278640 Offset: 0x2276C40 VA: 0x182278640
	private static void .cctor() { }

}

public static class AndroidJNIHelper // TypeDefIndex: 4473
{	// Methods

	// RVA: 0x2272630 Offset: 0x2270C30 VA: 0x182272630
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x2272640 Offset: 0x2270C40 VA: 0x182272640
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x22722D0 Offset: 0x22708D0 VA: 0x1822722D0
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x2272100 Offset: 0x2270700 VA: 0x182272100
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x22720F0 Offset: 0x22706F0 VA: 0x1822720F0
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x2272400 Offset: 0x2270A00 VA: 0x182272400
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x2272530 Offset: 0x2270B30 VA: 0x182272530
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

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275790 Offset: 0x2273D90 VA: 0x182275790
	public static IntPtr FindClass(string name) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275990 Offset: 0x2273F90 VA: 0x182275990
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275760 Offset: 0x2273D60 VA: 0x182275760
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275730 Offset: 0x2273D30 VA: 0x182275730
	public static void ExceptionClear() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275C10 Offset: 0x2274210 VA: 0x182275C10
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275670 Offset: 0x2273C70 VA: 0x182275670
	public static void DeleteGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275D80 Offset: 0x2274380 VA: 0x182275D80
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22756F0 Offset: 0x2273CF0 VA: 0x1822756F0
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275C50 Offset: 0x2274250 VA: 0x182275C50
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22756B0 Offset: 0x2273CB0 VA: 0x1822756B0
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275CE0 Offset: 0x22742E0 VA: 0x182275CE0
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275B30 Offset: 0x2274130 VA: 0x182275B30
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275A90 Offset: 0x2274090 VA: 0x182275A90
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275B70 Offset: 0x2274170 VA: 0x182275B70
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x2275D40 Offset: 0x2274340 VA: 0x182275D40
	public static IntPtr NewString(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275D40 Offset: 0x2274340 VA: 0x182275D40
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275BD0 Offset: 0x22741D0 VA: 0x182275BD0
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275610 Offset: 0x2273C10 VA: 0x182275610
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22750D0 Offset: 0x22736D0 VA: 0x1822750D0
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275010 Offset: 0x2273610 VA: 0x182275010
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2274E90 Offset: 0x2273490 VA: 0x182274E90
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275190 Offset: 0x2273790 VA: 0x182275190
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275130 Offset: 0x2273730 VA: 0x182275130
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2274EF0 Offset: 0x22734F0 VA: 0x182274EF0
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2274FB0 Offset: 0x22735B0 VA: 0x182274FB0
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2274F50 Offset: 0x2273550 VA: 0x182274F50
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275070 Offset: 0x2273670 VA: 0x182275070
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275550 Offset: 0x2273B50 VA: 0x182275550
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275430 Offset: 0x2273A30 VA: 0x182275430
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275370 Offset: 0x2273970 VA: 0x182275370
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22751F0 Offset: 0x22737F0 VA: 0x1822751F0
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22754F0 Offset: 0x2273AF0 VA: 0x1822754F0
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275490 Offset: 0x2273A90 VA: 0x182275490
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275250 Offset: 0x2273850 VA: 0x182275250
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275310 Offset: 0x2273910 VA: 0x182275310
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22752B0 Offset: 0x22738B0 VA: 0x1822752B0
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22753D0 Offset: 0x22739D0 VA: 0x1822753D0
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22755B0 Offset: 0x2273BB0 VA: 0x1822755B0
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275E10 Offset: 0x2274410 VA: 0x182275E10
	public static IntPtr ToBooleanArray(bool[] array) { }

	[ThreadSafeAttribute] // RVA: 0xC15F0 Offset: 0xC09F0 VA: 0x1800C15F0
	[ObsoleteAttribute] // RVA: 0xC15F0 Offset: 0xC09F0 VA: 0x1800C15F0
	// RVA: 0x2275E50 Offset: 0x2274450 VA: 0x182275E50
	public static IntPtr ToByteArray(byte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276020 Offset: 0x2274620 VA: 0x182276020
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275E90 Offset: 0x2274490 VA: 0x182275E90
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276060 Offset: 0x2274660 VA: 0x182276060
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275F50 Offset: 0x2274550 VA: 0x182275F50
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275F90 Offset: 0x2274590 VA: 0x182275F90
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275F10 Offset: 0x2274510 VA: 0x182275F10
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275ED0 Offset: 0x22744D0 VA: 0x182275ED0
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275FD0 Offset: 0x22745D0 VA: 0x182275FD0
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22757D0 Offset: 0x2273DD0 VA: 0x1822757D0
	public static bool[] FromBooleanArray(IntPtr array) { }

	[ObsoleteAttribute] // RVA: 0xC1E10 Offset: 0xC1210 VA: 0x1800C1E10
	[ThreadSafeAttribute] // RVA: 0xC1E10 Offset: 0xC1210 VA: 0x1800C1E10
	// RVA: 0x2275810 Offset: 0x2273E10 VA: 0x182275810
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22759D0 Offset: 0x2273FD0 VA: 0x1822759D0
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275850 Offset: 0x2273E50 VA: 0x182275850
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275A10 Offset: 0x2274010 VA: 0x182275A10
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275910 Offset: 0x2273F10 VA: 0x182275910
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275950 Offset: 0x2273F50 VA: 0x182275950
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22758D0 Offset: 0x2273ED0 VA: 0x1822758D0
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275890 Offset: 0x2273E90 VA: 0x182275890
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275A50 Offset: 0x2274050 VA: 0x182275A50
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275C90 Offset: 0x2274290 VA: 0x182275C90
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275AF0 Offset: 0x22740F0 VA: 0x182275AF0
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275DC0 Offset: 0x22743C0 VA: 0x182275DC0
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

}

internal class AndroidJNISafe // TypeDefIndex: 4475
{	// Methods

	// RVA: 0x2273720 Offset: 0x2271D20 VA: 0x182273720
	public static void CheckException() { }

	// RVA: 0x22738D0 Offset: 0x2271ED0 VA: 0x1822738D0
	public static void DeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x22739B0 Offset: 0x2271FB0 VA: 0x1822739B0
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x2273940 Offset: 0x2271F40 VA: 0x182273940
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x22746F0 Offset: 0x2272CF0 VA: 0x1822746F0
	public static IntPtr NewString(string chars) { }

	// RVA: 0x2274570 Offset: 0x2272B70 VA: 0x182274570
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x22743F0 Offset: 0x22729F0 VA: 0x1822743F0
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x22744A0 Offset: 0x2272AA0 VA: 0x1822744A0
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x2274260 Offset: 0x2272860 VA: 0x182274260
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x2273FA0 Offset: 0x22725A0 VA: 0x182273FA0
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x2273A20 Offset: 0x2272020 VA: 0x182273A20
	public static IntPtr FindClass(string name) { }

	// RVA: 0x2274620 Offset: 0x2272C20 VA: 0x182274620
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22735A0 Offset: 0x2271BA0 VA: 0x1822735A0
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273260 Offset: 0x2271860 VA: 0x182273260
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22734D0 Offset: 0x2271AD0 VA: 0x1822734D0
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272E60 Offset: 0x2271460 VA: 0x182272E60
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272F30 Offset: 0x2271530 VA: 0x182272F30
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273000 Offset: 0x2271600 VA: 0x182273000
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273190 Offset: 0x2271790 VA: 0x182273190
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273400 Offset: 0x2271A00 VA: 0x182273400
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273330 Offset: 0x2271930 VA: 0x182273330
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272D90 Offset: 0x2271390 VA: 0x182272D90
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22730D0 Offset: 0x22716D0 VA: 0x1822730D0
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272B20 Offset: 0x2271120 VA: 0x182272B20
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273650 Offset: 0x2271C50 VA: 0x182273650
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272720 Offset: 0x2270D20 VA: 0x182272720
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22727F0 Offset: 0x2270DF0 VA: 0x1822727F0
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22728C0 Offset: 0x2270EC0 VA: 0x1822728C0
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272A50 Offset: 0x2271050 VA: 0x182272A50
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272CC0 Offset: 0x22712C0 VA: 0x182272CC0
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272BF0 Offset: 0x22711F0 VA: 0x182272BF0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272650 Offset: 0x2270C50 VA: 0x182272650
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272990 Offset: 0x2270F90 VA: 0x182272990
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273C30 Offset: 0x2272230 VA: 0x182273C30
	public static char[] FromCharArray(IntPtr array) { }

	// RVA: 0x2273CE0 Offset: 0x22722E0 VA: 0x182273CE0
	public static double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x2273D90 Offset: 0x2272390 VA: 0x182273D90
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x2273EF0 Offset: 0x22724F0 VA: 0x182273EF0
	public static long[] FromLongArray(IntPtr array) { }

	// RVA: 0x2274100 Offset: 0x2272700 VA: 0x182274100
	public static short[] FromShortArray(IntPtr array) { }

	// RVA: 0x2273B80 Offset: 0x2272180 VA: 0x182273B80
	public static byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x2274050 Offset: 0x2272650 VA: 0x182274050
	public static sbyte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x2273AD0 Offset: 0x22720D0 VA: 0x182273AD0
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x2273E40 Offset: 0x2272440 VA: 0x182273E40
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x2274C70 Offset: 0x2273270 VA: 0x182274C70
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x2274900 Offset: 0x2272F00 VA: 0x182274900
	public static IntPtr ToCharArray(char[] array) { }

	// RVA: 0x22749B0 Offset: 0x2272FB0 VA: 0x1822749B0
	public static IntPtr ToDoubleArray(double[] array) { }

	// RVA: 0x2274A60 Offset: 0x2273060 VA: 0x182274A60
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x2274BC0 Offset: 0x22731C0 VA: 0x182274BC0
	public static IntPtr ToLongArray(long[] array) { }

	// RVA: 0x2274DE0 Offset: 0x22733E0 VA: 0x182274DE0
	public static IntPtr ToShortArray(short[] array) { }

	// RVA: 0x2274850 Offset: 0x2272E50 VA: 0x182274850
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x2274D30 Offset: 0x2273330 VA: 0x182274D30
	public static IntPtr ToSByteArray(sbyte[] array) { }

	// RVA: 0x22747A0 Offset: 0x2272DA0 VA: 0x1822747A0
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x2274B10 Offset: 0x2273110 VA: 0x182274B10
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x2274330 Offset: 0x2272930 VA: 0x182274330
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x22741B0 Offset: 0x22727B0 VA: 0x1822741B0
	public static int GetArrayLength(IntPtr array) { }

}

