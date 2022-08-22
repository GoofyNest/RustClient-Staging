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

	// RVA: 0x18C7990 Offset: 0x18C5F90 VA: 0x1818C7990
	internal void .ctor(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	// RVA: 0x18C7230 Offset: 0x18C5830 VA: 0x1818C7230
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	// RVA: 0x18C7240 Offset: 0x18C5840 VA: 0x1818C7240
	private void ResolveArguments() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public virtual ConstructorInfo get_Constructor() { }

	// RVA: 0x18C7A60 Offset: 0x18C6060 VA: 0x1818C7A60 Slot: 5
	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	// RVA: 0x18C7A80 Offset: 0x18C6080 VA: 0x1818C7A80 Slot: 6
	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	// RVA: 0x18C6D70 Offset: 0x18C5370 VA: 0x1818C6D70
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	// RVA: 0x18C6DD0 Offset: 0x18C53D0 VA: 0x1818C6DD0
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	// RVA: 0x18C6C50 Offset: 0x18C5250 VA: 0x1818C6C50
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	// RVA: 0x18C6D10 Offset: 0x18C5310 VA: 0x1818C6D10
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	// RVA: 0x18C6CB0 Offset: 0x18C52B0 VA: 0x1818C6CB0
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	// RVA: 0xBC8B50 Offset: 0xBC7150 VA: 0x180BC8B50
	public Type get_AttributeType() { }

	// RVA: 0x18C73A0 Offset: 0x18C59A0 VA: 0x1818C73A0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static T[] UnboxValues<T>(object[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A377A0 Offset: 0x1A35DA0 VA: 0x181A377A0
	|-CustomAttributeData.UnboxValues<object>
	|
	|-RVA: 0x1A37540 Offset: 0x1A35B40 VA: 0x181A37540
	|-CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>
	|
	|-RVA: 0x1A37680 Offset: 0x1A35C80 VA: 0x181A37680
	|-CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>
	*/

	// RVA: 0x18C67E0 Offset: 0x18C4DE0 VA: 0x1818C67E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x18C6E30 Offset: 0x18C5430 VA: 0x1818C6E30 Slot: 2
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

