internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 5922
{	// Fields
	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x2B103D0

	// Properties
	internal static ReflectionDelegateFactory Instance { get; }

	// Methods

	// RVA: 0x17F7830 Offset: 0x17F5E30 VA: 0x1817F7830
	internal static ReflectionDelegateFactory get_Instance() { }

	// RVA: 0x17F7650 Offset: 0x17F5C50 VA: 0x1817F7650 Slot: 5
	public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DCB0 Offset: 0x125C2B0 VA: 0x18125DCB0
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<object>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override Func<T> CreateDefaultConstructor<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1ABA0 Offset: 0x1B191A0 VA: 0x181B1ABA0
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1AE10 Offset: 0x1B19410 VA: 0x181B1AE10
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1AD20 Offset: 0x1B19320 VA: 0x181B1AD20
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DE00 Offset: 0x125C400 VA: 0x18125DE00
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DEF0 Offset: 0x125C4F0 VA: 0x18125DEF0
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	*/

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x17F77D0 Offset: 0x17F5DD0 VA: 0x1817F77D0
	private static void .cctor() { }

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass3_0 // TypeDefIndex: 5923
{	// Fields
	public ConstructorInfo c; // 0x10
	public MethodBase method; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x18028B0 Offset: 0x1800EB0 VA: 0x1818028B0
	internal object <CreateParameterizedConstructor>b__0(object[] a) { }

	// RVA: 0x18028D0 Offset: 0x1800ED0 VA: 0x1818028D0
	internal object <CreateParameterizedConstructor>b__1(object[] a) { }

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<T> // TypeDefIndex: 5924
{	// Fields
	public ConstructorInfo c; // 0x0
	public MethodBase method; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <CreateMethodCall>b__0(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66090 Offset: 0xD64690 VA: 0x180D66090
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__0
	*/

	// RVA: -1 Offset: -1
	internal object <CreateMethodCall>b__1(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD660C0 Offset: 0xD646C0 VA: 0x180D660C0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__1
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<T> // TypeDefIndex: 5925
{	// Fields
	public Type type; // 0x0
	public ConstructorInfo constructorInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T <CreateDefaultConstructor>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD660E0 Offset: 0xD646E0 VA: 0x180D660E0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__0
	*/

	// RVA: -1 Offset: -1
	internal T <CreateDefaultConstructor>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66150 Offset: 0xD64750 VA: 0x180D66150
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__1
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<T> // TypeDefIndex: 5926
{	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD661D0 Offset: 0xD647D0 VA: 0x180D661D0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>.<CreateGet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<T> // TypeDefIndex: 5927
{	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66200 Offset: 0xD64800 VA: 0x180D66200
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>.<CreateGet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<T> // TypeDefIndex: 5928
{	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66230 Offset: 0xD64830 VA: 0x180D66230
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>.<CreateSet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<T> // TypeDefIndex: 5929
{	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66250 Offset: 0xD64850 VA: 0x180D66250
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>.<CreateSet>b__0
	*/

}

