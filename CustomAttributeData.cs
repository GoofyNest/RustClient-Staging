public class CustomAttributeData // TypeDefIndex: 560
{	// Fields
	private ConstructorInfo ctorInfo; // 0x10
	private IList<CustomAttributeTypedArgument> ctorArgs; // 0x18
	private IList<CustomAttributeNamedArgument> namedArgs; // 0x20
	private CustomAttributeData.LazyCAttrData lazyData; // 0x28

	// Properties
	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public virtual ConstructorInfo Constructor { get; }
	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; }
	public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; }
	public Type AttributeType { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18C7370 Offset: 0x18C5970 VA: 0x1818C7370
	internal void .ctor(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	// RVA: 0x18C6C10 Offset: 0x18C5210 VA: 0x1818C6C10
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	// RVA: 0x18C6C20 Offset: 0x18C5220 VA: 0x1818C6C20
	private void ResolveArguments() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 4
	public virtual ConstructorInfo get_Constructor() { }

	// RVA: 0x18C7440 Offset: 0x18C5A40 VA: 0x1818C7440 Slot: 5
	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	// RVA: 0x18C7460 Offset: 0x18C5A60 VA: 0x1818C7460 Slot: 6
	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	// RVA: 0x18C6750 Offset: 0x18C4D50 VA: 0x1818C6750
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	// RVA: 0x18C67B0 Offset: 0x18C4DB0 VA: 0x1818C67B0
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	// RVA: 0x18C6630 Offset: 0x18C4C30 VA: 0x1818C6630
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	// RVA: 0x18C66F0 Offset: 0x18C4CF0 VA: 0x1818C66F0
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	// RVA: 0x18C6690 Offset: 0x18C4C90 VA: 0x1818C6690
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	// RVA: 0xBC92E0 Offset: 0xBC78E0 VA: 0x180BC92E0
	public Type get_AttributeType() { }

	// RVA: 0x18C6D80 Offset: 0x18C5380 VA: 0x1818C6D80 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static T[] UnboxValues<T>(object[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A37180 Offset: 0x1A35780 VA: 0x181A37180
	|-CustomAttributeData.UnboxValues<object>
	|
	|-RVA: 0x1A36F20 Offset: 0x1A35520 VA: 0x181A36F20
	|-CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>
	|
	|-RVA: 0x1A37060 Offset: 0x1A35660 VA: 0x181A37060
	|-CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>
	*/

	// RVA: 0x18C61C0 Offset: 0x18C47C0 VA: 0x1818C61C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x18C6810 Offset: 0x18C4E10 VA: 0x1818C6810 Slot: 2
	public override int GetHashCode() { }

}

private class CustomAttributeData.LazyCAttrData // TypeDefIndex: 561
{	// Fields
	internal Assembly assembly; // 0x10
	internal IntPtr data; // 0x18
	internal uint data_length; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

