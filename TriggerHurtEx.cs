public class TriggerHurtEx : TriggerBase, IServerComponent, IHurtTrigger // TypeDefIndex: 10714
{	// Fields
	public float repeatRate; // 0x30
	[HeaderAttribute] // RVA: 0x75400 Offset: 0x74800 VA: 0x180075400
	public List<DamageTypeEntry> damageOnEnter; // 0x38
	public GameObjectRef effectOnEnter; // 0x40
	public TriggerHurtEx.HurtType hurtTypeOnEnter; // 0x48
	[HeaderAttribute] // RVA: 0x75540 Offset: 0x74940 VA: 0x180075540
	public List<DamageTypeEntry> damageOnTimer; // 0x50
	public GameObjectRef effectOnTimer; // 0x58
	public TriggerHurtEx.HurtType hurtTypeOnTimer; // 0x60
	[HeaderAttribute] // RVA: 0x75670 Offset: 0x74A70 VA: 0x180075670
	public List<DamageTypeEntry> damageOnMove; // 0x68
	public GameObjectRef effectOnMove; // 0x70
	public TriggerHurtEx.HurtType hurtTypeOnMove; // 0x78
	[HeaderAttribute] // RVA: 0x75870 Offset: 0x74C70 VA: 0x180075870
	public List<DamageTypeEntry> damageOnLeave; // 0x80
	public GameObjectRef effectOnLeave; // 0x88
	public TriggerHurtEx.HurtType hurtTypeOnLeave; // 0x90
	public bool damageEnabled; // 0x94

	// Methods

	// RVA: 0xA21570 Offset: 0xA1FB70 VA: 0x180A21570
	public void .ctor() { }

}

public enum TriggerHurtEx.HurtType // TypeDefIndex: 10715
{	// Fields
	public int value__; // 0x0
	public const TriggerHurtEx.HurtType Simple = 0;
	public const TriggerHurtEx.HurtType IncludeBleedingAndScreenShake = 1;

}

