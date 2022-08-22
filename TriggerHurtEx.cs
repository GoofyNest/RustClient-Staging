public class TriggerHurtEx : TriggerBase, IServerComponent, IHurtTrigger // TypeDefIndex: 10714
{	// Fields
	public float repeatRate; // 0x30
	[HeaderAttribute] // RVA: 0x75500 Offset: 0x74900 VA: 0x180075500
	public List<DamageTypeEntry> damageOnEnter; // 0x38
	public GameObjectRef effectOnEnter; // 0x40
	public TriggerHurtEx.HurtType hurtTypeOnEnter; // 0x48
	[HeaderAttribute] // RVA: 0x75660 Offset: 0x74A60 VA: 0x180075660
	public List<DamageTypeEntry> damageOnTimer; // 0x50
	public GameObjectRef effectOnTimer; // 0x58
	public TriggerHurtEx.HurtType hurtTypeOnTimer; // 0x60
	[HeaderAttribute] // RVA: 0x75770 Offset: 0x74B70 VA: 0x180075770
	public List<DamageTypeEntry> damageOnMove; // 0x68
	public GameObjectRef effectOnMove; // 0x70
	public TriggerHurtEx.HurtType hurtTypeOnMove; // 0x78
	[HeaderAttribute] // RVA: 0x75970 Offset: 0x74D70 VA: 0x180075970
	public List<DamageTypeEntry> damageOnLeave; // 0x80
	public GameObjectRef effectOnLeave; // 0x88
	public TriggerHurtEx.HurtType hurtTypeOnLeave; // 0x90
	public bool damageEnabled; // 0x94

	// Methods

	// RVA: 0xA21830 Offset: 0xA1FE30 VA: 0x180A21830
	public void .ctor() { }

}

public enum TriggerHurtEx.HurtType // TypeDefIndex: 10715
{	// Fields
	public int value__; // 0x0
	public const TriggerHurtEx.HurtType Simple = 0;
	public const TriggerHurtEx.HurtType IncludeBleedingAndScreenShake = 1;

}

