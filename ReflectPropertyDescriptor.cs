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

	// RVA: 0x15D4D30 Offset: 0x15D3330 VA: 0x1815D4D30
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x15D4BD0 Offset: 0x15D31D0 VA: 0x1815D4BD0
	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x15D4F30 Offset: 0x15D3530 VA: 0x1815D4F30
	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x15D5020 Offset: 0x15D3620 VA: 0x1815D5020
	private object get_DefaultValue() { }

	// RVA: 0x15D5370 Offset: 0x15D3970 VA: 0x1815D5370
	private MethodInfo get_GetMethodValue() { }

	// RVA: 0x15D5850 Offset: 0x15D3E50 VA: 0x1815D5850
	private bool get_IsExtender() { }

	// RVA: 0x15D58B0 Offset: 0x15D3EB0 VA: 0x1815D58B0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x15D59A0 Offset: 0x15D3FA0 VA: 0x1815D59A0
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0x15D6030 Offset: 0x15D4630 VA: 0x1815D6030
	private MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0x79BDF0 Offset: 0x79A3F0 VA: 0x18079BDF0
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0x15D2AC0 Offset: 0x15D10C0 VA: 0x1815D2AC0
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x15D2AE0 Offset: 0x15D10E0 VA: 0x1815D2AE0
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x15D2C40 Offset: 0x15D1240 VA: 0x1815D2C40
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x15D2F80 Offset: 0x15D1580 VA: 0x1815D2F80
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x15D3370 Offset: 0x15D1970 VA: 0x1815D3370 Slot: 11
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x15D3E60 Offset: 0x15D2460 VA: 0x1815D3E60 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x15D4150 Offset: 0x15D2750 VA: 0x1815D4150 Slot: 18
	protected override void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x15D4250 Offset: 0x15D2850 VA: 0x1815D4250 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x15D4640 Offset: 0x15D2C40 VA: 0x1815D4640 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x15D4920 Offset: 0x15D2F20 VA: 0x1815D4920
	private static void .cctor() { }

}

