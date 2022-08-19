internal sealed class ReflectPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2741
{	// Fields
	private static readonly Type[] argsNone; // 0x0
	private static readonly object noValue; // 0x8
	private static TraceSwitch PropDescCreateSwitch; // 0x10
	private static TraceSwitch PropDescUsageSwitch; // 0x18
	private static readonly int BitDefaultValueQueried; // 0x20
	private static readonly int BitGetQueried; // 0x24
	private static readonly int BitSetQueried; // 0x28
	private static readonly int BitShouldSerializeQueried; // 0x2C
	private static readonly int BitResetQueried; // 0x30
	private static readonly int BitChangedQueried; // 0x34
	private static readonly int BitIPropChangedQueried; // 0x38
	private static readonly int BitReadOnlyChecked; // 0x3C
	private static readonly int BitAmbientValueQueried; // 0x40
	private static readonly int BitSetOnDemand; // 0x44
	private BitVector32 state; // 0x88
	private Type componentClass; // 0x90
	private Type type; // 0x98
	private object defaultValue; // 0xA0
	private PropertyInfo propInfo; // 0xA8
	private MethodInfo getMethod; // 0xB0
	private MethodInfo setMethod; // 0xB8
	private MethodInfo shouldSerializeMethod; // 0xC0
	private EventDescriptor realChangedEvent; // 0xC8
	private Type receiverType; // 0xD0

	// Properties
	public override Type ComponentType { get; }
	private object DefaultValue { get; }
	private MethodInfo GetMethodValue { get; }
	private bool IsExtender { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	private MethodInfo SetMethodValue { get; }
	private MethodInfo ShouldSerializeMethodValue { get; }

	// Methods

	// RVA: 0x15D59A0 Offset: 0x15D3FA0 VA: 0x1815D59A0
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x15D5840 Offset: 0x15D3E40 VA: 0x1815D5840
	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x15D5BA0 Offset: 0x15D41A0 VA: 0x1815D5BA0
	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x15D5C90 Offset: 0x15D4290 VA: 0x1815D5C90
	private object get_DefaultValue() { }

	// RVA: 0x15D5FE0 Offset: 0x15D45E0 VA: 0x1815D5FE0
	private MethodInfo get_GetMethodValue() { }

	// RVA: 0x15D64C0 Offset: 0x15D4AC0 VA: 0x1815D64C0
	private bool get_IsExtender() { }

	// RVA: 0x15D6520 Offset: 0x15D4B20 VA: 0x1815D6520 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x15D6610 Offset: 0x15D4C10 VA: 0x1815D6610
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0x15D6CA0 Offset: 0x15D52A0 VA: 0x1815D6CA0
	private MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0xC73A80 Offset: 0xC72080 VA: 0x180C73A80
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0x15D3730 Offset: 0x15D1D30 VA: 0x1815D3730
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x15D3750 Offset: 0x15D1D50 VA: 0x1815D3750
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x15D38B0 Offset: 0x15D1EB0 VA: 0x1815D38B0
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x15D3BF0 Offset: 0x15D21F0 VA: 0x1815D3BF0
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x15D3FE0 Offset: 0x15D25E0 VA: 0x1815D3FE0 Slot: 11
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x15D4AD0 Offset: 0x15D30D0 VA: 0x1815D4AD0 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x15D4DC0 Offset: 0x15D33C0 VA: 0x1815D4DC0 Slot: 18
	protected override void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x15D4EC0 Offset: 0x15D34C0 VA: 0x1815D4EC0 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x15D52B0 Offset: 0x15D38B0 VA: 0x1815D52B0 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x15D5590 Offset: 0x15D3B90 VA: 0x1815D5590
	private static void .cctor() { }

}

